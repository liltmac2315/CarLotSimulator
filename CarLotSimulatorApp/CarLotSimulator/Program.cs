using System;
using System.IO.Enumeration;
using Microsoft.VisualBasic;


namespace CarLotSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            
            var lot = new CarLot();
            
            
            //Done-Create a seperate class file called Car
            //Done-Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
            //Done-Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
            //Done-The methods should take one string parameter: the respective noise property


            //Now that the Car class is created we can instanciate 3 new cars
            //Set the properties for each of the cars
            //Call each of the methods for each car
            //Instantiation 1/ Dot notation
            var tommysCar = new Car();

            tommysCar.Make = "Ford";
            tommysCar.Model = "Focus";
            tommysCar.Year = 2017;
            tommysCar.Enginenoise = "vroom";
            tommysCar.Honknoise = "beep";
            tommysCar.IsDriveable = true;

            lot.Cars.Add(tommysCar);

            //instantiation 2/ Object Initializer Syntax
            var anibalsCar = new Car()
            {
                Year = 2019,
                Make = "Tesla",
                Model = "Cyber Truck",
                Enginenoise = "...",
                Honknoise = "brmmp",
                IsDriveable = false

            };

            lot.Cars.Add(anibalsCar);
            //instantiation 3/ constructor to allow parameter values to be placed inside properties
            var teresasCar = new Car(2013, "Honda","Civic","Vroom","Vruuuga", true);

            lot.Cars.Add(teresasCar);

            //Call methods
            tommysCar.MakeEngineNoise();
            anibalsCar.MakeEngineNoise();
            teresasCar.MakeEngineNoise();





            //*************BONUS*************//

            //Done- Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Done-Create a CarLot class
            //Done-It should have at least one property: a List of cars
            //Done-Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console

            foreach(var car in lot.Cars)    
            {
                Console.WriteLine($"Year: {car.Year}) Make: {car.Make} Model {car.Model}");
            }
        }
    }
}
