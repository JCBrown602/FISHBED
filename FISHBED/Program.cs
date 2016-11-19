/*
 * 17 November, 2016
 * Jason Brown
 * 
 * Just working through some stuff found on: 
 * http://www.c-sharpcorner.com/article/tips-for-writing-clean-and-best-code-in-c-sharp/
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FISHBED
{
    class Program
    {
        static void Main(string[] args)
        {
            FISH tuna = new FISH();
            Console.WriteLine(tuna.GetResult(10));
            Console.WriteLine(tuna.GetResult(1));
            Console.WriteLine();

            Console.WriteLine(tuna.GetSimple(10));
            Console.WriteLine(tuna.GetSimple(1));
            Console.WriteLine();

            Console.WriteLine(tuna.UseTernary(10));
            Console.WriteLine(tuna.UseTernary(1));
            Console.WriteLine();


            // Facade pattern demo

            var facade = new CarFacade();

            facade.CreateCompleteCar();

            Console.ReadKey();

        }
    }

    public class FISH
    {
        public bool GetResult(int stuff)
        {
            if (stuff == 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool GetSimple(int value)
        {
            return (value == 10);
        }

        public string UseTernary(int value)
        {
            return value == 10 ? "> Value equals 10" : "> Value does NOT equal 10";
        }
    }


    // The 'Subsystem ClassA' class
    class CarModel
    {
        public void SetModel()
        {
            Console.WriteLine(" CarModel - SetModel");
        }
    }

    /// <summary>
    /// The 'Subsystem ClassB' class
    /// </summary>
    class CarEngine
    {
        public void SetEngine()
        {
            Console.WriteLine(" CarEngine - SetEngine");
        }
    }

    // The 'Subsystem ClassC' class
    class CarBody
    {
        public void SetBody()
        {
            Console.WriteLine(" CarBody - SetBody");
        }
    }

    // The 'Subsystem ClassD' class
    class CarAccessories
    {
        public void SetAccessories()
        {
            Console.WriteLine(" CarAccessories - SetAccessories");
        }
    }

    // The 'Facade' class
    public class CarFacade
    {
        private readonly CarModel model;
        private readonly CarEngine engine;
        private readonly CarBody body;
        private readonly CarAccessories accessories;

        public CarFacade()
        {
            model = new CarModel();
            engine = new CarEngine();
            body = new CarBody();
            accessories = new CarAccessories();
        }

        public void CreateCompleteCar()
        {
            Console.WriteLine("******** Creating a Car **********");
            model.SetModel();
            engine.SetEngine();
            body.SetBody();
            accessories.SetAccessories();

            Console.WriteLine("******** Car creation is completed. **********");
        }
    }

    
}
