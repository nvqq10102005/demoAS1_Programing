using System.Transactions;

namespace demoAS1_Programing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("please enter price water last month:");
            double priceWaterLast = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("please enter price water this month:");
            double priceWaterThis = Convert.ToDouble(Console.ReadLine());
            while (true)
            {

                Console.Write("pls choose number corresponding type of Customer(1.HouseholdCustomer;2.Administrative agency;3.Public services;4.Production units;5.Business services):");
                int typeOfCustomer = Convert.ToInt32(Console.ReadLine());
                double Consumption = (priceWaterThis - priceWaterLast);
                Console.WriteLine("Consumption:" + Consumption.ToString());
                double Evirromentfees = 0;
                double price = 0;
                double total = 0;

                switch (typeOfCustomer)
                {
                    case 1:
                        System.Console.WriteLine("Pls enter Person:");
                        double User = Convert.ToInt32(Console.ReadLine());
                        double ConsumptionPerson = Consumption / User;
                        if (ConsumptionPerson < 10)
                        {
                            price = 5973;
                            Evirromentfees = 597.30;
                            total = (price * ConsumptionPerson + Evirromentfees) * 1.1;

                            Console.WriteLine($"Hello {name}\n TypeOfCustomer: Household customer and {price} VND/m3");
                            Console.WriteLine($"The total amount of your water and VAT:{total} VND/Users");
                        }
                        else if (10 <= ConsumptionPerson && ConsumptionPerson < 20)
                        {
                            price = 7052;
                            Evirromentfees = 705.2;
                            total = (price * ConsumptionPerson + Evirromentfees) * 1.1;
                            Console.WriteLine($"Hello {name}\n TypeOfCustomer: Household customer and {price} VND/m3");
                            Console.WriteLine($"The total amount of your water and VAT:{total}VND");
                        }
                        else if (20 <= ConsumptionPerson && ConsumptionPerson < 30)
                        {
                            price = 8699;
                            Evirromentfees = 869.9;
                            total = (price * ConsumptionPerson + Evirromentfees) * 1.1;
                            Console.WriteLine($"Hello {name}\n TypeOfCustomer: Household customer and {price} VND/m3");
                            Console.WriteLine($"The total amount of your water and VAT:{total}VND");
                        }
                        else
                        {
                            price = 15929;
                            Evirromentfees = 1592.9;
                            total = (price * ConsumptionPerson + Evirromentfees) * 1.1;
                            Console.WriteLine($"Hello {name}\n TypeOfCustomer: Household customer and {price} VND/m3");
                            Console.WriteLine($"The total amount of your water and VAT:{total}VND");
                        }
                        return;
                    case 2:
                        price = 9955;
                        Evirromentfees = 995.5;
                        total = (Consumption * price + Evirromentfees) * 1.1;
                        Console.WriteLine($"Hello {name}\n TypeOfCustomer: Administrative agency and {price} VND/m3");
                        Console.WriteLine($"The total amount of your water and VAT:{total}VND");
                        return;
                    case 3:
                        price = 9955;
                        Evirromentfees = 995.5;
                        total = (Consumption * price + Evirromentfees) * 1.1;
                        Console.WriteLine($"Hello {name}\n TypeOfCustomer: Public services and {price} VND/m3");
                        Console.WriteLine($"The total amount of your water and VAT:{total}VND");
                        return;
                    case 4:
                        price = 11615;
                        Evirromentfees = 1161.5;
                        total = (Consumption * price + Evirromentfees) * 1.1;
                        Console.WriteLine($"Hello {name}\n TypeOfCustomer: Production units and {price} VND/m3");
                        Console.WriteLine($"The total amount of your water and VAT:{total}VND");
                        return;
                    case 5:
                        price = 22068;
                        Evirromentfees = 2206.8;
                        total = (Consumption * price + Evirromentfees) * 1.1;
                        Console.WriteLine($"Hello {name}\n TypeOfCustomer: Business services and {price} VND/m3");
                        Console.WriteLine($"The total amount of your water and VAT:{total}VND");
                        return;
                    default:
                        Console.WriteLine("Error");
                        break;
                }

            }

            

            

            
            

        }
    }
}