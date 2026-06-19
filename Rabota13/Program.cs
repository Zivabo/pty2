using System.IO;
using System;
using System.Linq;
using System.Text.RegularExpressions;

//1.1
public class Animal
{
    public void MakeSound() => Console.WriteLine("Some sound");
}

//1.2
public class Car
{
    public string Brand;
    public string Model;
    public int Year;
}

//1.3
public class Person
{
    public string Name;
    public int Age;
}

//1.4
public class Rectangle
{
    public double SideA;
    public double SideB;
}

//1.5
public class StudentExample
{
    public string Name;
}

//1.6
public class Book
{
    public string Title;
    public string Author;
    public int Pages;
}

//1.7
public class Circle
{
    public double Radius;
}

//1.8
public class BankAccount
{
    public decimal Balance;
}

//1.9
public class Temperature
{
    public double Value;
}

//1.10
public class Time
{
    public int Hours;
    public int Minutes;
    public int Seconds;
}

//1.11
public class Point
{
    public int X;
    public int Y;
    public int Z;
}

//1.12
public class Color
{
    public int R;
    public int G;
    public int B;
}

//1.13
public class Email
{
    public string Address;
}

//1.14
public class PhoneNumber
{
    public string Number;
}

//1.15
public class URL
{
    public string WebAddress;
}

//2.1
public class Dog
{
    public string Name;
    public void Bark() => Console.WriteLine("Woof!");
}

//2.2
public class RectangleArea
{
    public double Width;
    public double Height;
    public double GetArea() => Width * Height;
}

//2.3
public class Triangle
{
    public double SideA;
    public double SideB;
    public double SideC;
}

//2.4
public class Employee
{
    public string Name;
    public decimal Salary;
}

//2.5
public class Product
{
    public string Name;
    public decimal Price;
    public int Quantity;
}

//2.6
public class Student
{
    public string Name;
    public int Age;
    public double GPA;
}

//2.7
public class House
{
    public int Rooms;
    public double Area;
}

//2.8
public class Account
{
    public string AccountNumber;
    public decimal Balance;
}

//2.9
public class Bicycle
{
    public int Gears;
}

//2.10
public class Computer
{
    public string CPU;
    public int RAM;
}

//2.11
public class Flower
{
    public string Name;
    public string Color;
}

//2.12
public class Laptop
{
    public double ScreenSize;
    public int BatteryLife;
}

//2.13
public class Pen
{
    public string Color;
    public double InkLevel;
}

//2.14
public class CoffeeCup
{
    public string Size;
    public string CoffeeType;
}

//2.15
public class BookWithInfo
{
    public string Title;
    public string Author;
}

//3.1
public class Calculator
{
    public int Add(int a, int b) => a + b;
}

//3.2
public class StringHelper
{
    public string Reverse(string s)
    {
        char[] arr = s.ToCharArray();
        Array.Reverse(arr);
        return new string(arr);
    }
}

//3.3
public class MathHelper
{
    public int Max(int a, int b) => a > b ? a : b;
}

//3.4
public class TemperatureConverter
{
    public double CelsiusToFahrenheit(double celsius) => celsius * 9 / 5 + 32;
}

//3.5
public class LengthConverter
{
    public double MetersToFeet(double meters) => meters * 3.28084;
    public double FeetToMeters(double feet) => feet / 3.28084;
}

//3.6
public class WeightConverter
{
    public double KgToPounds(double kg) => kg * 2.20462;
    public double PoundsToKg(double pounds) => pounds / 2.20462;
}

//3.7
public class ArrayHelper
{
    public int FindMax(int[] arr) => arr.Max();
}

//3.8
public class StringValidator
{
    public bool IsValidEmail(string email) => Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
}

//3.9
public class NumberChecker
{
    public bool IsPrime(int n)
    {
        if (n < 2) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }
}

//3.10
public class DateHelper
{
    public string GetDayOfWeek(DateTime date) => date.DayOfWeek.ToString();
}

//3.11
public class FileHelper
{
    public string ReadFile(string path) => File.ReadAllText(path);
}

