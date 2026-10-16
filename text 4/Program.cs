using System;
using System.Collections.Generic;


//1
/*class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    private bool isAvailable = true;
    public bool IsAvailable => isAvailable;

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine($"'{Title}' götürüldü.");
        }
        else
        {
            Console.WriteLine($"'{Title}' artıq götürülüb!");
        }
    }

    public void ReturnBook()
    {
        isAvailable = true;
        Console.WriteLine($"'{Title}' geri qaytarıldı.");
    }

    public void DisplayInfo()
    {
        string status = isAvailable ? "Mövcud" : "Götürülüb";
        Console.WriteLine($"  [{status}] {Title} — {Author}");
    }
}

class Program
{
    static void Main()
    {
        List<Book> library = new List<Book>
        {
            new Book("1984",            "George Orwell",  "ISBN-001"),
            new Book("Eli ve Nino",     "Qurban Seid",    "ISBN-002"),
            new Book("Cinayet ve Ceza", "Dostoyevski",    "ISBN-003"),
            new Book("Balaca Şahzade",  "Sent-Ekzüperi",  "ISBN-004"),
            new Book("Xemse",           "Nizami Gencevi", "ISBN-005"),
        };

        Console.WriteLine("KİTABXANA SİSTEMİ");

        while (true)
        {
            Console.WriteLine("\n1 - Kitabları göster");
            Console.WriteLine("2 - Kitab götür");
            Console.WriteLine("3 - Kitab qaytar");
            Console.WriteLine("0 - Çıx");
            Console.Write("Seçiminizi daxil edin: ");

            string secim = Console.ReadLine();

            if (secim == "0") break;

            else if (secim == "1")
            {
                foreach (Book b in library)
                    b.DisplayInfo();
            }

            else if (secim == "2")
            {
                Console.Write("Kitab adını yazın: ");
                string ad = Console.ReadLine(); 

                Book tapildi = library.Find(b => b.Title == ad);

                if (tapildi != null)
                    tapildi.BorrowBook();
                else
                    Console.WriteLine("Bele kitab tapılmadı!");
            }

            else if (secim == "3")
            {
                Console.Write("Geri qaytarılacaq kitabın adını yazın: ");
                string ad = Console.ReadLine();

                Book tapildi = library.Find(b => b.Title == ad);

                if (tapildi != null)
                    tapildi.ReturnBook();
                else
                    Console.WriteLine("Belə kitab tapılmadı!");
            }
        }

        Console.WriteLine("Bitdi");
    }
}*/




//2
/*interface IShape
{
    double CalculateArea();      
    double CalculatePerimeter(); 
    string Name { get; }          
}

class Circle : IShape
{
    private double radius; 

    public string Name => "Daire";

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius; 
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : IShape
{
    private double width;
    private double height; 

    public string Name => "Düzbucaqlı";

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double CalculateArea()
    {
        return width * height; 
    }

    public double CalculatePerimeter()
    {
        return 2 * (width + height); 
    }
}

class Triangle : IShape
{
    private double a, b, c;

    public string Name => "Üçbucaq";

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double CalculateArea()
    {
        double s = (a + b + c) / 2;           
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public double CalculatePerimeter()
    {
        return a + b + c; 
    }
}

class ShapeHelper
{
    public double CalculateArea(double radius)
    {
        Console.WriteLine("  [ShapeHelper] Daire sahesi hesablandı");
        return Math.PI * radius * radius;
    }

    public double CalculateArea(double width, double height)
    {
        Console.WriteLine("  [ShapeHelper] Düzbucaqlı sahesi hesablandı");
        return width * height;
    }
}
class Program
{
    static void Main()
    {
        List<IShape> shapes = new List<IShape>
        {
            new Circle(5),       
            new Rectangle(4, 6),    
            new Triangle(3, 4, 5)    
        };

        Console.WriteLine("Fiqurlarin Sahesi");
        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"\n {shape.Name}");
            Console.WriteLine($"   Sahe      : {shape.CalculateArea():F2}");
            Console.WriteLine($"   Perimetr  : {shape.CalculatePerimeter():F2}");
        }

        Console.WriteLine("Daire Sahesi");

        ShapeHelper helper = new ShapeHelper();

        double area1 = helper.CalculateArea(5);     
        Console.WriteLine($"  Sahə: {area1:F2}\n");

        double area2 = helper.CalculateArea(4, 6);
        Console.WriteLine($"  Sahə: {area2:F2}");
    }
}*/

