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

      
🔹 Singleton

Q: You are designing a logging system where only one instance of Logger should exist across the application to avoid multiple log files. How would you implement it?

🔹 Prototype

Q: A company designs standard floor plans for apartments. Instead of building each apartment from scratch, you want to clone a standard apartment design and customize it. How would you implement this?

🔹 Builder

Q: You need to construct a complex report object (with header, body, charts, footer). Sometimes the report needs only header + body, sometimes full structure. How would you design it to allow step-by-step construction?

🔹 Adapter

Q: You are integrating a new payment gateway API that returns results in XML, but your application only supports JSON. How will you design a solution that makes the new API work seamlessly without changing the client code?

🔹 Decorator

Q: You are building a coffee shop system. A coffee can have different add-ons like Milk, Sugar, Caramel, etc. You don’t want a huge inheritance tree (MilkCoffee, SugarCoffee, CaramelCoffee). How would you implement it?

🔹 Observer

Q: In a stock trading app, when a stock price changes, multiple services need to be notified (UI update, send email alerts, push notifications). How will you design this notification system?

🔹 Strategy

Q: In a payment system, users can pay using Credit Card, PayPal, UPI. Instead of hardcoding logic, how will you design it so that you can easily switch between payment strategies?

🔹 Composite

Q: You are building a folder/file explorer. A folder can contain files or other folders. Both should be treated uniformly (like calling GetSize() should work on both). How would you implement this?

🔹 Command

Q: You are designing a text editor with Undo/Redo functionality. Each action (typing, deleting, formatting) should be treated as a command that can be undone or redone. How would you model it?

🔹 Proxy

Q: You are building a video streaming service where videos are large. To avoid unnecessary loading, you want a virtual proxy that loads video only when it is actually played. How would you design this?
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

    #region factory example 1
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

    #region factory example 2
    /*
     Let suppose there are Identical 2- towers and in each tower 3-floors, 
    on each floor we have 2 parking types (car ParkingUnit, byke ParkingUnit) 
     */

    //step 1 : interfaces for Parking Units
    public interface IParkingUnit
    {
        string Type { get; }
    }

    public class CarParkingUnit : IParkingUnit
    {
        public string Type => "Car Parking";
    }

    public class BikeParkingUnit : IParkingUnit
    {
        public string Type => "Bike Parking";
    }

    // Step 2: Floor Class
    public class Floor
    {
        public int FloorNumber { get; }
        public List<IParkingUnit> ParkingUnits { get; }

        public Floor(int floorNumber, List<IParkingUnit> parkingUnits)
        {
            FloorNumber = floorNumber;
            ParkingUnits = parkingUnits;
        }
    }

    // Step 3: Tower Class
    public class Tower
    {
        public string TowerName { get; }
        public List<Floor> Floors { get; }

        public Tower(string towerName, List<Floor> floors)
        {
            TowerName = towerName;
            Floors = floors;
        }
    }

    // Step 4: Factory Class (Design Pattern)
    public static class TowerFactory
    {
        public static Tower CreateTower(string towerName, int totalFloors)
        {
            var floors = new List<Floor>();

            for (int i = 1; i <= totalFloors; i++)
            {
                // Each floor has identical parking units
                var parkingUnits = new List<IParkingUnit>
            {
                new CarParkingUnit(),
                new BikeParkingUnit()
            };

                floors.Add(new Floor(i, parkingUnits));
            }

            return new Tower(towerName, floors);
        }
    }


    #endregion

    #endregion

    #region Stategey Pattern using payment
    // Strategy Interface
    public interface IPaymentStrategy
    {
        void Pay(decimal amount);
    }

    // Concrete Strategies
    public class CreditCardPayment1 : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using Credit Card.");
        }
    }

    public class PayPalPayment1 : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using PayPal.");
        }
    }

    public class UpiPayment : IPaymentStrategy
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"Paid {amount:C} using UPI.");
        }
    }

    // Context
    public class PaymentContext
    {
        private readonly IPaymentStrategy _paymentStrategy;

        public PaymentContext(IPaymentStrategy strategy)
        {
            _paymentStrategy = strategy;
        }

        public void ExecutePayment(decimal amount)
        {
            _paymentStrategy.Pay(amount);
        }
    }

    // Usage
    class Program
    {
        static void Main()
        {
            var payment1 = new PaymentContext(new CreditCardPayment1());
            payment1.ExecutePayment(100);

            var payment2 = new PaymentContext(new PayPalPayment1());
            payment2.ExecutePayment(250);
        }
    }

    #endregion

    #region Observer Pattern
    // Observer Interface
    public interface IObserver
    {
        void Update(decimal stockPrice);
    }

    // Subject
    public class Stock
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        private decimal _price;

        public void Attach(IObserver observer) => _observers.Add(observer);
        public void Detach(IObserver observer) => _observers.Remove(observer);

        public void SetPrice(decimal price)
        {
            _price = price;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_price);
            }
        }
    }

    // Concrete Observers
    public class MobileApp : IObserver
    {
        public void Update(decimal stockPrice)
        {
            Console.WriteLine($"[MobileApp] Stock updated to {stockPrice}");
        }
    }

    public class WebApp : IObserver
    {
        public void Update(decimal stockPrice)
        {
            Console.WriteLine($"[WebApp] Stock updated to {stockPrice}");
        }
    }

    // Usage
    class Program1
    {
        static void Main()
        {
            var stock = new Stock();

            var mobileApp = new MobileApp();
            var webApp = new WebApp();

            stock.Attach(mobileApp);
            stock.Attach(webApp);

            stock.SetPrice(120.50m);
            stock.SetPrice(130.75m);
        }
    }

    #endregion
}
