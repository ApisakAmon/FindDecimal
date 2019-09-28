using System;

public class GetValue
{

    private int x;
    private int y;

    public void GetX()
    {
        Console.Write("Enter your X: ");
        string input = Console.ReadLine();
        int number = 0;

        if (Int32.TryParse(input, out number))
        {
                x = number;
                Console.WriteLine("Your X is " + x);
        }
        else
        {
            Console.WriteLine("Your X is not a number. Please input only 0-9");
            GetX();
        }
    }
}