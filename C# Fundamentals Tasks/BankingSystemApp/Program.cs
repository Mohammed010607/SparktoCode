using System;
using System.Collections.Generic;
using System.Data.Common;
namespace BankingSystemApp
{
    internal class Program
    {
        // Shared data storage - declared at class level (static) so that
        // EVERY function below can read and modify the same three lists
        // without needing them passed in as parameters.
        static List<string> customerNames = new List<string>();
        static List<string> accountNumbers = new List<string>();
        static List<double> balances = new List<double>();
        static void Main(string[] args)
        {
            bool exitApp = false;
            while (!exitApp)
            {
                Console.WriteLine("\n===== Welcome to Spark Bank =====");
                Console.WriteLine("1. Add New Account");
                Console.WriteLine("2. Deposit Money");
                Console.WriteLine("3. Withdraw Money");
                Console.WriteLine("4. Show Balance");
                Console.WriteLine("5. Transfer Amount");
                Console.WriteLine("6. Account Tier");
                Console.WriteLine("7. List All Accounts");
                Console.WriteLine("8. Exit");
                Console.Write("Choose an option: ");
                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 1 to 8.");
                    continue; // skip the rest of this loop pass, show the menu again
                }
                switch (choice)
                {
                    case 1:
                        AddAccount();
                        break;
                    case 2:
                        DepositMoney();
                        break;
                    case 3:
                        WithdrawMoney();
                        break;
                    case 4:
                        ShowBalance();
                        break;
                    case 5:
                        TransferAmount();
                        break;
                    case 6:
                        // TODO: call your first custom service function here
                        AccountTier();
                        break;
                    case 7:
                        // TODO: call your second custom service function here
                        ListAcoounts();
                        break;
                    case 8:
                        exitApp = true;
                        Console.WriteLine("Thank you for banking with Spark Bank. Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 1 and 8.");
                        break;
                }
            }
        }
        // ===================== SERVICE FUNCTIONS =====================
        // Each function owns ONE service end-to-end: it asks the user for
        // whatever it needs, validates it, updates the shared lists, and
        // prints the outcome. Main never reads input or prints results
        // for these services - it only shows the menu and calls them.
        static void AddAccount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.WriteLine("\nPlease Enter Your Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Please Enter Your New Account Number: ");
            string accountNum = Console.ReadLine().ToUpper();
            if (accountNumbers.Contains(accountNum))
            {
                Console.WriteLine("Error, Account Number Already Exists.");
                return;
            }
            Console.WriteLine("Enter Your Initial Deposit Amount: ");
            double depositAmount;
            try
            {
                depositAmount = double.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, Invalid Number Input.");
                return;
            }
            while (depositAmount < 0)
            {
                Console.WriteLine("Invalid Amount, Try Again:");
                try
                {
                    depositAmount = double.Parse(Console.ReadLine());
                }

                catch (FormatException)
                {
                    Console.WriteLine("Error, Invalid Number Entered.");
                    depositAmount = -1;
                }
            }
            customerNames.Add(name);
            accountNumbers.Add(accountNum);
            balances.Add(depositAmount);
            Console.WriteLine("\nAccount Details:");
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Account Number: " + accountNum);
            Console.WriteLine("Balance: " + depositAmount);
        }
        static void DepositMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.WriteLine("\nEnter Your Account Number: ");
            string existingAccount = Console.ReadLine().ToUpper();
            int index = accountNumbers.IndexOf(existingAccount);


            if (index == -1)
            {
                Console.WriteLine("Error, Account Does Not Exist.");

            }
            else
            {
                Console.WriteLine("Please Enter The Deposit Amount: ");
                double amount;
                try
                {
                    amount = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, Invalid Number Entered.");
                    return;
                }

                if (amount <= 0)
                {
                    Console.WriteLine("Error, Ammount Cannot Be Zero or Below.");
                }
                else
                {
                    balances[index] += amount;
                    Console.WriteLine("\nYour Updated Balance: " + balances[index]);
                }

            }
        }
        static void WithdrawMoney()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.WriteLine("\nEnter Your Account Number: ");
            string existingAccount = Console.ReadLine().ToUpper();
            int index = accountNumbers.IndexOf(existingAccount);

            if (index == -1)
            {
                Console.WriteLine("Error, Account Does Not Exist.");
            }
            else
            {
                Console.WriteLine("\nEnter A Withdrawl Ammount: ");
                double withdrawl;
                try
                {
                    withdrawl = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, Invalid Number Entered.");
                    return;
                }

                if (withdrawl <= 0 || withdrawl > balances[index])
                {
                    Console.WriteLine("Error, Bank Overdraft or Withdrawl is Less than Zero.");
                }
                else
                {
                    balances[index] -= withdrawl;
                    Console.WriteLine("Updated Balance: " + balances[index]);
                }
            }
        }
        static void ShowBalance()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.WriteLine("\nEnter Your Account Number: ");
            string existingAccount = Console.ReadLine().ToUpper();
            int index = accountNumbers.IndexOf(existingAccount);

            if (index == -1)
            {
                Console.WriteLine("Error, Account Does Not Exist.");
            }
            else
            {
                Console.WriteLine("\nAccount Details:");
                Console.WriteLine("Name: " + customerNames[index]);
                Console.WriteLine("Account Number: " + accountNumbers[index]);
                Console.WriteLine("Balance: " + balances[index]);
            }
        }
        static void TransferAmount()
        {
            // TODO: implement this service (see Section 3 requirements)
            Console.WriteLine("\nEnter The Sender's Account Number: ");
            string senderAccount = Console.ReadLine().ToUpper();
            Console.WriteLine("Enter Receiver's Account Number: ");
            string recievrAccount = Console.ReadLine().ToUpper();
            int index1 = accountNumbers.IndexOf(senderAccount);
            int index2 = accountNumbers.IndexOf(recievrAccount);

            if (index1 == -1 || index2 == -1)
            {
                Console.WriteLine("Error, Invalid Account Number.");
            }
            else
            {
                Console.WriteLine("Please Enter The Transfer Amount: ");
                double transferQuantity;
                try
                {
                    transferQuantity = double.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error, Invalid Amount Entered. ");
                    return;
                }
                if (transferQuantity <= 0 || transferQuantity > balances[index1])
                {
                    Console.WriteLine("Error, Insufficient Amount");
                }
                else
                {
                    balances[index1] -= transferQuantity;
                    balances[index2] += transferQuantity;

                    Console.WriteLine("\nUpdated Balance For " + accountNumbers[index1] + " Is: " + balances[index1]);
                    Console.WriteLine("Updated Balance For " + accountNumbers[index2] + " Is: " + balances[index2]);
                }

            }
        }
        // TODO: write two more void, no-parameter functions here for
        // your own custom services (option 6 and option 7)
        static void AccountTier()
        {
            Console.WriteLine("\nEnter Your Account Number: ");
            string existingAccount = Console.ReadLine().ToUpper();
            int index = accountNumbers.IndexOf(existingAccount);

            if (index == -1)
            {
                Console.WriteLine("Error, Account Does Not Exist");
                return;
            }

            double balance = balances[index];
            string tier;
            if (balance >= 30000)
            {
                tier = "Diamond";
            }
            else if (balance >= 20000)
            {
                tier = "Gold";
            }
            else if (balance >= 15000)
            {
                tier = "Silver";
            }
            else if (balance >= 10000)
            {
                tier = "Bronze";
            }
            else
            {
                tier = "Standard";
            }

            Console.WriteLine("\nAccount Tier: ");
            Console.WriteLine("Name: " + customerNames[index]);
            Console.WriteLine("Account Number: " + accountNumbers[index]);
            Console.WriteLine("Balance: " + balance);
            Console.WriteLine("Tier: " + tier);
        }

        static void ListAcoounts()
        {
            if (customerNames.Count == 0)
            {
                Console.WriteLine("\nNo Accounts Found.");
                return;
            }

            Console.WriteLine("\n-------- All Accounts --------");
            for (int i = 0; i < customerNames.Count; i++)
            {
                Console.WriteLine("Name: " + customerNames[i]);
                Console.WriteLine("Account Number: " + accountNumbers[i]);
                Console.WriteLine("Balance: " + balances[i]);
                Console.WriteLine();
            }
        }
    }
}