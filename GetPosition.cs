using System;

public class GetPosition
{
    private int decimalPosition;
    public void GetDecimalPositionInput()
    {
        Console.Write("Enter your decimal position: ");
        string input = Console.ReadLine();
        int number = 0;

        if (Int32.TryParse(input, out number))
        {
            decimalPosition = number;
            Console.WriteLine("Your decimal position is " + decimalPosition);
        }
        else
        {
            Console.WriteLine("Your decimal position is not a number. Please input only 0-9");
            GetDecimalPositionInput();
        }
    }

    public int GetDecimalPosition()
    {
        return decimalPosition;
    }
}