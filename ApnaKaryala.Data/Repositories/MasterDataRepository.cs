using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.DTO.Master;
using ApnaKaryala.Model.Models.Employee;
using ApnaKaryala.Model.Models.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Repositories
{
    public class MasterDataRepository : RepositoryBase<Employee>, IMasterRepository
    {
        public MasterDataRepository(IDbFactory dbFactory)
          : base(dbFactory) { }
        public List<CityDto> GetAllCityByStateid(CityDto req)
        {
            List<CityDto> lstCity = new List<CityDto>();
            try
            {

                var city = MasterContext.City.Where(i => i.StateId == req.StateId && i.SiteId == req.SiteId).ToList();
                lstCity = Mapper.Convert<CityDto, City>(city);

            }
            catch (Exception ex)
            {
                
            }
            return lstCity;
        }

        public List<GenderDto> GetAllGender(GenderDto req)
        {
            List<GenderDto> lstGender = new List<GenderDto>();
            try
            {

                var Gender = MasterContext.Gender.Where(i => i.SiteId == req.SiteId).ToList();
                lstGender = Mapper.Convert<GenderDto, Gender>(Gender);

            }
            catch (Exception ex)
            {

            }
            return lstGender;
        }

        public List<StateDto> GetAllState(StateDto req)
        {
            List<StateDto> lstState = new List<StateDto>();
            try
            {

                var state = MasterContext.State.Where(i => i.SiteId == req.SiteId).ToList();
                lstState = Mapper.Convert<StateDto, State>(state);

            }
            catch (Exception ex)
            {

            }
            return lstState;
        }
    }
}
