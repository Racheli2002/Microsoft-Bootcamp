﻿using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.IO;
namespace DL
{
    public class LocationDL: ILocationDL
    {
        FileStream fs;

        public LocationDL()
        {
            //fs = File.Create("C:\\Users\\WIN10\\microsoft.JSON");
            //fs.Close();
            
        }
        public async Task<List<Location>> getLocationsBYPatientaId(String PatientaId) {
            List<Location> locations = JsonSerializer.Deserialize<List<Location>>(await File.ReadAllTextAsync("C:\\Users\\WIN10\\microsoft.JSON"));
            var l= locations.FindAll(loc => loc.PatientId == PatientaId);
            return l;
            
        }
        public async Task<List<Location>> getLocations() {
             return JsonSerializer.Deserialize<List<Location>>(await File.ReadAllTextAsync("C:\\Users\\WIN10\\microsoft.JSON"));

        }

        public async Task<List<Location>> getLocationByCity(String city) {
            List<Location> locations = JsonSerializer.Deserialize<List<Location>>(await File.ReadAllTextAsync("C:\\Users\\WIN10\\microsoft.JSON"));
            return locations.FindAll(loc => loc.City == city);

        }
        public async Task<Location> postLocation(Location location) {
            string file= await File.ReadAllTextAsync("C:\\Users\\WIN10\\microsoft.JSON");
            String jsonLocation;
            List<Location> locations;
            if (file != "")
            {
                locations = JsonSerializer.Deserialize<List<Location>>(file);
                locations.Add(location);
               
            }
            else
            {
                locations = new List<Location> { location };
           

            }
            jsonLocation = JsonSerializer.Serialize(locations);
 
             await File.WriteAllTextAsync("C:\\Users\\WIN10\\microsoft.JSON", jsonLocation);
            return location;
        }
    }
}
