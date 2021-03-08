using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentBank
{
    
        class Program
        {
            static void Main(string[] args)
            {
                string temp, j0, nam, num, bel0, checkbrk0, accnum, dob0, add;
                int j = 0, bel1 = 0, type = 0, m = 0, checkbrk1, ran = 10001;

        Bank bank = new Bank(3);
                Console.WriteLine("Welcome to our Bank");
            Start s = new Start();
            s.Load();

            label1:
                Console.WriteLine();
                Console.WriteLine("Select Option:\n1.Open a Bank account\n2.Perform transaction account\n3.Quit");

                temp = Console.ReadLine();
                m = Convert.ToInt32(temp);
                switch (m)
                {
                    case 1:
                        {
                            Console.WriteLine(" 1.Open saving Account\n 2.Open Checking Account\n 3.Exit");
                            j0 = Console.ReadLine();
                            j = Convert.ToInt32(j0);
                            if (j == 3)
                            {
                                break;
                            }
                            else
                            {


                                Console.Write("Enter your name:");
                                nam = Console.ReadLine();

                                Console.WriteLine();

                                Console.Write("Enter your Date of birth:");
                                dob0 = Console.ReadLine();



                                Console.WriteLine();
                                Console.WriteLine("Enter your address:");
                                add = Console.ReadLine();
                                ran++;
                                num = ran.ToString();

                                Console.WriteLine();

                                Console.Write("Enter 1st Entry balance:");
                                bel0 = Console.ReadLine();
                                bel1 = Convert.ToInt32(bel0);

                                if (j == 1)
                                {
                                    type = 1;
                                }
                                else
                                {
                                    type = 2;
                                }

                                bank.CreateAccount(new Account() { Accountname = nam, Date = dob0, Address = add, Accountnumber = num, Balance = +bel1, Accounttype = +j });
                            }
                            goto label1;
                            break;

                        }
                    case 2:
                        {
                            Console.Write("Enter your accountnum:");
                            accnum = Console.ReadLine();

                            for (; ; )
                            {
                                Console.WriteLine();
                                checkbrk1 = 0;
                                Console.WriteLine(" 1.Deposit money in his account\n 2.Withdraw money from account\n 3.Transfer money to another account\n 4.Change the owner name\n 5.Display the number of transactions\n 6.Exit from the application");
                                checkbrk0 = Console.ReadLine();
                                checkbrk1 = Convert.ToInt32(checkbrk0);


                                if (checkbrk1 == 6)
                                {
                                    break;
                                }
                                else
                                {
                                    bank.Performtransaction(accnum, checkbrk1);

                                }

                                break;
                            }
                        }
                        goto label1;
                        break;
                    case 3:
                        break;


                }
            }
        class Start
        {

            int m;
            internal virtual void Load()
            {
                Console.Write("\n1.Open");
                Console.WriteLine("\n2.Exit");
                m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        {
                            Console.WriteLine("Opening..");
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Exit Application");
                            break;
                        }

                }
            }
        }
    }


}
  

