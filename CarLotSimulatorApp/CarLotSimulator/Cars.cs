using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace CarLotSimulator
{
    public class Car
    {
        //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
        //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
        //The methods should take one string parameter: the respective noise propert
        public Car()
        {
        }

        public Car(int year,
                   string make,
                   string model,
                   string enginenoise,
                   string honknoise,
                   bool isDriveable)
        {
            Year = year; 
            Make = make; 
            Model = model; 
            Enginenoise = enginenoise; 
            Honknoise = honknoise; 
            IsDriveable = isDriveable;
        }
        

        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Enginenoise { get; set; }
        public string Honknoise { get; set; }
        public bool IsDriveable { get; set; }

        public void MakeEngineNoise()
        {
            Console.WriteLine(Enginenoise);
        }

        public void MakeHonkNoise(string honknoise)
        {
            Console.WriteLine(honknoise);
        }
    }
}
