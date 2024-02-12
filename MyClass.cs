using System;
using System.Linq;

namespace Theme18;

public class MyClass
{
    private double value1;
    private double value2;
    
    public static int count;

    static MyClass()
    {
        count = 0;
    }

    public MyClass(double val1, double val2)
    {
        this.value1 = val1;
        this.value2 = val2;
        count++;
    }

    public MyClass()
    {
        this.value1 = 2.0;
        this.value2 = 2.0;
        count++;
    }

    public double Value1
    {
        get { return value1; }
        set { value1 = value; }
    }

    public double Value2
    {
        get { return value2; }
        set { value2 = value; }
    }

    public void PrintValues()
    {
        Console.WriteLine($"Value1: {value1}, Value2: {value2}");
    }
}




