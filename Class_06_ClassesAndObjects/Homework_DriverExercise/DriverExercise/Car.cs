using System;
using System.Collections.Generic;
using System.Text;

namespace DriverExercise
{
    class Car
    {
        //Make a class Car. Add properties: Model, Speed and Driver
        //* Make a method of the Car class called : CalculateSpeed() that takes a driver object
        //and calculates the skill multiplied by the speed of the car and return it as a result.
        public string Model { get; set; }
        public int Speed { get; set; }
        public Driver Driver { get; set; }
        public Car()
        {

        }
        public Car(string model, int speed)
        {
            Model = model;
            Speed = speed;
        }
        public int CalculateSpeed()
        {
            return Driver.Skill * Speed;
        }


    }
}
