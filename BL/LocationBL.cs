using DL;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BL
{
    public  class LocationBL: ILocationBL
    {
        ILocationDL _LocationDL;
        public LocationBL(ILocationDL locationDL)
        {
            _LocationDL = locationDL;
        }
       public async Task<List<Location>> getLocationsBYPatientaId(String PatientaId) {
         return  await  _LocationDL.getLocationsBYPatientaId(PatientaId);
        }
        public async Task<List<Location>> getLocations() {
            return await _LocationDL.getLocations();

        }

        public async Task<List<Location>> getLocationByCity(String city) {
           return  await _LocationDL.getLocationByCity(city);
        }
        public async Task<Location> postLocation(Location location) {
            return await _LocationDL.postLocation(location);
        }
    }

}
