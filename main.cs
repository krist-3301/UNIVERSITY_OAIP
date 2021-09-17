using System;

public class A0
{
    private float 
                    a = 3.14f,
                    b = 1.61f; // поля класса

    public float C // свойство - деление
    {
        get { 
            a /= b; 
            return a;
        }
    }
}

public class A1
{
    private float 
                    a = 3.14f,
                    b = 1.61f; // поля класса

    public float C // свойство - декремент (постфиксный)
    {
        get { return a--; }
    }
}

public class A2
{
    private float 
                    a = 3.14f,
                    b = 1.61f; // поля класса

    public float C // свойство - умножение
    {
        get { return a*b; }
    }
}

public class Program
{
    public static void Main()
    {
        A0 a = new A0();
        A1 b = new A1();
        A2 c = new A2();

        Console.WriteLine(a.C);
        Console.WriteLine(b.C);
        Console.WriteLine(c.C); 
    }
}