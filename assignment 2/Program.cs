using System;
using System.Collections.Generic;

namespace LabAssignment2
{
    class UserProfile
    {
        private string username;
        private string password;
        private string email;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (value.Length >= 6)
                    password = value;
                else
                    Console.WriteLine("Password must be at least 6 characters.");
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value.Contains("@"))
                    email = value;
                else
                    Console.WriteLine("Invalid email format.");
            }
        }

        public void Display()
        {
            Console.WriteLine($"Username: {username}, Email: {email}");
        }
    }

    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    class Truck : Vehicle
    {
        public void DisplayDetails()
        {
            Console.WriteLine($"Truck - {Year} {Make} {Model}");
        }
    }

    class Bus : Vehicle
    {
        public void DisplayDetails()
        {
            Console.WriteLine($"Bus - {Year} {Make} {Model}");
        }
    }

    class Calculator
    {
        public int Add(int a, int b) => a + b;
        public float Add(float a, float b) => a + b;
        public double Add(double a, double b) => a + b;
    }

    abstract class Employee
    {
        public string Name { get; set; }
        public abstract double CalculateSalary();
    }

    class FullTimeEmployee : Employee
    {
        public double MonthlySalary { get; set; }
        public override double CalculateSalary() => MonthlySalary;
    }

    class PartTimeEmployee : Employee
    {
        public double HourlyRate { get; set; }
        public int HoursWorked { get; set; }
        public override double CalculateSalary() => HourlyRate * HoursWorked;
    }

    class Student
    {
        public string Name { get; set; }
        public int RollNo { get; set; }
        public int Marks { get; set; }

        public Student() { }
        public Student(string name, int rollNo)
        {
            Name = name;
            RollNo = rollNo;
        }
        public Student(string name, int rollNo, int marks)
        {
            Name = name;
            RollNo = rollNo;
            Marks = marks;
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}, RollNo: {RollNo}, Marks: {Marks}");
        }
    }

    class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                if (value >= 0) price = value;
                else Console.WriteLine("Price cannot be negative.");
            }
        }
        public int Quantity { get; set; }

        public void Display()
        {
            Console.WriteLine($"ID: {ProductID}, Name: {ProductName}, Price: {Price}, Quantity: {Quantity}");
        }
    }

    class Book
    {
        public string Title { get; set; }
        public bool IsAvailable { get; set; } = true;
    }

    class Member
    {
        public string Name { get; set; }
        public void BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine($"{Name} borrowed {book.Title}");
            }
            else
            {
                Console.WriteLine($"{book.Title} is not available.");
            }
        }
    }

    class Library
    {
        public List<Book> Books = new List<Book>();
        public void AddBook(Book book) => Books.Add(book);
        public void ShowAvailableBooks()
        {
            foreach (var book in Books)
            {
                if (book.IsAvailable)
                    Console.WriteLine($"Available: {book.Title}");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            UserProfile u1 = new UserProfile { Username = "Alice", Password = "secret1", Email = "alice@mail.com" };
            UserProfile u2 = new UserProfile { Username = "Bob", Password = "123", Email = "bobmail.com" };
            u1.Display(); u2.Display();

            Truck t = new Truck { Make = "Tata", Model = "X1", Year = 2022 };
            Bus b = new Bus { Make = "Volvo", Model = "B9R", Year = 2020 };
            t.DisplayDetails(); b.DisplayDetails();

            Calculator c = new Calculator();
            Console.WriteLine(c.Add(5, 10));
            Console.WriteLine(c.Add(3.5f, 2.5f));
            Console.WriteLine(c.Add(7.2, 8.8));

            FullTimeEmployee fte = new FullTimeEmployee { Name = "John", MonthlySalary = 50000 };
            PartTimeEmployee pte = new PartTimeEmployee { Name = "Jane", HourlyRate = 200, HoursWorked = 100 };
            Console.WriteLine($"{fte.Name} Salary: {fte.CalculateSalary()}");
            Console.WriteLine($"{pte.Name} Salary: {pte.CalculateSalary()}");

            Student s1 = new Student();
            Student s2 = new Student("Rahul", 1);
            Student s3 = new Student("Priya", 2, 95);
            s1.Display(); s2.Display(); s3.Display();

            Product p1 = new Product { ProductID = 101, ProductName = "Laptop", Price = 50000, Quantity = 5 };
            Product p2 = new Product { ProductID = 102, ProductName = "Phone", Price = -1000, Quantity = 10 };
            p1.Display(); p2.Display();

            Library lib = new Library();
            Book book1 = new Book { Title = "C# Basics" };
            Book book2 = new Book { Title = "OOP Concepts" };
            lib.AddBook(book1); lib.AddBook(book2);

            Member m1 = new Member { Name = "Amit" };
            m1.BorrowBook(book1);
            m1.BorrowBook(book1);
            lib.ShowAvailableBooks();
        }
    }
}
