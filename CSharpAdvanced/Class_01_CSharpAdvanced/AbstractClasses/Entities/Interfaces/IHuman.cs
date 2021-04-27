using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.Entities.Interfaces
{
    public interface IHuman
    {
        string GetInfo();
        void Greet(string name);
    }
}
