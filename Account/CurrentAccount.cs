using System;
using System.Collections.Generic;
using System.Text;

namespace Account
{
    internal class CurrentAccount : Account
    {
        internal override string Id
        {
            set { base.Id = "C-" + value; }
        }
        internal override bool Withdraw(double amount)
        {
            if (this.Balance > amount)
            {
                if (amount <= 5000)
                {
                    base.Withdraw(amount);
                    Console.WriteLine("Withdraw of {0} amount is Completed", amount);
                    return true;
                }
                else
                {
                    Console.WriteLine("You cannot withdraw more than 5000 at once!!!");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Not Sufficient Balance in your Account!!!");
                return false;
            }
        }

        

        internal CurrentAccount(string name, MyDate dateOfBirth, OurAddress address, double balance) : base(name, dateOfBirth, address, balance)
        {

        }
    }
}
