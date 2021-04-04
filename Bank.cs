using System;
using System.Collections.Generic;
using System.Text;

namespace Practical_4
{
    public class Bank
    {
        double bal = 0, amt;
        int acc,credit_count=0,debit_count=0,balance_count=0,fail_count=0;
        int tt,st;
        String n;
        public void Credit(double amount)
        {
            amt = amount;
            if (amt <= 0)
            {
                Console.WriteLine("Sorry,Amount can't be deposited");
                fail_count++;
            }
            else
            {
                bal = bal + amt;
                Console.WriteLine("---------------Chimanlal Bank---------------");
                Console.WriteLine("Amount Deposited");
                Console.WriteLine("Total Available Balance: " + bal + "Rs");
                Console.WriteLine("Thank You for Using our Banking Application");
                Console.WriteLine("--------------------------------------------");
                DateTime date = DateTime.Now;
                Console.WriteLine("Digital Copy Generated on:" + date);
                Console.WriteLine("Branch: Gandhinagar");
                Console.WriteLine("--------------------------------------------");
                credit_count++;
            }
        }
        public void Debit(double amount)
        {
            amt = amount;
            if (amt <= 0 || amt > bal)
            {
                Console.WriteLine("Sorry,Amount can't be withdraw");
                fail_count++;
            }
            else
            {
                bal = bal - amt;
                Console.WriteLine("---------------Chimanlal Bank---------------");
                Console.WriteLine("Take Your Bucks: " + amt + "Rs");
                Console.WriteLine("Total Available Balance: " + bal + "Rs");
                Console.WriteLine("Thank You for Using our Banking Application");
                Console.WriteLine("--------------------------------------------");
                DateTime date = DateTime.Now;
                Console.WriteLine("Digital Copy Generated on:" + date);
                Console.WriteLine("Branch: Gandhinagar");
                Console.WriteLine("--------------------------------------------");
                debit_count++;
            }
        }
        public void Balance_check(String name, int account)
        {
            n = name;
            acc = account;
            Console.WriteLine("---------------Chimanlal Bank---------------");
            Console.WriteLine("Name: " + n);
            Console.WriteLine("Account Number: " + acc);
            Console.WriteLine("Your Available Balance: " + bal + "Rs");
            Console.WriteLine("Thank You for Using our Banking Application");
            Console.WriteLine("--------------------------------------------");
            DateTime date = DateTime.Now;
            Console.WriteLine("Digital Copy Generated on:" + date);
            Console.WriteLine("Branch: Gandhinagar");
            Console.WriteLine("--------------------------------------------");
            balance_count++;
        }

        public void Get_info(String name, int account)
        {
            n = name;
            acc = account;
            tt = fail_count + debit_count + credit_count + balance_count;
            st = debit_count + credit_count + balance_count;
            Console.WriteLine("---------------Chimanlal Bank---------------");
            Console.WriteLine("Name: " + n);
            Console.WriteLine("Account Number: " + acc);
            Console.WriteLine("Your Available Balance: " + bal + "Rs");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Transaction Summary:");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("NUM |      PROCESS    |  COUNT |");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("<1> |      CREDIT     |  "+credit_count+"     |");
            Console.WriteLine("<2> |      DEBIT      |  "+  debit_count+"     |");
            Console.WriteLine("<3> | BALANCE INQUIRY |  "+  balance_count+"     |");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine("Successful Transaction:" + st);
            Console.WriteLine("Fail Transaction:" + fail_count);
            Console.WriteLine("Total Transaction: " + tt);
            Console.WriteLine("Thank You for Using our Banking Application");
            Console.WriteLine("--------------------------------------------");
            DateTime date = DateTime.Now;
            Console.WriteLine("Digital Copy Generated on:" + date);
            Console.WriteLine("Branch: Gandhinagar");
            Console.WriteLine("--------------------------------------------");
        }

    }
}
