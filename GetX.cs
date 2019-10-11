using System;

public class GetX
{
    private int X;
    public void GetXByInput()
    {
        Console.Write("Enter your X: ");
        string input = Console.ReadLine();
        int number = 0;

        if (int.TryParse(input, out number))
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

    public int GetXValue()
    {
        return X;
    }
}