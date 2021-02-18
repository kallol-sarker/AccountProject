using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    internal class SavingsAccount : Account
    {
        internal override string Id
        {
            set { base.Id = "S-" + value; }
        }

        internal SavingsAccount(string name, MyDate dateOfBirth, OurAddress address, double balance) : base(name, dateOfBirth, address, balance)
        {

        }
        internal override bool Withdraw(double amount)
        {
            if (this.Balance > amount)
            {
                if (amount <= 2000)
                {
                    base.Withdraw(amount);
                    Console.WriteLine("Withdraw of {0} amount is Completed", amount);
                    return true;
                }
                else
                {
                    Console.WriteLine("You cannot withdraw more than 2000 at once!!!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Not Sufficient Balance in your Account!!!");
                return false;
            }
        }
    }
}

