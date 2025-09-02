using System;

namespace Assignment
{
    // Q1. BankAccount
    class BankAccount
    {
        public decimal Balance { get; private set; }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= Balance)
                Balance -= amount;
            else
                Console.WriteLine("Insufficient Balance!");
        }
    }

    // Q2. Student
    class Student
    {
        private int age;
        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 5 && value <= 25)
                    age = value;
                else
                    age = 18;
            }
        }
    }

    // Q3. Employee
    class Employee
    {
        private double basicSalary;
        public double BasicSalary
        {
            set { basicSalary = value; }
        }
        public double TotalSalary
        {
            get { return basicSalary + (basicSalary * 0.2); }
        }
    }

    // Q4. Product
    class Product
    {
        public double Price { get; set; }
        public double Discount { get; set; }

        public double FinalPrice()
        {
            return Price - (Price * Discount / 100);
        }
    }

    // Q5. Car
    class Car
    {
        private int speed;
        public int Speed
        {
            get { return speed; }
            set
            {
                if (value > 180)
                    speed = 180;
                else
                    speed = value;
            }
        }
    }

    // Q6. Delegate Operation
    delegate int Operation(int a, int b);

    // Q7. Delegate FormatText
    delegate string FormatText(string input);

    // Q8. Delegate BillingOperation
    delegate void BillingOperation(double amount);

    // Q9. Delegate ConvertTemperature
    delegate void ConvertTemperature(double celsius);

    // Q10. Delegate Notifier
    delegate void Notifier(string message);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Q1: BankAccount ===");
            BankAccount acc = new BankAccount();
            acc.Deposit(1000);
            Console.WriteLine("Balance after deposit: " + acc.Balance);
            acc.Withdraw(500);
            Console.WriteLine("Balance after withdrawal: " + acc.Balance);

            Console.WriteLine("\n=== Q2: Student ===");
            Student s1 = new Student { Age = 4 };
            Student s2 = new Student { Age = 20 };
            Student s3 = new Student { Age = 30 };
            Console.WriteLine("Age set to 4 -> " + s1.Age);
            Console.WriteLine("Age set to 20 -> " + s2.Age);
            Console.WriteLine("Age set to 30 -> " + s3.Age);

            Console.WriteLine("\n=== Q3: Employee ===");
            Employee emp = new Employee();
            emp.BasicSalary = 30000;
            Console.WriteLine("Total Salary: " + emp.TotalSalary);

            Console.WriteLine("\n=== Q4: Product ===");
            Product prod = new Product { Price = 2000, Discount = 10 };
            Console.WriteLine("Final Price: " + prod.FinalPrice());

            Console.WriteLine("\n=== Q5: Car ===");
            Car car = new Car();
            car.Speed = 150;
            Console.WriteLine("Speed set to 150 -> " + car.Speed);
            car.Speed = 200;
            Console.WriteLine("Speed set to 200 -> " + car.Speed);

            Console.WriteLine("\n=== Q6: Operation Delegate ===");
            Operation add = (a, b) => a + b;
            Operation sub = (a, b) => a - b;
            Console.Write("Enter first number: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Addition: " + add(n1, n2));
            Console.WriteLine("Subtraction: " + sub(n1, n2));

            Console.WriteLine("\n=== Q7: FormatText Delegate ===");
            FormatText upper = str => str.ToUpper();
            FormatText lower = str => str.ToLower();
            string input = "Hello World";
            Console.WriteLine("Uppercase: " + upper(input));
            Console.WriteLine("Lowercase: " + lower(input));

            Console.WriteLine("\n=== Q8: BillingOperation Delegate ===");
            BillingOperation bill;
            double discountedPrice = 0, finalPrice = 0;
            bill = (amt) => Console.WriteLine("Original Price: " + amt);
            bill += (amt) => {
                discountedPrice = amt - (amt * 0.10);
                Console.WriteLine("After Discount (10%): " + discountedPrice);
            };
            bill += (amt) => {
                finalPrice = discountedPrice + (discountedPrice * 0.18);
                Console.WriteLine("After GST (18%): " + finalPrice);
            };
            bill += (amt) => Console.WriteLine("Final Bill: " + finalPrice);
            bill(5000);

            Console.WriteLine("\n=== Q9: ConvertTemperature Delegate ===");
            ConvertTemperature tempConv;
            tempConv = (c) => Console.WriteLine($"{c}°C = {(c * 9 / 5) + 32}°F");
            tempConv += (c) => Console.WriteLine($"{c}°C = {c + 273.15}K");
            tempConv(25);

            Console.WriteLine("\n=== Q10: Notifier Delegate ===");
            Notifier notify;
            notify = (msg) => Console.WriteLine("Email sent: " + msg);
            notify += (msg) => Console.WriteLine("SMS sent: " + msg);
            notify("Assignment Submitted Successfully");
        }
    }
}
