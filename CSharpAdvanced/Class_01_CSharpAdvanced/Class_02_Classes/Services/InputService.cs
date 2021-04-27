using System;
using System.Collections.Generic;
using System.Text;

namespace Class_02_Classes.Services
{
    public class InputService
    {
        public int GetIntegerInput(int min, int max)
        {
            while (true)
            {
                string input = Console.ReadLine();
                try
                {
                    int parsedValue = int.Parse(input);
                    if(parsedValue >= min && parsedValue <= max)
                    {
                        return parsedValue;
                    }
                    throw new Exception();
                }
                catch (ArgumentNullException)
                {

                }
                catch (FormatException)
                {

                }
                catch (OverflowException)
                {

                }
                catch (Exception)
                {

                }
            }
            

        }
    }
}
