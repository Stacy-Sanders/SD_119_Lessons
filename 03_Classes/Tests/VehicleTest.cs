using _03_Classes.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace _03_Classes.Tests
{
    [TestClass]
    public class VehicleTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            Vehicle firstVehicle = new Vehicle();
            firstVehicle.Make = "Mazda";
            firstVehicle.Model = "CX-5";
            firstVehicle.Mileage = 37000;
            firstVehicle.Type = VehicleType.SUV;

            Console.WriteLine($"Model: {firstVehicle.Model}");

            firstVehicle.TurnOn();
            Console.WriteLine($"is it running? {firstVehicle.IsRunning}");
            firstVehicle.TurnOff();
            Console.WriteLine($"is it running? {firstVehicle.IsRunning}");

            Vehicle secondVehicle = new Vehicle();
            secondVehicle.Type = VehicleType.Spaceship;

            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.Add(firstVehicle);
            vehicles.Add(secondVehicle);


        }
    }
}
