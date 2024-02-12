using System;
using System.Linq;

namespace Themes18;

public static class Program
{
	public static void Main()
	{
    MyClass obj1 = new MyClass(3.0, 4.0);
    MyClass obj2 = new MyClass();
    MyClass obj3 = new MyClass(5.0, 6.0);

Console.WriteLine($"Количество созданных экземпляров:: {MyClass.count}");

obj1.PrintValues();
obj2.PrintValues();
obj3.PrintValues();

	}
}
