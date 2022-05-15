using System;

namespace CarHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Garage initialTest = new InitialTest();
            Garage assemblyInspection = new Assembly();
            Garage electricalDepartment = new Electrical();
            Garage experts = new Experts();
            Car c = new Car();
            List<Car> cars = new List<Car>()
            {
                new Car(),
                new Car(),
                new Car(),
                new Car(),
                new Car()
            };

    
            initialTest.SetNext(assemblyInspection);
            assemblyInspection.SetNext(electricalDepartment);
            electricalDepartment.SetNext(experts);
            experts.SetNext(null);

            for (int i = 0; i < 5; i++)
            {
                Console.Write($"Car {i+1} ");
                initialTest.HandleRequest(cars[i]);
                
            }



        }
    }
}