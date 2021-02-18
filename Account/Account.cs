using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    internal struct MyDate
    {
        private byte day;
        private string month;
        private ushort year;

        internal MyDate(byte day, string month, ushort year)
        {
            if (day >= 1 && day <= 31)
            {
                this.day = day;
                this.month = month;
                this.year = year;
            }
            else
            {
                this.day = 1;
                this.month = "January";
                this.year = 1998;
            }
        }

        internal void ShowDate()
        {
            Console.WriteLine("date of birth: {0} /{1}/ {2} ", this.day, this.month, this.year);
        }

    }

    internal struct OurAddress
    {
        private int apartmentNumber;
        private string roadNoName;
        private string district;
        private string country;


        internal OurAddress(int apartmentNumber, string roadNoName, string district, string country)
        {
            this.apartmentNumber = apartmentNumber;
            this.roadNoName = roadNoName;
            this.district = district;
            this.country = country;
        }


        public void ShowAddress()
        {
            Console.WriteLine("Address Info: {0},{1},{2},{3}", this.apartmentNumber, this.roadNoName, this.district, this.country);
        }
    }
    internal class Account
    {
        private static int serialNo = 0;
        private string id;
        private string name;
        private MyDate dateOfBirth;
        private OurAddress address;
        private double balance;

        internal virtual string Id
        {
            get { return this.id; }
            set
            {
                this.id = "A" + value;
            }
        }

        internal string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        internal MyDate DateOfBirth
        {
            get
            {
                return this.dateOfBirth;
            }
            set
            {
                this.dateOfBirth = value;
            }
        }

        internal OurAddress Address
        {
            get { return this.address; }
            set { this.address = value; }
        }


        internal double Balance
        {
            get
            {
                return this.balance;
            }
            set
            {
                this.balance = value;
            }

        }
        internal void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.Balance += amount;
            }
            else
            {
                Console.WriteLine("Please Deposit a valid amount");
            }
        }

        internal virtual bool Withdraw(double amount)
        {
            if (amount > 0)
            {
                this.Balance -= amount;
                return true;
            }
            else
            {
                Console.WriteLine("Please withdraw a valid amount");
                return false;
            }
        }

        internal Account(string name, MyDate dateOfBirth, OurAddress address, double balance)
        {
            this.Id = (++serialNo).ToString();
            this.Name = name;
            this.DateOfBirth = dateOfBirth;
            this.Address = address;
            this.Balance = balance;
        }

        internal void ShowInfo()
        {
            Console.WriteLine("Account information");
            Console.WriteLine("Person's ID: {0}", this.Id);
            Console.WriteLine("Person's Name: {0}", this.Name);
            this.DateOfBirth.ShowDate();
            this.Address.ShowAddress();
            Console.WriteLine("Person's Balance: {0}\n", this.Balance);
        }
    }
}

