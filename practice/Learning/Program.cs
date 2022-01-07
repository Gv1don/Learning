using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;

class HelloWorld
{
    static void Main()
    {
        int number;
        bool p = false;
        while (!p)
        {
            bool a = int.TryParse(Console.ReadLine(), out number);
            if (a == true)
            {
                p = true;

            }
            else
            {
                Console.WriteLine("Вы ввели не число!");
            }
        }

        string[] teams = { "Бавария", "Боруссия", "Реал Мадрид", "Манчестер Сити", "ПСЖ", "Барселона" };

        var selectedTeams = from t in teams // определяем каждый объект из teams как t
                            where t.ToUpper().StartsWith("Б") //фильтрация по критерию
                            orderby t  // упорядочиваем по возрастанию
                            select t; // выбираем объект

        foreach (string s in selectedTeams)
            Console.WriteLine(s);

        List<int> array = new List<int>();

        int[] arr = { 1, 2, 3, 4 };
        array.Add(32);
        array.Add(32);
        array.Add(32);
        array.Add(32);

        Dictionary<string, int> spisok = new Dictionary<string, int>();
        spisok.Add("WOW", 1939);

        foreach (var item in arr)
        {
            Console.WriteLine(item);
        }

        foreach (var item in array)
        {
            Console.WriteLine(item);
        }

        int b = Convert.ToInt32("32");

        Console.WriteLine(b);
        
        Console.WriteLine(Math.Sqrt(144));
        double o = 12.1;

        string q = o.ToString();

        Console.WriteLine(q);

        string f = "asdf";
        string g = "adfa";
        MyClass myclass = new MyClass();
        //myclass.Swap(ref a, ref b);
        myclass.Swap(ref f, ref g);
        Console.WriteLine(f);
        Console.WriteLine(g);
        int i = myclass.A;
        myclass.A = 20;
        Console.WriteLine(myclass.A);
        myclass.F();
        Son son = new Son();
        son.F();
        MyClass name = new Son();
        name.F();
        Console.ReadKey();
    }
}

public class MyClass
{
    public void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    private int a;

    public int A
    {
        get => a;
        set => _ = a;
    }

    public virtual void F()
    {
        Console.WriteLine("Hello");
    }

    public MyClass()
    {
        A = 0;
    }
}

public class Son : MyClass
{
    public Son()
    {
        
    }

    public override void F()
    {
        Console.WriteLine("Bay");
    }
}