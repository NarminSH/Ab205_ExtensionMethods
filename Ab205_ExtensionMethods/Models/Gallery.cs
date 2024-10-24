using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab205_ExtensionMethods.Models
{
    internal class Gallery
    {
        Car[] cars;
        public Gallery()
        {
            cars = new Car[0]; 
        }

        public void AddCar(Car car)
        {
            Array.Resize(ref cars, cars.Length+1);
            cars[^1] = car;
            Console.WriteLine("New car added successfully!");
        }

        public Car[] AddCars(params Car[] inputCars)//length =3
        {
            Array.Resize(ref cars, cars.Length+ inputCars.Length); //13
            for (int i = 0; i < inputCars.Length; i++)
            {
                cars[cars.Length-inputCars.Length+i] = inputCars[i]; //13 -3 + 1 == 11
            }
            return cars;

        }
        public Car this[int index] 
        { 
            get 
            { 
                if ( index < cars.Length)
                {
                    return cars[index];
                }
                return cars[0];
            }
            set
            {
                if (index < cars.Length)
                {
                    cars[index] = value;
                }
                else
                {
                    Console.WriteLine("Index not found");
                }

            }
        }

        public void Print()
        {
            foreach (Car item in cars)
            {
                Console.WriteLine(item);
            }
        }


    }
}
