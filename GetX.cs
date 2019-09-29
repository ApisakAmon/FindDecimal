using System;

public class GetX
{
    private decimal X;
    public void GetXByInput()
    {
        Console.Write("Enter your X: ");
        string input = Console.ReadLine();
        decimal number = 0;

        if (decimal.TryParse(input, out number))
        {
            X = number;
            Console.WriteLine("Your X is " + X);
        }
        else
        {
            Console.WriteLine("Your X is not a number. Please input only 0-9");
            GetXByInput();
        }
    }

    public decimal GetXValue()
    {
        return X;
    }
}