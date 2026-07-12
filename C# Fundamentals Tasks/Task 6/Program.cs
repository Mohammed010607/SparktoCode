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
        }
    }

    class BankAccount
    {
        public int AccountNumber;
        public string HolderName;
        public double Balance;

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
    }

    class Student
    {
        public int Grade;
        public string Name;
        public string Address;
        private string email;
        int age;

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
            return Price * StockQuantity;
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
