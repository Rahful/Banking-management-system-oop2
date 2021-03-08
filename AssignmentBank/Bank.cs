using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBank
{
    class Bank

    {
       
    public int count = 0;


        Account[] accounts;
        public Bank(int size)
        {
            this.accounts = new Account[size];

        }


        public void CreateAccount(Account account)
        {
            for (int i = 0; i < accounts.Length; i++)
            {
                if (accounts[i] == null)
                {
                    accounts[i] = account;
                    Console.WriteLine("Your account created successfully");
                    Console.WriteLine("your account number:" + accounts[i].Accountnumber);
                    count++;
                    break;
                }
            }
        }


        public void PrintAccount(string accountNumber)
        {
            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accountNumber)
                {
                    accounts[i].PrintAccountDetails();
                    break;

                }

            }

        }

        public void Performtransaction(String accountNumber, int number)
        {
            string ammount, name1, ammount2;
            int ammount1, ammount3;



            for (int i = 0; i < count; i++)
            {
                if (accounts[i].Accountnumber == accountNumber)
                {
                    if (number == 2)
                    {
                        Console.WriteLine("Enter your ammount");
                        ammount = Console.ReadLine();
                        ammount1 = Convert.ToInt32(ammount);

                        if (accounts[i].Accounttype == 1)
                        {
                            accounts[i] = new Savingsaccount(400);
                            accounts[i].Withdraw(ammount1);
                            break;
                        }
                        else
                        {
                            accounts[i].Withdraw(ammount1);
                            break;
                        }
                    }
                    else if (number == 4)
                    {
                        Console.WriteLine("Enter Your Name:");
                        name1 = Console.ReadLine();

                        accounts[i].Accountname = name1;
                        break;
                    }
                    else if (number == 1)
                    {
                        Console.WriteLine("Enter Your Amount");
                        ammount2 = Console.ReadLine();
                        ammount3 = Convert.ToInt32(ammount2);

                        accounts[i].Deposit(ammount3);
                        break;
                    }
                    else if (number == 3)
                    {
                        Console.WriteLine("Enter Account Number:");
                        ammount = Console.ReadLine();
                        Console.WriteLine("Enter Your Amount:");
                        ammount2 = Console.ReadLine();
                        ammount3 = Convert.ToInt32(ammount2);
                        for (int j = 0; j < count; j++)
                        {
                            if (accounts[j].Accountnumber == ammount)
                            {
                                accounts[i].Transfer(accounts[j], ammount3);
                                break;
                            }

                        }
                       
                    }
                    else if (number == 5)
                    {
                        PrintAccount(accounts[i].Accountnumber);
                        Console.WriteLine("Transection number is:" + accounts[i].Accounttransection);
                        break;
                    }

                }
                else
                {
                    break;
                }

            }

        }
    }
}

