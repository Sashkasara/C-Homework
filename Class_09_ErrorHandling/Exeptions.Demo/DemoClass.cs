using System;
using System.Collections.Generic;

namespace Exeptions.Demo
{
    public class DemoClass
    {
        public int getNumberAtCertainPosition(int position, List<int> listOfInteger)
        {
            return GetNumberAtCertainPosition(position, listOfInteger);
        }
        public int GetNumberAtCertainPosition(int position, List<int> listOfInteger)
        {
            int result = 0;
            try
            {
                return listOfInteger[position];
            }
            catch(Exeption ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
            }
            return result;
        }
    }
}