//3.12
public class Logger
{
    public void Log(string message) => Console.WriteLine($"[LOG] {message}");
}

//3.13
public class Validator
{
    public bool IsValidPassword(string password) => password.Length >= 8 && password.Any(char.IsDigit);
}

//3.14
public class Formatter
{
    public string ToUpper(string text) => text.ToUpper();
}

//3.15
public class Counter
{
    private int _count;
    public void Increment() => _count++;
    public void Decrement() => _count--;
    public int GetCount() => _count;
}

//4.1
public class PersonProperty
{
    public string Name { get; set; }
}

//4.2
public class StudentProperty
{
    public double GPA { get; set; }
}

//4.3
public class BankAccountProperty
{
    public decimal Balance { get; set; }
}

//4.4
public class ProductProperty
{
    public decimal Price { get; set; }
}

//4.5
public class CarProperty
{
    public int Speed { get; set; }
}

//4.6
public class TemperatureProperty
{
    public double Celsius { get; set; }
}

//4.7
public class RectangleProperty
{
    public double Width { get; set; }
    public double Height { get; set; }
}

//4.8
public class CircleProperty
{
    public double Radius { get; set; }
}

//4.9
public class EmployeeProperty
{
    public decimal Salary { get; set; }
}

//4.10
public class BookProperty
{
    public string Title { get; set; }
    public string Author { get; set; }
}

//4.11
public class HouseProperty
{
    public double Area { get; set; }
}

//4.12
public class ComputerProperty
{
    public int RAM { get; set; }
}

//4.13
public class AccountProperty
{
    public string Username { get; set; }
}

//4.14
public class VehicleProperty
{
    public string Brand { get; set; }
}

//4.15
public class ColorProperty
{
    public int Red { get; set; }
    public int Green { get; set; }
    public int Blue { get; set; }
}

//5.1
public class PersonReadOnly
{
    public int Age { get; }
    public PersonReadOnly(int age) => Age = age;
}

//5.2
public class StudentReadOnly
{
    public int ID { get; }
    public StudentReadOnly(int id) => ID = id;
}

//5.3
public class BankAccountReadOnly
{
    public string AccountNumber { get; }
    public BankAccountReadOnly(string number) => AccountNumber = number;
}

//5.4
public class ProductReadOnly
{
    public string Code { get; }
    public ProductReadOnly(string code) => Code = code;
}

//5.5
public class EmployeeReadOnly
{
    public int EmployeeID { get; }
    public EmployeeReadOnly(int id) => EmployeeID = id;
}

//5.6
public class CarReadOnly
{
    public string VIN { get; }
    public CarReadOnly(string vin) => VIN = vin;
}

//5.7
public class HouseReadOnly
{
    public string Address { get; }
    public HouseReadOnly(string address) => Address = address;
}

//5.8
public class BookReadOnly
{
    public string ISBN { get; }
    public BookReadOnly(string isbn) => ISBN = isbn;
}

//5.9
public class ComputerReadOnly
{
    public string SerialNumber { get; }
    public ComputerReadOnly(string serial) => SerialNumber = serial;
}

//5.10
public class DocumentReadOnly
{
    public DateTime CreatedDate { get; }
    public DocumentReadOnly(DateTime date) => CreatedDate = date;
}

//5.11
public class OrderReadOnly
{
    public int OrderID { get; }
    public OrderReadOnly(int id) => OrderID = id;
}

//5.12
public class InvoiceReadOnly
{
    public string InvoiceNumber { get; }
    public InvoiceReadOnly(string number) => InvoiceNumber = number;
}

//5.13
public class UserReadOnly
{
    public string UID { get; }
    public UserReadOnly(string uid) => UID = uid;
}

//5.14
public class DeviceReadOnly
{
    public string MAC { get; }
    public DeviceReadOnly(string mac) => MAC = mac;
}

//5.15
public class TicketReadOnly
{
    public string TicketNumber { get; }
    public TicketReadOnly(string number) => TicketNumber = number;
}