//3
using System;
using System.Collections.Generic;

//1
/*class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

    private bool isAvailable = true;
    public bool IsAvailable => isAvailable;

    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

    public void BorrowBook()
    {
        if (isAvailable)
        {
            isAvailable = false;
            Console.WriteLine($"'{Title}' götürüldü.");
        }
        else
        {
            Console.WriteLine($"'{Title}' artıq götürülüb!");
        }
    }

    public void ReturnBook()
    {
        isAvailable = true;
        Console.WriteLine($"'{Title}' geri qaytarıldı.");
    }

    public void DisplayInfo()
    {
        string status = isAvailable ? "Mövcud" : "Götürülüb";
        Console.WriteLine($"  [{status}] {Title} — {Author}");
    }
}

class Program
{
    static void Main()
    {
        List<Book> library = new List<Book>
        {
            new Book("1984",            "George Orwell",  "ISBN-001"),
            new Book("Eli ve Nino",     "Qurban Seid",    "ISBN-002"),
            new Book("Cinayet ve Ceza", "Dostoyevski",    "ISBN-003"),
            new Book("Balaca Şahzade",  "Sent-Ekzüperi",  "ISBN-004"),
            new Book("Xemse",           "Nizami Gencevi", "ISBN-005"),
        };

        Console.WriteLine("KİTABXANA SİSTEMİ");

        while (true)
        {
            Console.WriteLine("\n1 - Kitabları göster");
            Console.WriteLine("2 - Kitab götür");
            Console.WriteLine("3 - Kitab qaytar");
            Console.WriteLine("0 - Çıx");
            Console.Write("Seçiminizi daxil edin: ");

            string secim = Console.ReadLine();

            if (secim == "0") break;

            else if (secim == "1")
            {
                foreach (Book b in library)
                    b.DisplayInfo();
            }

            else if (secim == "2")
            {
                Console.Write("Kitab adını yazın: ");
                string ad = Console.ReadLine();

                Book tapildi = library.Find(b => b.Title.ToLower() == ad.ToLower());

                if (tapildi != null)
                    tapildi.BorrowBook();
                else
                    Console.WriteLine("Bele kitab tapılmadı!");
            }

            else if (secim == "3")
            {
                Console.Write("Geri qaytarılacaq kitabın adını yazın: ");
                string ad = Console.ReadLine();

                Book tapildi = library.Find(b => b.Title.ToLower() == ad.ToLower());

                if (tapildi != null)
                    tapildi.ReturnBook();
                else
                    Console.WriteLine("Belə kitab tapılmadı!");
            }
        }

        Console.WriteLine("Bitdi");
    }
}*/


