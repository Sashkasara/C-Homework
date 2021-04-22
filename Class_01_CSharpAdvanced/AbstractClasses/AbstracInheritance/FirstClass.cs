using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractClasses.AbstracInheritance
{
    public abstract class FirstClass : BaseClass
    {
        public DateTime StartedOn { get; set; }

        public abstract void DoSomeAdvancedWork();
    }
}
