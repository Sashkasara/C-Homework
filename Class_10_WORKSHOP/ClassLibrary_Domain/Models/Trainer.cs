using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary_Domain.Models
{
    public class Trainer : User
    {
        public List<subject> Subjects { get; set; }
    }
}
