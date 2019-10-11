using System;

public class GetY
{
    private int Y;
    public void GetYByInput()
    {
        Console.Write("Enter your Y: ");
        string input = Console.ReadLine();
        int number = 0;

        if (int.TryParse(input, out number))
        {
            Y = number;
            Console.WriteLine("Your Y is " + Y);
        }
        else
        {
            Console.WriteLine("Your X is not a number. Please input only 0-9");
            GetYByInput();
        }
    }

    public int GetYValue()
    {
        return Y;
    }
}