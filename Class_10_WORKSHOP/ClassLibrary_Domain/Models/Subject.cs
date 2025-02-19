﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Domain.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public int NumberOfClasses { get; set; }
        public bool IsOptional { get; set; }
        public DateTime StartsOn { get; set; }
        public DateTime EndsOn { get; set; }
    }
}
