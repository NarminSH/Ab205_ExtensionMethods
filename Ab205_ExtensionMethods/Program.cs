using Ab205_ExtensionMethods.Models;

namespace Ab205_ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            Gallery nissanGallery = new Gallery();
            Car car1 = new Car() { Brand = "Merc" };
            Car car2 = new Car() { Brand = "Bmw" };
            Car car3 = new Car() { Brand = "Kia" };
            
            nissanGallery.AddCars(car1, car2, car3);

            Car car4 = new Car() { Brand = "Nissan" };
            

            //foreach (Car car in galleryCars)
            //{
            //    Console.WriteLine(car);
            //}


            nissanGallery[1] = car4;
            Console.WriteLine(nissanGallery[1]);
            nissanGallery.Print();
             






        }
    }
}
