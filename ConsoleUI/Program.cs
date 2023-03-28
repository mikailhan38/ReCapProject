using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new InMemoryCarDal());
        Car car1 = new Car();
        car1.Id = 5;
        car1.BrandId = 1;
        car1.ColorId = 2;
        car1.Description = "Büyük Dolmuş";
        car1.DailyPrice = 250;
        car1.ModelYear = "2020";
        carManager.Add(car1);
        Console.WriteLine("Araç Eklendi\n ----------------------");

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.ModelYear + " Model " + car.Description);
        }
        Console.WriteLine("-----------------------------");
        carManager.Delete(car1 as Car);
        Console.WriteLine("Araç Silindi\n--------------");

        foreach (var car in carManager.GetByID(2))
        {
            Console.WriteLine(car.Id+":Id Numaralı Araç"+car.Description);

        }

        Console.WriteLine("-------------------------------");
        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.ModelYear + " Model " + car.Description);
        }




    }
}