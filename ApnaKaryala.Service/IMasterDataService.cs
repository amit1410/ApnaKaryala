using ApnaKaryala.DTO.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Service
{
    public interface IMasterDataService
    {
        List<StateDto> GetAllState();
        List<CityDto> GetAllCityByStateid(CityDto ct);
        List<GenderDto> GetAllGender();
    }
}
