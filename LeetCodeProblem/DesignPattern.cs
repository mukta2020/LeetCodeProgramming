using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class DesignPattern
    {
        /*
         1. Creational
         2. Behavioral
         3. Structural
         */


        Car car = new CarBuilder().SetEngine("V8").SetWheels(4).Build();
        


    }

    #region 1.1	Singleton Pattern 
    public sealed class Singleton
    {
        private static Singleton _instance = null;
        private Singleton() { }

        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }


    #endregion


    #region Builder Pattern 
    public class Car
    {
        public string Engine { get; set; }
        public int Wheels { get; set; }

        public void ShowCar()
        { // console.wriline
        }
    }

    public class CarBuilder
    {
        private Car _car = new Car();
        public CarBuilder SetEngine(string engine)
        {
            _car.Engine = engine;
            return this;
        }
        public CarBuilder SetWheels(int wheels)
        {
            _car.Wheels = wheels;
            return this;
        }
        public Car Build()
        {
            return _car;
        }
    }

    #endregion

    #region Factory Method Pattern 
    public abstract class Vehicle
    {
        public abstract void Drive();
    }

    public class Car1 : Vehicle
    {
        public override void Drive() => Console.WriteLine("Car is driving");
    }

    public class Bike : Vehicle
    {
        public override void Drive() => Console.WriteLine("Bike is driving");
    }

    // Factory Class
    public class VehicleFactory
    {
        public static Vehicle CreateVehicle(string type)
        {
            return type switch
            {
                "Car" => new Car1(),
                "Bike" => new Bike(),
                _ => throw new ArgumentException("Invalid Type")
            };
        }
    }

    #endregion


}
