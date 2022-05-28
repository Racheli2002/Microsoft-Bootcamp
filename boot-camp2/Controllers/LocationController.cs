﻿using Microsoft.AspNetCore.Mvc;
using Services;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace boot_camp2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {


        private readonly ILogger<LocationController> _logger;

        ILocationService _locationService;
        public LocationController(ILocationService locationService, ILogger<LocationController> logger)
        {
            _locationService = locationService;
            _logger = logger;
        }
        // GET: api/<PatientController>
        [HttpGet("all")]
        public async Task<List<Location>> Get()
        {
            try
            {
                throw new Exception("error");
            }
            catch(Exception ex)
            {
                _logger.LogInformation(ex.StackTrace);
            }
            return await _locationService.getLocations();
        }


        [HttpGet ]
        public async Task<List<Location>> GetByCity([FromQuery] string city)
        {
            
            return await _locationService.getLocationByCity(city);
        }
        // GET api/<PatientController>/5
        [HttpGet("{patientid}")]
        public async Task<List<Location>> Get(string patientid)
        {
            return await _locationService.getLocationsBYPatientaId(patientid);
        }

        // POST api/<PatientController>
        [HttpPost]
        public async Task<Location> Post([FromBody] Location location)
        {
            return await _locationService.postLocation(location);
        }


    }
}