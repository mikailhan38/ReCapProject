using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;

internal class Program
{
    private static void Main(string[] args)
    {
        //NewCarAddedTest();

        //CarManagerTest(carManager);
        //UserCustomerAddedTest();

    }

    private static void UserCustomerAddedTest()
    {
        UserManager userManager = new UserManager(new EfUserDal());
        CustomerManager customerManager = new CustomerManager(new EfCustomerDal());
        User user1 = new User();
        user1.FirstName = "Mikail";
        user1.LastName = "Lale";
        user1.Email = "mikail.lale@outlook.com";
        user1.Password = "password";
        userManager.Add(user1);
        Customer customer1 = new Customer();
        customer1.UserId = 1;
        customer1.CompanyName = "Test";
        customerManager.Add(customer1);
    }

    private static void NewCarAddedTest()
    {
        CarManager carManager = new CarManager(new EfCarDal());
        BrandManager brandManager = new BrandManager(new EfBrandDal());
        Brand brand1 = new Brand();
        brand1.BrandName = "Fiat";
        brandManager.Add(brand1);
        Console.WriteLine("---- Marka Eklendi ----");
        Car car1 = new Car();
        car1.BrandId = 1;
        car1.ColorId = 2;
        car1.CarName = "Siena";
        car1.Description = "Küçük B segment araç";
        car1.DailyPrice = 250;
        car1.ModelYear = "2020";
        carManager.Add(car1);
        Console.WriteLine("Araç Eklendi\n ----------------------");
    }

    private static void CarManagerTest(CarManager carManager)
    {
        foreach (var car in carManager.GetCarDetails().Data)
        {
            Console.WriteLine(car.CarName + "/ Marka :" + car.BrandName + "/ Renk :" + car.ColorName + "/ Günlük Fiyatı :" + car.DailyPrice);
        }
        Console.WriteLine("-----------------------------");
    }
}