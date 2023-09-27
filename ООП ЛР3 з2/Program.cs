using System;

class Parent
{
    protected double Pole1;
    protected double Pole2;

    public Parent()
    {
        Pole1 = 0;
        Pole2 = 0;
    }

    public Parent(double pole1, double pole2)
    {
        Pole1 = pole1;
        Pole2 = pole2;
    }

    public void Print()
    {
        Console.WriteLine("Довжина першої пiвосi: " + Pole1.ToString("0.00"));
        Console.WriteLine("Довжина другої пiвосi: " + Pole2.ToString("0.00"));
    }

    public double Metod1()
    {
        return Math.PI * Pole1 * Pole2;
    }

    public double Metod2()
    {
        return 2 * Math.PI * Math.Sqrt((Pole1 * Pole1 + Pole2 * Pole2) / 2);
    }
}

class Child : Parent
{
    public Child(double radius) : base(radius, radius)
    {
    }

    public double Metod3()
    {
        return Pole1 * Pole1;
    }

    public double Metod4()
    {
        return 4 * Pole1;
    }
}

class Program
{
    static void Main()
    {
        Random random = new Random();
        for (int i = 0; i < 5; i++)
        {
            double axis1 = random.Next(1, 800);
            double axis2 = random.Next(1, 10);

            if (axis1 != axis2)
            {
                Parent parent = new Parent(axis1, axis2);
                Console.WriteLine("Елiпс:");
                parent.Print();
                Console.WriteLine("Площа: " + parent.Metod1().ToString("0.00"));
                Console.WriteLine("Довжина лiнiї: " + parent.Metod2().ToString("0.00"));
            }
            else
            {
                Child child = new Child(axis1);
                Console.WriteLine("Коло:");
                child.Print();
                Console.WriteLine("Площа: " + child.Metod1().ToString("0.00"));
                Console.WriteLine("Довжина лiнiї: " + child.Metod2().ToString("0.00"));
                Console.WriteLine("Площа вписаного квадрата: " + child.Metod3().ToString("0.00"));
                Console.WriteLine("Периметр вписаного квадрата: " + child.Metod4().ToString("0.00"));
            }

            Console.WriteLine();
        }
    }
}