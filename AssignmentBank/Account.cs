using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBank
{
    class Account
    {
        protected String accountname, date, address, accountnumber;
        protected double balance;
        protected int transections = 0, type = 0;

        public string Accountname
        {
            set { this.accountname = value; }
            get { return this.accountname; }
        }
        public string Date
        {
            set { this.date = value; }
            get { return this.date; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public string Accountnumber
        {
            set { this.accountnumber = value; }
            get { return this.accountnumber; }
        }
        public double Balance
        {
            set { this.balance = value; }
            get { return this.balance; }
        }
        public int Accounttype
        {
            set { this.type = value; }
            get { return this.type; }
        }
        public int Accounttransection
        {

            get { return this.transections; }
        }
        public virtual void Withdraw(double amount)
        {
            if (amount > 0)
            {
                this.balance -= amount;//this.balance=this.balance-amount
                this.transections++;
                Console.Write("Balance:"+balance);
            }
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;//this.balance=this.balance+amount
                this.transections++;
                Console.Write("Balance:" + balance);
            }
        }



        public void Transfer(Account receiver, double amount)
        {
            this.Withdraw(amount);
            receiver.Deposit(amount);
           // Console.Write("Present Balance:" + amount);



        }



        public void PrintAccountDetails()
        {
            Console.WriteLine("Account Name:{0}\nDate:{1}\nAddress:{2}\nAccount Number:{3}\nBalance:{4}", this.accountname, this.date, this.address, this.accountnumber, this.balance);
        }
    }




}

