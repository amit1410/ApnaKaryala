using ApnaKaryala.Data.Infrastructure;
using ApnaKaryala.Data.Repositories;
using ApnaKaryala.DTO.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Service
{
    public class MasterDataService : IMasterDataService
    {
        private readonly IMasterRepository _masterRepository;
        private readonly IUnitOfWork unitOfWork;

        public MasterDataService(IMasterRepository masterRepository, IUnitOfWork unitOfWork)
        {
            this._masterRepository = masterRepository;
            this.unitOfWork = unitOfWork;
        }
        public List<CityDto> GetAllCityByStateid(CityDto ct)
        {
            ct.SiteId = 1;
            var result = _masterRepository.GetAllCityByStateid(ct);
            return result;
        }

        public List<GenderDto> GetAllGender()
        {
            GenderDto req = new GenderDto();
            req.SiteId = 1;
            var result = _masterRepository.GetAllGender(req);
            return result;
        }

        public List<StateDto> GetAllState()
        {
            StateDto req = new StateDto();
            req.SiteId = 1;
            var result = _masterRepository.GetAllState(req);
            return result;
        }

        public List<HoliDayListDto> GetAllHoliDay()
        {
            HoliDayListDto req = new HoliDayListDto();
            req.SiteId = 1;
            var result = _masterRepository.GetAllHoliDay(req);
            return result;
        }
    }
}
