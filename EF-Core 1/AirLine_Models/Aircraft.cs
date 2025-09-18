﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core_1.AirLine_Models
{
    internal class Aircraft
    {
        public int Id { get; set; }
        public int Capacity { get; set; }
        public string? Model { get; set; }
        public string Maj_Pilot { get; set; }
        public string? Assistant { get; set; }
        public string? Host1 { get; set; }
        public string? Host2 { get; set; }
        public int AL_Id { get; set; }





    }
}
