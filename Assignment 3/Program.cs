using System;

// Instance Class
class Employee
{
    public string Name { get; set; }
    public int Age { get; set; }
    public double Salary { get; set; }

    public void DisplayEmployee()
    {
        Console.WriteLine($"Employee: {Name}, Age: {Age}, Salary: {Salary}");
    }
}

class BankAccount
{
    public int AccountNumber { get; set; }
    public string AccountHolder { get; set; }
    public double Balance { get; set; }

    public void Deposit(double amount)
    {
        Balance += amount;
    }

    public void Withdraw(double amount)
    {
        if (Balance >= amount)
            Balance -= amount;
        else
            Console.WriteLine("Insufficient Balance");
    }

    public void DisplayAccount()
    {
        Console.WriteLine($"Account: {AccountNumber}, Holder: {AccountHolder}, Balance: {Balance}");
    }
}

// Static Class
static class MathHelper
{
    public static double CalculateAverage(int[] arr)
    {
        double sum = 0;
        foreach (int num in arr)
            sum += num;
        return sum / arr.Length;
    }
}

static class Logger
{
    public static void LogMessage(string msg)
    {
        Console.WriteLine($"Log: {msg}");
    }
}

// Partial Class
partial class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}

partial class Person
{
    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}

partial class EmployeePartial
{
    public string Name { get; set; }
    public double BaseSalary { get; set; }
}

partial class EmployeePartial
{
    public void CalculateSalary(double bonus)
    {
        Console.WriteLine($"Salary of {Name}: {BaseSalary + bonus}");
    }
}

// Abstract Class
abstract class Shape
{
    public abstract double CalculateArea();
}

class Circle : Shape
{
    public double Radius { get; set; }
    public override double CalculateArea() => Math.PI * Radius * Radius;
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    public override double CalculateArea() => Width * Height;
}

abstract class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }
    public abstract void Speak();
}

class Dog : Animal
{
    public override void Speak() => Console.WriteLine($"{Name} the Dog barks.");
}

class Cat : Animal
{
    public override void Speak() => Console.WriteLine($"{Name} the Cat meows.");
}

// Sealed Class
class Vehicle
{
    public void StartEngine() => Console.WriteLine("Engine Started");
    public void StopEngine() => Console.WriteLine("Engine Stopped");
}

sealed class Car : Vehicle
{
    public void Drive() => Console.WriteLine("Car is driving");
}

class BankAccountBase
{
    public int AccountNumber { get; set; }
    public double Balance { get; set; }
}

sealed class SavingsAccount : BankAccountBase
{
    public void CalculateInterest(double rate)
    {
        double interest = Balance * rate / 100;
        Console.WriteLine($"Interest: {interest}");
    }
}

class Program
{
    static void Main()
    {
        Employee emp = new Employee { Name = "Alice", Age = 30, Salary = 50000 };
        emp.DisplayEmployee();

        BankAccount acc = new BankAccount { AccountNumber = 101, AccountHolder = "Bob", Balance = 1000 };
        acc.Deposit(500);
        acc.Withdraw(200);
        acc.DisplayAccount();

        int[] arr = { 10, 20, 30, 40 };
        Console.WriteLine("Average: " + MathHelper.CalculateAverage(arr));
        Logger.LogMessage("This is a test log");

        Person p = new Person { FirstName = "John", LastName = "Doe" };
        p.PrintFullName();

        EmployeePartial ep = new EmployeePartial { Name = "Emma", BaseSalary = 40000 };
        ep.CalculateSalary(5000);

        Circle c = new Circle { Radius = 5 };
        Console.WriteLine("Circle Area: " + c.CalculateArea());

        Rectangle r = new Rectangle { Width = 4, Height = 6 };
        Console.WriteLine("Rectangle Area: " + r.CalculateArea());

        Dog d = new Dog { Name = "Buddy", Age = 3 };
        d.Speak();

        Cat cat = new Cat { Name = "Kitty", Age = 2 };
        cat.Speak();

        Car car = new Car();
        car.StartEngine();
        car.Drive();
        car.StopEngine();

        SavingsAccount sa = new SavingsAccount { AccountNumber = 202, Balance = 5000 };
        sa.CalculateInterest(5);
    }
}
