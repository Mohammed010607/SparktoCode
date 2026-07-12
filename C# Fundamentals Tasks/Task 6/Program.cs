namespace Task_6__OOP_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount
            {
                AccountNumber = 123,
                HolderName = "Mohammed",
                Balance = 205.5
            };

            BankAccount account2 = new BankAccount
            {
                AccountNumber = 246,
                HolderName = "Ahmed",
                Balance = 427.9
            };

            Student student1 = new Student
            {
                Grade = 78,
                Name = "Sara",
                Address = "Seeb",
            };

            Student student2 = new Student
            {
                Grade = 83,
                Name = "Ali",
                Address = "Muscat"
            };

            Product product1 = new Product
            {
                ProductName = "Nvidia RTX 5070",
                Price = 255,
                StockQuantity = 32,
            };

            Product product2 = new Product
            {
                ProductName = "AMD Ryzen 7 9800X3D",
                Price = 210.5,
                StockQuantity = 78,
            };

            //Helpers:


            /*
              
             //---------------------------------------EASY (Case 1-5)-------------------------------------------------------------
            // Case 1 (View Account Details)
            int option;
            do
            {
                Console.WriteLine("Select an Option: ");
                Console.WriteLine("1. View Account Details.");
                Console.WriteLine("2. Exit.");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        Console.WriteLine("\nChoose an Account (1 or 2)");
                        int selectedOption = int.Parse(Console.ReadLine());
                        if (selectedOption == 1)
                        {
                            account1.CheckBalance();
                        }
                        else if (selectedOption == 2)
                        {
                            account2.CheckBalance();
                        }
                        else
                        {
                            Console.WriteLine("Invalid Input.");
                        }
                        break;

                    case 2:
                        Console.WriteLine("Exiting..."); 
                        break;

                    default:
                        Console.WriteLine("Invalid Input."); 
                        break;
                }
            }
            while (option != 2);
            

            //Case 2 (Update Student Address)
            Console.WriteLine("Select a Student (1 or 2)");
            Console.WriteLine("1. "+student1.Name);
            Console.WriteLine("2. " + student2.Name);
            int selection = int.Parse(Console.ReadLine());

            if (selection == 1)
            {
                Console.WriteLine("\nEnter The New Address: ");
                string updateAddress = Console.ReadLine();
                student1.Address = updateAddress;
                Console.WriteLine("Adress: " + student1.Address);
            }
            else if (selection == 2) {
                Console.WriteLine("\nEnter The New Address: ");
                string updateAddress = Console.ReadLine();
                student2.Address = updateAddress;
                Console.WriteLine("Address: " + student2.Address);
            }
            else
            {
                Console.WriteLine("\nInvalid Input.");
            }
            

            // Case 3 (Make A Deposit):
            Console.WriteLine("Select a Bank Account: ");
            Console.WriteLine(account1.AccountNumber); 
            Console.WriteLine(account2.AccountNumber);
            int selectedAccount = int.Parse(Console.ReadLine());
            double amount;
            if (selectedAccount == account1.AccountNumber)
            {
                Console.WriteLine("\nEnter a Deposit Amount: ");
                amount = double.Parse(Console.ReadLine());
                account1.Deposit(amount);
                Console.WriteLine("Account Holder: " + account1.HolderName);
                Console.WriteLine("Updated Balance: " + account1.Balance);
            }
            else if (selectedAccount == account2.AccountNumber) {
                Console.WriteLine("\nEnter a Deposit Amount: ");
                amount = double.Parse(Console.ReadLine());
                account2.Deposit(amount);
                Console.WriteLine("Account Holder: " + account2.HolderName);
                Console.WriteLine("Updated Balance: " + account2.Balance);
            }
            else
            {
                Console.WriteLine("Account Doesn't Exist.");
            }
            

            //Case 4 (Make A Withdrawl):
            Console.WriteLine("Select a Bank Account: ");
            Console.WriteLine(account1.AccountNumber);
            Console.WriteLine(account2.AccountNumber);
            int selectedAccount = int.Parse(Console.ReadLine());
            double withdrawAmount;

            if (selectedAccount == account1.AccountNumber)
            {
                Console.WriteLine("\nEnter a Withdrawl Amount: ");
                withdrawAmount = double.Parse(Console.ReadLine());
                account1.Withdraw(withdrawAmount);
                Console.WriteLine("Account Holder: " + account1.HolderName);
                Console.WriteLine("Updated Balance: " + account1.Balance);
            }
            else if (selectedAccount == account2.AccountNumber) {
                Console.WriteLine("\nEnter a Withdrawl Amount: ");
                withdrawAmount = double.Parse(Console.ReadLine());
                account2.Withdraw(withdrawAmount);
                Console.WriteLine("Account Holder: " + account2.HolderName);
                Console.WriteLine("Updated Balance: " + account2.Balance);
            }
            else
            {
                Console.WriteLine("Account Doesn't Exist");
            }

            //Case 5 (View Product Details):
            Console.WriteLine("Select The Product By Number: ");
            Console.WriteLine("1. "+product1.ProductName);
            Console.WriteLine("2. "+product2.ProductName);
            int selection = int.Parse(Console.ReadLine());
            Console.WriteLine();

            if (selection == 1)
            {
                Console.WriteLine("Total Value: " + product1.GetInventoryValue());
            }
            else if (selection == 2) {
                Console.WriteLine("Total Value: " + product2.GetInventoryValue());
            }
            else
            {
                Console.WriteLine("Invalid, Product Doesn't Exist.");
            }
            

            //-------------------------------MEDIUM (Case 6-8)----------------------------------------
            // Case 6 (Register Student):
            Console.WriteLine("Select A Student: ");
            Console.WriteLine("1. "+ student1.Name);
            Console.WriteLine("2. "+ student2.Name);
            string studentPicked = Console.ReadLine();

            if (studentPicked == student1.Name)
            {
                Console.WriteLine("Enter The Email: ");
                string email = Console.ReadLine();
                student1.Register(email);
                Console.WriteLine("Registered Successfully.");
            }
            else if (studentPicked == student2.Name) {
                Console.WriteLine("Enter The Email: ");
                string email = Console.ReadLine();
                student2.Register(email);
                Console.WriteLine("Registered Successfully.");
            }
            else
            {
                Console.WriteLine("Invalid, Student Doesn't Exist.");
            }
            

            //Case 7 (Compare Two Account Balances)
            if (account1.Balance > account2.Balance) {
                Console.WriteLine("Account 1 has a Greater Balance");
            }
            else if (account1.Balance < account2.Balance) {
                Console.WriteLine("Account 2 has a Greater Balance");
            }
            else
            {
                Console.WriteLine("Both Accounts Have Equal Balances.");
            }
            

            //Case 8 (Restock Product & Stock Level Check):
            Console.WriteLine("Select The Product By Number: ");
            Console.WriteLine("1. " + product1.ProductName);
            Console.WriteLine("2. " + product2.ProductName);
            int pSelection = int.Parse(Console.ReadLine());
            int restockQuantity;
            Console.WriteLine();

            if (pSelection == 1)
            {
                Console.WriteLine("Enter an Amount To Restock: ");
                restockQuantity = int.Parse(Console.ReadLine());
                product1.Restock(restockQuantity);

                if (product1.StockQuantity < 10)
                    Console.WriteLine("Stock is Low");
                else if (product1.StockQuantity < 50)
                    Console.WriteLine("Stock is Moderate");
                else
                    Console.WriteLine("Well Stocked");
            }
            else if (pSelection == 2) {
                Console.WriteLine("Enter an Amount To Restock: ");
                restockQuantity = int.Parse(Console.ReadLine());
                product2.Restock(restockQuantity);

                if (product2.StockQuantity < 10)
                    Console.WriteLine("Stock is Low");
                else if (product2.StockQuantity < 50)
                    Console.WriteLine("Stock is Moderate");
                else
                    Console.WriteLine("Well Stocked");
            }
            else
            {
                Console.WriteLine("Invalid, Product Doesn't Exist.");
            }

            //----------------------------HARD (Case 9-13)-------------------------------------

            //Case 9 (Transfer Between Accounts):
            Console.WriteLine("Select a Source Account: ");
            Console.WriteLine(account1.AccountNumber);
            Console.WriteLine(account2.AccountNumber);
            int sourceAccount = int.Parse(Console.ReadLine());

            Console.WriteLine("\nSelect a Destination Account: ");
            Console.WriteLine(account1.AccountNumber);
            Console.WriteLine(account2.AccountNumber);
            int destinationAccount = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an Amount to Transfer: ");
            double transferAmount = double.Parse(Console.ReadLine());

            BankAccount source;
            if (sourceAccount == account1.AccountNumber)
            {
                source = account1;
            }
            else
            {
                source = account2;
            }

            BankAccount destination;
            if (destinationAccount == account1.AccountNumber) { 
                destination = account1;
            }
            else
            {
                destination = account2;
            }

            if(source.Balance >= transferAmount)
            {
                source.Withdraw(transferAmount);
                destination.Deposit(transferAmount);
                Console.WriteLine("Transfer Successful.");
            }
            else
            {
                Console.WriteLine("Insufficient Funds.");
            }

            //Case 10 (Update Student Grade (Validated)):
            Console.WriteLine("Pick A Student");
            Console.WriteLine("- "+student1.Name);
            Console.WriteLine("- "+student2.Name);
            string pickedStudent = Console.ReadLine();

            Student selected;
            if(pickedStudent == student1.Name)
            {
                selected = student1;
            }
            else
            {
                selected = student2;
            }
            try
            {
                Console.WriteLine("Enter a New Grade: ");
                int newGrade = int.Parse(Console.ReadLine());

                if (newGrade > 100 || newGrade < 0)
                {
                    Console.WriteLine("Error, Invalid Input.");
                }
                else
                {
                    selected.Grade = newGrade;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error, Input Must Be An Integer.");
            }

            //Case 11 (Student Report Card)
            Console.WriteLine("Pick A Student");
            Console.WriteLine("- " + student1.Name);
            Console.WriteLine("- " + student2.Name);
            string pickedStudent = Console.ReadLine();

            Student studentSelected;
            if (pickedStudent == student1.Name)
            {
                studentSelected = student1;
            }
            else
            {
                studentSelected = student2;
            }

            Console.WriteLine();
            Console.WriteLine("---------------REPORT-CARD---------------");
            Console.WriteLine("Name: "+studentSelected.Name);
            Console.WriteLine("Address: "+studentSelected.Address);
            Console.WriteLine("Grade: "+studentSelected.Grade);

            if(studentSelected.Grade >= 60)
            {
               Console.WriteLine("Status: Pass");
            }
            else
            {
               Console.WriteLine("Status: Fail");
            }

            //Case 12 (Account Health Status)
            Console.WriteLine("Select an Account: ");
            Console.WriteLine(account1.AccountNumber);
            Console.WriteLine(account2.AccountNumber);
            int pickedAccount = int.Parse(Console.ReadLine());

            BankAccount picked;
            if (pickedAccount == account1.AccountNumber)
            {
                picked = account1;
            }
            else
            {
                picked = account2;
            }
            Console.WriteLine("\nAccount Status: ");
            if(picked.Balance < 50)
            {
                Console.WriteLine("Low Balance");
            }
            else if(picked.Balance >= 50 && picked.Balance <= 1000) {
                Console.WriteLine("Healthy");
            }
            else
            {
                Console.WriteLine("Premium");
            }

            // Case 13 (Bulk Sale With Revenue Calculation)

            Console.WriteLine("Select A Product To Sell:");
            Console.WriteLine("1. "+product1.ProductName);
            Console.WriteLine("2. " + product2.ProductName);
            string productPicked = Console.ReadLine();
            Console.WriteLine("\nEnter A Quantity To Sell: ");
            int sellQuantity = int.Parse(Console.ReadLine());

            Product chosenProduct;
            if(productPicked == product1.ProductName)
                chosenProduct = product1;
            else
                chosenProduct= product2;

            int neededStock;
            if(sellQuantity > chosenProduct.StockQuantity)
            {
                Console.WriteLine("Not Enough Stock.");
                neededStock = sellQuantity - chosenProduct.StockQuantity;
                Console.WriteLine("Additional " + neededStock + " Stock Needed");
            }
            else
            {
                chosenProduct.Sell(sellQuantity);
                Console.WriteLine("Sale: " + chosenProduct.Price * sellQuantity+" OMR");
            }

            //---------------------------------ADVANCED (Case 14-15)-----------------------------------
            // Case 14 (Scholarship Eligibility Check)

            Console.WriteLine("Pick A Student");
            Console.WriteLine("- " + student1.Name);
            Console.WriteLine("- " + student2.Name);
            string chooseStudent = Console.ReadLine();

            Student studentGrabbed;
            if(chooseStudent == student1.Name)
                studentGrabbed = student1;
            else
                studentGrabbed = student2;

            Console.WriteLine("\nSelect an Account: ");
            Console.WriteLine(account1.AccountNumber);
            Console.WriteLine(account2.AccountNumber);
            int chooseAccount = int.Parse(Console.ReadLine());

            BankAccount accountGrabbed;
            if (chooseAccount == account1.AccountNumber)
                accountGrabbed = account1;
            else
                accountGrabbed= account2;


            bool gradeCheck = studentGrabbed.Grade >= 80;
            bool balanceCheck = accountGrabbed.Balance >= 100;
            if(gradeCheck && balanceCheck)
            {
                Console.WriteLine("Eligible");
            }
            else if (!balanceCheck && !gradeCheck) 
            {
                Console.WriteLine("Not Eligible, Grade is Below 80 & Balance is Below 100");
            }
            else if (!gradeCheck)
            {
                Console.WriteLine("Not Eligible, Grade is below 80");
            }
            else
            {
                Console.WriteLine("Not Eligible, Balance is Below 100");
            }

            //Case 15 (Full Balance Top-Up Flow):
            Console.WriteLine("Select A B Account: ");
            Console.WriteLine(account1.AccountNumber);
            Console.WriteLine(account2.AccountNumber);
            int pulledAccount = int.Parse(Console.ReadLine());

            BankAccount accountPulled;
            if (pulledAccount == account1.AccountNumber)
                accountPulled = account1;
            else
                accountPulled = account2;

            double topupNeeded;
            if (accountPulled.Balance < 50)
            {
                double before = accountPulled.Balance;
                topupNeeded = 100 - accountPulled.Balance;
                accountPulled.Deposit(topupNeeded);
                double after = accountPulled.Balance;
                Console.WriteLine("Balance Before Top-Up: " + before+" OMR");
                Console.WriteLine("Balance After Top-Up: "+after+" OMR");
            }
            else
            {
                Console.WriteLine("No Top-Up is Needed.");
            }

            // Case 16 (Quick Account Opening [Parameterized Constructor]):
            Console.WriteLine("Enter Account Number: ");
            int newAccNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Holder Name: ");
            string newHolderName = Console.ReadLine();
            Console.WriteLine("Enter Starting Balance: ");
            double newBalance = double.Parse(Console.ReadLine());

            BankAccount newAccount = new BankAccount(newAccNum, newHolderName, newBalance);
            Console.WriteLine("Account Number: " + newAccount.AccountNumber);
            newAccount.CheckBalance();

            // Case 17 (Total Students Counter [Static Fields & Methods]):
            Console.WriteLine("Total Students Created: " + Student.GetStudentCount());
            */

            // Case 18 (Overdrawn Account Check [Read-Only Property]):

            Console.WriteLine("Select an Account: ");
            Console.WriteLine(account1.AccountNumber);
            Console.WriteLine(account2.AccountNumber);
            int overdrawnCheck = int.Parse(Console.ReadLine());

            BankAccount checkedAccount;
            if (overdrawnCheck == account1.AccountNumber)
                checkedAccount = account1;
            else
                checkedAccount = account2;

            if (checkedAccount.IsOverdrawn)
                Console.WriteLine("The account is overdrawn.");
            else
                Console.WriteLine("The account is not overdrawn.");
        }
    }

    //Bank Account Class
    class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

        public BankAccount() { }

        //Case 16 (Quick Account Opening [Parameterized Constructor])
        public BankAccount(int accountNumber, string holderName, double balance)
        {
            AccountNumber = accountNumber;
            HolderName = holderName;
            Balance = balance;
        }

        public void Deposit(double amount) {
            Balance += amount;
            SendEmail();
        }

        public void Withdraw(double amount) { 
            if(Balance >= amount)
            {
                Balance -= amount;
            }
            else
            {
               Console.WriteLine("Insufficient Funds.");
            }
            SendEmail();
        }

        public double CheckBalance()
        {
            PrintInformation();
            return Balance;
        }

        private void PrintInformation()
        {
            Console.WriteLine("Name: " + HolderName);
            Console.WriteLine("Balance: " + Balance);
        }

        private void SendEmail()
        {
            Console.WriteLine("Email Notification Sent.");
        }
        public bool IsOverdrawn
        {
            get { return Balance < 0; }
        }
    }

    //Student Class
    class Student
    {
        public int Grade;
        public string Name;
        public string Address;
        private string email;
        int age;

        //Case 17 (Total Students Counter [Static Fields & Methods]):

        public static int Count;

        public Student()
        {
            Count++;
        }
        public static int GetStudentCount()
        {
            return Count;
        }
        public void Register(string Email)
        {
            email = Email;
            SendEmail();
        }

        private void SendEmail()
        {
            Console.WriteLine("Email Has Been Sent.");
        }
    }

    //Product Class
    class Product
    {
        public string ProductName;
        public double Price;
        public int StockQuantity;

        public void Sell(int quantity)
        {
            if (StockQuantity >= quantity)
            {
                StockQuantity -= quantity;
            }
            else
            {
                Console.WriteLine("Not Enough Stock. ");
            }
            LogTransaction();
        }

        public void Restock(int quantity)
        {
            StockQuantity += quantity;
            LogTransaction();
        }

        public double GetInventoryValue()
        {
            PrintDetails();
            return  Price * StockQuantity;
        }
        private void PrintDetails()
        {
            Console.WriteLine("Product: " + ProductName);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Available Stock: " + StockQuantity);
        }

        private void LogTransaction()
        {
            Console.WriteLine("Transaction Logged.");
        }
    }
}