//6.1
public class UserWriteOnly
{
    private string _password;
    public string Password { set => _password = value; }
}

//6.2
public class BankAccountWriteOnly
{
    private string _pin;
    public string PIN { set => _pin = value; }
}

//6.3
public class SecureDocumentWriteOnly
{
    private string _key;
    public string EncryptionKey { set => _key = value; }
}

//6.4
public class AccountWriteOnly
{
    private string _token;
    public string Token { set => _token = value; }
}

//6.5
public class LoggerWriteOnly
{
    private string _apiKey;
    public string ApiKey { set => _apiKey = value; }
}

//6.6
public class EmailServiceWriteOnly
{
    private string _smtpPassword;
    public string SMTPPassword { set => _smtpPassword = value; }
}

//6.7
public class SecureConnectionWriteOnly
{
    private string _connString;
    public string ConnectionString { set => _connString = value; }
}

//6.8
public class AuthenticatorWriteOnly
{
    private string _secret;
    public string Secret { set => _secret = value; }
}

//6.9
public class PaymentServiceWriteOnly
{
    private string _creditCard;
    public string CreditCard { set => _creditCard = value; }
}

//6.10
public class VPNClientWriteOnly
{
    private string _vpnPassword;
    public string VPNPassword { set => _vpnPassword = value; }
}

//7.1
public class PersonConstructor
{
    public string Name;
    public int Age;
    public PersonConstructor(string name, int age) => (Name, Age) = (name, age);
}

//7.2
public class StudentConstructor
{
    public int ID;
    public string Name;
    public StudentConstructor(int id, string name) => (ID, Name) = (id, name);
}

//7.3
public class RectangleConstructor
{
    public double Length;
    public double Width;
    public RectangleConstructor(double length, double width) => (Length, Width) = (length, width);
}

//7.4
public class CircleConstructor
{
    public double Radius;
    public CircleConstructor(double radius) => Radius = radius;
}

//7.5
public class BankAccountConstructor
{
    public string AccountNumber;
    public decimal Balance;
    public BankAccountConstructor(string number, decimal balance) => (AccountNumber, Balance) = (number, balance);
}

//7.6
public class CarConstructor
{
    public string Brand;
    public string Model;
    public int Year;
    public CarConstructor(string brand, string model, int year) => (Brand, Model, Year) = (brand, model, year);
}

//7.7
public class BookConstructor
{
    public string Title;
    public string Author;
    public int Pages;
    public BookConstructor(string title, string author, int pages) => (Title, Author, Pages) = (title, author, pages);
}

//7.8
public class EmployeeConstructor
{
    public string Name;
    public decimal Salary;
    public EmployeeConstructor(string name, decimal salary) => (Name, Salary) = (name, salary);
}

//7.9
public class ProductConstructor
{
    public string Name;
    public decimal Price;
    public ProductConstructor(string name, decimal price) => (Name, Price) = (name, price);
}

//7.10
public class HouseConstructor
{
    public string Address;
    public int Rooms;
    public HouseConstructor(string address, int rooms) => (Address, Rooms) = (address, rooms);
}

//7.11
public class TriangleConstructor
{
    public double SideA;
    public double SideB;
    public double SideC;
    public TriangleConstructor(double a, double b, double c) => (SideA, SideB, SideC) = (a, b, c);
}

//7.12
public class TimeConstructor
{
    public int Hours;
    public int Minutes;
    public int Seconds;
    public TimeConstructor(int h, int m, int s) => (Hours, Minutes, Seconds) = (h, m, s);
}

//7.13
public class TemperatureConstructor
{
    public double Celsius;
    public TemperatureConstructor(double celsius) => Celsius = celsius;
}

//7.14
public class ColorConstructor
{
    public int R;
    public int G;
    public int B;
    public ColorConstructor(int r, int g, int b) => (R, G, B) = (r, g, b);
}

//7.15
public class PointConstructor
{
    public int X;
    public int Y;
    public PointConstructor(int x, int y) => (X, Y) = (x, y);
}