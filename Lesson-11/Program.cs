using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_11
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount ba = new BankAccount("poalim", 123456789, 2000);
            Person p = new Person("itay", 23);
            Person p1 = new Person("itayw", 213);
            Person p2 = new Person("itaye", 2743);
            Person.ChangeName(p1, "rotem");
            Console.WriteLine(p1.name);
            Console.WriteLine(Person.numOfPeople);

            Console.ReadLine();
        }
    }
    class BankAccount
    {
        private string bankName;
        private long accountNumber;
        private double balance;

        public BankAccount(string bankName, long accountNumber, double balance)
        {
            this.bankName = bankName;
            this.accountNumber = accountNumber;
            this.balance = balance;
        }

        public void WithdrawOrDeposit(double add)
        {
            this.balance += add;
        }
        public string GetAccountDetails()
        {
            string a = "Bank name: " + this.bankName + ". Account number: " + this.accountNumber;
            return a;
        }
    }
    class Person
    {
        public string name;
        private readonly long id;
        public static int numOfPeople = 0;

        public Person(string name, long id)
        {
            this.name = name;
            this.id = id;
            numOfPeople++;
        }
        public static void ChangeName(Person p, string newName)
        {
            p.name = newName;
        }
    }
}
