using System;

namespace Practical_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int pin = 1234;
            int account, pin1, c;
            double amount;
            Bank b = new Bank();
            Console.WriteLine("\t\t\t\t\t\t----- Chimanlal Co.op Bank -----");
            Console.WriteLine("Enter Your Name:");
            string name= Console.ReadLine();
            Console.WriteLine("Enter your Account Number:");
            account = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Pin:");
            pin1 = Convert.ToInt32(Console.ReadLine());
            if (pin1 == pin)
            {
                Console.WriteLine("Welcome " + name);
                Console.WriteLine("Account Number:" + account);
                Console.WriteLine("1.To Deposit");
                Console.WriteLine("2.To Withdrawn");
                Console.WriteLine("3.To Balace Inqiry");
                Console.WriteLine("4.To Account Details");
                Console.WriteLine("5.To Exit");
                while (true)
                {
                    Console.WriteLine("Enter Your Choice:");
                    c = Convert.ToInt32(Console.ReadLine());
                    switch (c)
                    {
                        case 1:
                            Console.WriteLine("Enter Amount to be Deposited:");
                            amount = Convert.ToDouble(Console.ReadLine());
                            b.Credit(amount);
                            break;
                        case 2:
                            Console.WriteLine("Enter Amount to be Withdrawn:");
                            amount = Convert.ToDouble(Console.ReadLine());
                            b.Debit(amount);
                            break;
                        case 3:
                            b.Balance_check(name, account);
                            break;
                        case 4:
                           b.Get_info(name, account);
                            break;
                        case 5:
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Wrong Pin");
            }
        }
        
    }
}
