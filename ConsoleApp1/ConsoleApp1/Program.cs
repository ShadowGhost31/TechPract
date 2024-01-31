using System;

class Program
{
    static void Main()
    {     
        Console.Write("Введіть перше число: ");
        string input1 = Console.ReadLine();
      
        Console.Write("Введіть друге число: ");
        string input2 = Console.ReadLine();
        
        double number1, number2;
       
        if (double.TryParse(input1, out number1) && double.TryParse(input2, out number2))
        {            
            double sum = number1 + number2;           
            Console.WriteLine($"Сума чисел {number1} і {number2} дорівнює: {sum}");
        }
        else
        {         
            Console.WriteLine("Невірний формат введених чисел.");
        }
        Console.ReadLine();
    }
}
