using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.DTO.LeaveManagement;
using ApnaKaryala.Model.Models.LeaveManagement;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Repositories.LeaveManagement
{
    public class LeaveRepository: RepositoryBase<LeaveDetails>, ILeaveRepository
    {
        private readonly string _connectionString;
        public LeaveRepository(IDbFactory dbFactory)
        : base(dbFactory) {

            _connectionString = MasterContext.Database.Connection.ConnectionString;
        }
        public List<LeaveTypeDto> GetAllLeaveType(LeaveTypeDto req)
        {
            List<LeaveTypeDto> lstleavetype = new List<LeaveTypeDto>();
            try
            {

                var leavetype = MasterContext.LeaveType.Where(i => i.SiteId == req.SiteId).ToList();
                lstleavetype = Mapper.Convert<LeaveTypeDto, LeaveType>(leavetype);

            }
            catch (Exception ex)
            {

            }
            return lstleavetype;
        }

        public bool savenewleavedata(LeaveDetailsDto obj)
        {
            bool result = false;
            try
            {
                var leaveentry = Mapper.Convert<LeaveDetails, LeaveDetailsDto>(obj);
                var leaveall = MasterContext.LeaveDetails.Where(s=>s.SiteID == obj.SiteID && s.EmpID == obj.EmpID).ToList();


                var leave = (from s in leaveall
                             group s.ApplicationNo by s.ApplicationNo into appno
                             orderby appno.Key descending
                             select appno.Key).Take(1).FirstOrDefault();
                if (obj.LeaveCount>1)
                {
                    for(int i=0;i< obj.LeaveCount;i++)
                    {
                        leaveentry.LeaveDate = Convert.ToDateTime(obj.DateFrom).AddDays(i);
                        leaveentry.LeaveCount = 1;
                        leaveentry.LeaveTypeId = obj.LeaveTypeId;
                        leaveentry.ApplicationNo = leave+1;
                        MasterContext.Entry(leaveentry).State = EntityState.Added;
                        MasterContext.LeaveDetails.Add(leaveentry);
                        MasterContext.SaveChanges();
                    }
                }
                else
                {
                    MasterContext.Entry(leaveentry).State = EntityState.Added;
                    MasterContext.LeaveDetails.Add(leaveentry);
                    MasterContext.SaveChanges();
                }
              
                result = true;
            }
            catch (Exception ex)
            {
                result = false;
            }

            return result;
        }

        public List<LeaveDetailsDto> GetLeaveByEmployeeId(LeaveDetailsDto req)
        {
            List<LeaveDetailsDto> lstleavedetails = new List<LeaveDetailsDto>();
            try
            {

                DataTable dt = new DataTable();
                using (SqlConnection sqlConn = new SqlConnection(_connectionString))
                {
                    string sql = "GetLeaveByEmployeeId";
                    using (SqlCommand sqlCmd = new SqlCommand(sql, sqlConn))
                    {
                        sqlCmd.CommandType = CommandType.StoredProcedure;
                        sqlCmd.Parameters.AddWithValue("@siteId", req.SiteID);
                        sqlCmd.Parameters.AddWithValue("@EmployeeId", req.EmpID);

                        sqlConn.Open();
                        using (SqlDataAdapter sqlAdapter = new SqlDataAdapter(sqlCmd))
                        {
                            sqlAdapter.Fill(dt);
                        }
                    }
                }
                lstleavedetails = ConvertDataTable<LeaveDetailsDto>(dt);
            }
            catch (Exception ex)
            {

            }
            return lstleavedetails;
        }

        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                    {
                        object val = new object();
                        switch (column.DataType.Name)
                        {
                            case "Boolean":
                                val = dr[column.ColumnName] is DBNull ? false : dr[column.ColumnName];
                                break;
                            case "String":
                                val = dr[column.ColumnName] is DBNull ? string.Empty : dr[column.ColumnName];
                                break;
                            case "Int64":
                                if (pro.PropertyType == typeof(Nullable<Int64>))
                                    val = dr[column.ColumnName] is DBNull ? null : dr[column.ColumnName];
                                else
                                    val = dr[column.ColumnName] is DBNull ? 0 : dr[column.ColumnName];
                                break;
                            case "Int32":
                                if (pro.PropertyType == typeof(Nullable<Int32>))
                                    val = dr[column.ColumnName] is DBNull ? null : dr[column.ColumnName];
                                else
                                    val = dr[column.ColumnName] is DBNull ? 0 : dr[column.ColumnName];
                                break;
                            case "DateTime":
                                if (pro.PropertyType == typeof(Nullable<DateTime>))
                                    val = dr[column.ColumnName] is DBNull ? null : dr[column.ColumnName];
                                else
                                    val = dr[column.ColumnName] is DBNull ? "" : dr[column.ColumnName];
                                break;
                            case "Decimal":
                                if (pro.PropertyType == typeof(Nullable<Decimal>))
                                    val = dr[column.ColumnName] is DBNull ? null : dr[column.ColumnName];
                                else
                                    val = dr[column.ColumnName] is DBNull ? "" : dr[column.ColumnName];
                                break;
                            case "Char":
                                if (pro.PropertyType == typeof(Nullable<Char>))
                                    val = dr[column.ColumnName] is DBNull ? null : dr[column.ColumnName];
                                else
                                    val = dr[column.ColumnName] is DBNull ? "" : dr[column.ColumnName];
                                break;
                            case "TimeSpan":
                                if (pro.PropertyType == typeof(Nullable<TimeSpan>))
                                    val = dr[column.ColumnName] is DBNull ? null : dr[column.ColumnName];
                                else
                                    val = dr[column.ColumnName] is DBNull ? "" : dr[column.ColumnName];
                                break;

                            default:
                                val = dr[column.ColumnName];
                                break;
                        }
                        pro.SetValue(obj, val, null);
                    }
                    else
                        continue;
                }
            }
            return obj;
        }
    }
}
