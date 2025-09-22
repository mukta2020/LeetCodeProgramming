using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblem
{
    public class SolidPrinciple
    {
     
        /* Single Responsibility Principle (SRP)
         ●	Definition: A class should have only one reason to change, meaning it should have only one responsibility.
         */

        //SRP Violation Example
        public class InvoiceSRP
        {
            public void GenerateInvoice()
            {
                // Code for generating invoice
            }

            public void SaveToDatabase()
            {
                // Code for saving invoice to the database
            }

            public void SendEmailNotification()
            {
                // Code for sending an email notification about the invoice
            }
        }

        /*
         ●	Violation: The Invoice class handles three responsibilities: generating the invoice, saving it to the database, 
        and sending notifications. Each of these could change for different reasons, violating SRP.
         */


        //Refactored to follow SRP:
        public class Invoice
        {
            public void GenerateInvoice()
            {
                // Code for generating invoice
            }
        }

        public class InvoiceRepository
        {
            public void SaveToDatabase(Invoice invoice)
            {
                // Code for saving invoice to the database
            }
        }

        public class NotificationService
        {
            public void SendEmailNotification(Invoice invoice)
            {
                // Code for sending an email notification about the invoice
            }
        }

    }

    #region OCP
    /*
     Open/Closed Principle (OCP)
●	Definition: Software entities (classes, modules, functions) should be open for extension but closed for
    modification

     */
    public class PaymentProcessor
    {
        public void ProcessPayment(string paymentType)
        {
            if (paymentType == "CreditCard")
            {
                // Process credit card payment
            }
            else if (paymentType == "PayPal")
            {
                // Process PayPal payment
            }
        }
    }
    /*
     ●	Violation: If a new payment type (e.g., Bitcoin) needs to be added,
    the ProcessPayment method has to be modified, violating OCP
     */


    public interface IPayment
    {
        void Process();
    }
    public class PayPalPayment : IPayment
    {
        public void Process()
        {
            // Process PayPal payment
        }
    }
    public class CreditCardPayment : IPayment
    {
        public void Process()
        {
            // Process credit card payment
        }
    }
    public class PaymentProcessor2
    {
        public void ProcessPayment(IPayment payment)
        {
            payment.Process();
        }
    }
    /*
     ●	Fix: The PaymentProcessor class is now open for extension by introducing 
    new IPayment implementations but closed for modification since the ProcessPayment method does not need to change
     */


    #endregion

    #region Liskov Substitution Principle (LSP)
    /*●	Definition: Object of a child class must be able to replace an object of the parent class 
     * without breaking the application.*/

    public class Bird
    {
        public virtual void Fly()
        {
            // Fly logic
        }
    }
    public class Penguin : Bird
    {
        public override void Fly()
        {
            throw new NotImplementedException();
        }
    }
    /*
     ●	Violation: Penguin inherits from Bird, but it violates LSP because a penguin cannot fly. 
    Calling Fly() on a Penguin will cause an exception.
     */


    public abstract class Bird1
    {
        // Shared bird behavior
    }

    public interface IFlyable
    {
        void Fly();
    }

    public class Sparrow : Bird1, IFlyable
    {
        public void Fly()
        {
            // Fly logic
        }
    }

    public class Penguin1 : Bird1
    {
        // No fly logic for Penguin
    }

    /*●	Fix: Bird now represents common bird behavior, and IFlyable represents flying behavior. 
     * Penguins do not implement IFlyable, adhering to LSP.*/



    #endregion

    #region Interface Segregation Principle (ISP)
    //●	Definition: Class should not be forced to implement interfaces they do not use.
    public interface IWorker
    {
        void Work();
        void Manage();
    }

    public class Developer : IWorker
    {
        public void Work()
        {
            // Developer work logic
        }

        public void Manage()
        {
            throw new NotImplementedException();
        }
    }
    //●	Violation: Developer class is forced to implement Manage(), which it does not need, violating ISP.

    

    public interface IWorker1
    {
        void Work();
    }

    public interface IManager
    {
        void Manage();
    }

    public class Developer1 : IWorker1
    {
        public void Work()
        {
            // Developer work logic
        }
    }


    public class Manager : IWorker, IManager
    {
        public void Work()
        {
            // Manager work logic
        }

        public void Manage()
        {
            // Manager manage logic
        }
    }

    //●	Fix: The interfaces are now segregated, and classes only implement the methods they need.




    #endregion

    #region Dependency Inversion Principle (DIP)
    //●	Definition: High-level modules should not depend on low-level modules. Both should depend on abstractions.
    public class LightBulb
    {
        public void TurnOn()
        {
            // Light bulb on logic
        }
        public void TurnOff()
        {
            // Light bulb off logic
        }
    }

    public class Switch
    {
        private LightBulb lightBulb = new LightBulb();
        public void Toggle()
        {
            // Directly depends on LightBulb
            lightBulb.TurnOn();
        }
    }
    //●	Violation: Switch is tightly coupled with the LightBulb class.
    //If you wanted to change the type of light, you would need to modify Switch, violating DIP.

    public interface IDevice
    {
        void TurnOn();
        void TurnOff();
    }
    public class LightBulb1 : IDevice
    {
        public void TurnOn()
        {
            // Light bulb on logic
        }

        public void TurnOff()
        {
            // Light bulb off logic
        }
    }
    public class Switch1
    {
        private IDevice device;
        public Switch1(IDevice device)
        {
            this.device = device;
        }

        public void Toggle()
        {
            device.TurnOn();
        }
    }

    //●	Fix: Switch now depends on the IDevice interface,
    //allowing it to work with any device that implements IDevice, adhering to DIP.

    #endregion
}
