using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBank
{
    class Savingsaccount : Account

    {
        public double minamount;



        public Savingsaccount(double a)
        {
            this.minamount = a;




        }

        public override void Withdraw(double amount)
        {
            if (amount > 0)
            {
                if (amount < balance - amount)
                {
                    balance -= amount;//this.balance=this.balance-amount
                }
                else
                {
                    Console.WriteLine("Balance:"+balance);
                   // Console.WriteLine("not aplicable");
                }
            }
        }

    }
}



