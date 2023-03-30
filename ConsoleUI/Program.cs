using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        CarManager carManager = new CarManager(new EfCarDal());
        Car car1 = new Car();
        car1.BrandId = 1;
        car1.ColorId = 2;
        car1.CarName = "Siena";
        car1.Description = "Küçük B segment araç";
        car1.DailyPrice = 250;
        car1.ModelYear = "2020";
        carManager.Add(car1);
        Console.WriteLine("Araç Eklendi\n ----------------------");

        foreach (var car in carManager.GetAll())
        {
            Console.WriteLine(car.ModelYear + " Model :" + car.CarName);
        }
        Console.WriteLine("-----------------------------");
        

        




    }
}