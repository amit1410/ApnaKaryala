using ApnaKaryala.DTO.Master;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApnaKaryala.Data.Repositories
{
    public interface IMasterRepository
    {
        List<StateDto> GetAllState(StateDto req);
        List<CityDto> GetAllCityByStateid(CityDto req);
        List<GenderDto> GetAllGender(GenderDto req);
    }
}