//2
/*interface IShape
{
    double CalculateArea();
    double CalculatePerimeter();
    string Name { get; }
}

class Circle : IShape
{
    private double radius;
    public string Name => "Daire";

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * radius * radius;
    }

    public double CalculatePerimeter()
    {
        return 2 * Math.PI * radius;
    }
}

class Rectangle : IShape
{
    private double width;
    private double height;
    public string Name => "Düzbucaqlı";

    public Rectangle(double width, double height)
    {
        this.width = width;
        this.height = height;
    }

    public double CalculateArea()
    {
        return width * height;
    }

    public double CalculatePerimeter()
    {
        return 2 * (width + height);
    }
}

class Triangle : IShape
{
    private double a, b, c;
    public string Name => "Üçbucaq";

    public Triangle(double a, double b, double c)
    {
        this.a = a;
        this.b = b;
        this.c = c;
    }

    public double CalculateArea()
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    public double CalculatePerimeter()
    {
        return a + b + c;
    }
}

class ShapeHelper
{
    public double CalculateArea(double radius)
    {
        Console.WriteLine("  [ShapeHelper] Daire sahesi hesablandı");
        return Math.PI * radius * radius;
    }

    public double CalculateArea(double width, double height)
    {
        Console.WriteLine("  [ShapeHelper] Düzbucaqlı sahesi hesablandı");
        return width * height;
    }
}

class Program
{
    static void Main()
    {
        List<IShape> shapes = new List<IShape>
        {
            new Circle(5),
            new Rectangle(4, 6),
            new Triangle(3, 4, 5)
        };

        Console.WriteLine("Fiqurlarin Sahesi");
        foreach (IShape shape in shapes)
        {
            Console.WriteLine($"\n {shape.Name}");
            Console.WriteLine($"   Sahe      : {shape.CalculateArea():F2}");
            Console.WriteLine($"   Perimetr  : {shape.CalculatePerimeter():F2}");
        }

        Console.WriteLine("\nDaire Sahesi");
        ShapeHelper helper = new ShapeHelper();

        double area1 = helper.CalculateArea(5);
        Console.WriteLine($"  Sahə: {area1:F2}\n");

        double area2 = helper.CalculateArea(4, 6);
        Console.WriteLine($"  Sahə: {area2:F2}");
    }
}*/


//3
/*class Vehicle
{
    public string Brand { get; set; }
    public int Speed { get; set; }

    public Vehicle(string brand, int speed)
    {
        Brand = brand;
        Speed = speed;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("Nəqliyyat vasitəsi səs çıxarır...");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Marka: {Brand}  Süret: {Speed} km/h");
    }
}

class Car : Vehicle
{
    public Car(string brand, int speed) : base(brand, speed) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Brand} avtomobili: Bip bip!");
    }
}

class Motorcycle : Vehicle
{
    public Motorcycle(string brand, int speed) : base(brand, speed) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Brand} motosikleti: Vroom vroom!");
    }
}

class Bicycle : Vehicle
{
    public Bicycle(string brand, int speed) : base(brand, speed) { }

    public override void MakeSound()
    {
        Console.WriteLine($"{Brand} velosipedi: Zeng zeng!");
    }
}

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("BMW", 250),
            new Motorcycle("Honda", 180),
            new Bicycle("Trek", 30)
        };

        Console.WriteLine("NEQLİYYAT VASİTELERİ\n");

        foreach (Vehicle v in vehicles)
        {
            v.DisplayInfo();
            v.MakeSound();
            Console.WriteLine();
        }
    }
}*/


//4
abstract class Employee
{
    private double baseSalary;

    public string Name { get; set; }

    public Employee(string name, double baseSalary)
    {
        Name = name;
        this.baseSalary = baseSalary;
    }
    public double GetSalary()
    {
        return baseSalary;
    }
    public void SetSalary(double newSalary)
    {
        if (newSalary > 0)
            baseSalary = newSalary;
        else
            Console.WriteLine("Maaş mənfi ola bilməz!");
    }
    public abstract double CalculateBonus();
    public void DisplayInfo()
    {
        double bonus = CalculateBonus();
        double totalSalary = GetSalary() + bonus;

        Console.WriteLine($"Ad       : {Name}");
        Console.WriteLine($"Esas Maaş: {GetSalary()} AZN");
        Console.WriteLine($"Bonus    : {bonus} AZN");
        Console.WriteLine($"Ümumi    : {totalSalary} AZN");
        Console.WriteLine();
    }
}
class Manager : Employee
{
    public Manager(string name, double baseSalary)
        : base(name, baseSalary) { }

    public override double CalculateBonus()
    {
        return GetSalary() * 0.20; 
    }
}

class Intern : Employee
{
    public Intern(string name, double baseSalary)
        : base(name, baseSalary) { }

    public override double CalculateBonus()
    {
        return 100; 
    }
}
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new Manager("Anar Hesenov",  3000),
            new Manager("Leyla Memmedova", 4500),
            new Intern ("Rauf Eliyev",   800),
            new Intern ("Gülnar Qasımova", 700)
        };

        Console.WriteLine("İŞÇİ MAAŞ SİSTEMİ\n");

        foreach (Employee emp in employees)
        {
            emp.DisplayInfo();
        }
    }
}




