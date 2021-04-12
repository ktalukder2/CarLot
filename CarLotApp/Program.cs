using System;
using System.Collections.Generic;

namespace CarLotApp
{

    public class Car
    {
        public string  pMake;
        public string  pModel;
        public int     pYear;
        public decimal pPrice;

        public Car()
        {

        }

        public virtual string NewCargetData()
        {
            return ($"Make: { this.pMake}, Model: {this.pModel}, Year: {this.pYear}, Price: ${this.pPrice}");
        }

        public virtual string UsedCargetData()
        {
            Console.WriteLine($"Make: { this.pMake}, Model: {this.pModel}, Year: {this.pYear}, Price: ${this.pPrice}, Used, ");
            return "";
            //($"Make: { this.pMake}, Model: {this.pModel}, Year: {this.pYear}, Price: ${this.pPrice}, Used, Mileage: {pMileage}");
        }

        public static void AddingCars()
        {
            for (int i = 0; i < 2; i++)
            {
                //Console.WriteLine("Welcome to Grant Chirpus' Used Car Emporium");
                List<CarLot> cars = new List<CarLot>();
                List<CarLot> usedCars = new List<CarLot>();
                Console.WriteLine("Enter Make");
                string userInputMake;
                userInputMake = Console.ReadLine();
                Console.WriteLine("Enter Model");
                string userInputModel;
                userInputModel = Console.ReadLine();
                Console.WriteLine("Enter Year");
                int userInputYear;
                userInputYear = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Price");
                decimal userInputPrice;
                userInputPrice = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter Mileage");
                int userInputMileage;
                userInputMileage = Int32.Parse(Console.ReadLine());


                //cars.Add(new CarLot());
                //cars[i].pMake = userInputMake;
                //cars[i].pModel = userInputModel;
                //cars[i].pYear = userInputYear;
                //cars[i].pPrice = userInputPrice;
            }
        }


        public Car(string make, string model, int year, decimal price)
        {
            pMake = make;
            pModel = model;
            pYear = year;
            pPrice = price;
        }

        public override string ToString()
        {
          
            return ($"Make: {pMake} Model: {pModel} Year: {pYear} Price: {pPrice}");
        }
    }

    public class UsedCar : Car
    {
        public double pMileage;

        public UsedCar()
        {

        }

        public UsedCar(string make, string model, int year, decimal price) : base(make, model, year, price)
        {

        }

        public UsedCar(string make, string model, int year, decimal price, double mileage):base(make,model,year,price)
        {
            
            pMileage = mileage;
        }

        public override string UsedCargetData()
        {
            Console.WriteLine($"Make: { this.pMake}, Model: {this.pModel}, Year: {this.pYear}, Price: ${this.pPrice}, Used, Mileage: {pMileage}");
            return "";
            //($"Make: { this.pMake}, Model: {this.pModel}, Year: {this.pYear}, Price: ${this.pPrice}, Used, Mileage: {pMileage}");
        }

        public override string ToString()
        {

            return ($"Make: {pMake} Model: {pModel} Year: {pYear} Price: {pPrice} Used and  Mileage: {pMileage}");
        }

    }

    public class CarLot
    {
        List<UsedCar> carList = new List<UsedCar>();
        //List<Car> newCarList = new List<Car>();
        public void defaultcarlist()
        {
            carList.Add(new UsedCar("Porche", "Cayenne", 2020, 99000));
            carList.Add(new UsedCar("Porche", "Hayenne", 2020, 89000));
            carList.Add(new UsedCar("Porche", "Jayenne", 2020, 1099000));

            carList.Add(new UsedCar("Toyota", "Camry", 2020, 9990,2600));
            carList.Add(new UsedCar("Toyota", "Corolla", 2020, 9990, 2600));
            carList.Add(new UsedCar("Toyota", "4Runner", 2020, 9990, 2600));
            
          

        }

        public void AddCar(int type)
        {
            if (type==1)
            {
                UsedCar usedCar = new UsedCar();
                Console.WriteLine("Enter Make");
              
                usedCar.pMake = Console.ReadLine();
                Console.WriteLine("Enter Model");
              
                usedCar.pModel = Console.ReadLine();
                Console.WriteLine("Enter Year");
                
                 usedCar.pYear = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Price");
                
                usedCar.pPrice =  decimal.Parse(Console.ReadLine());
                carList.Add(usedCar);

            }
            else if (type == 2)
            {
                UsedCar usedCar = new UsedCar();
                Console.WriteLine("Enter Make");

                usedCar.pMake = Console.ReadLine();
                Console.WriteLine("Enter Model");

                usedCar.pModel = Console.ReadLine();
                Console.WriteLine("Enter Year");

                usedCar.pYear = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Price");

                usedCar.pPrice = decimal.Parse(Console.ReadLine());
                carList.Add(usedCar);
                Console.WriteLine("Enter Mileage");
              
                usedCar.pMileage = Int32.Parse(Console.ReadLine());
                carList.Add(usedCar);

            }
            else
            {
                Console.WriteLine("Invalid choice");
            }

            
        }

        public void PrintCarInventory()
        {

            foreach (var item in carList)
            {
                if (item.pMileage>0)
                {
                    UsedCar usedcar = new UsedCar(item.pMake, item.pModel, item.pYear, item.pPrice, item.pMileage);
                    Console.WriteLine(usedcar);
                }
                else
                {
                    

                    Car car = new Car(item.pMake, item.pModel, item.pYear, item.pPrice);
                    Console.WriteLine(car);
                }

                
                
            }

        }

    } 



    class Program: Car
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Grant Chirpus' Used Car Emporium");
            CarLot carLot = new CarLot();
            carLot.defaultcarlist();
            carLot.PrintCarInventory();

            bool yn = false;

            while (yn!=true)
            {
                Console.WriteLine("To add a new car press 1 or press 2 for used car ");
                int userAddCarInput = Int32.Parse(Console.ReadLine());
                carLot.AddCar(userAddCarInput);
                Console.WriteLine("Would you like to add another car? (y/n)");
                string anotheradd = Console.ReadLine();

                if (anotheradd!="y")
                {
                    yn = true;
                }


            }
           
           










            // Console.WriteLine("Add");



        }
    }
}
