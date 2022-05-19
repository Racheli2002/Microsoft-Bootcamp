﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Patient
    {
        public String Id { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }

        public List<Location> Locations { get; set; }

    }
}
