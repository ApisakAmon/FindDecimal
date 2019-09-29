using System;

public class Function
{

    private decimal x;
    private decimal y;
    private decimal dividedValue;
    private int decimalPosition;
    private string decimalValue;
    private char decimalPositionValue;

    public void ResetState()
    {
        x = 0;
        y = 0;
        dividedValue = 0;
        decimalPosition = 0;
        decimalValue = null;
        decimalPositionValue = '\0';
    }

    public void StartActionSequence()
    {
        GetX();
        GetY();
        GetPosition();
        PrintValue();
        DivideXY();
        GetDecimalValue();
        GetDecimalPositionValue();
        IsTryAgain();
    }



    public void IsTryAgain()
    {
        Console.WriteLine("Do you want to try again? [YES,NO]");
        string input = Console.ReadLine();
        input = input.ToUpper();

        if (input == "YES")
        {
            ResetState();
            StartActionSequence();
        }
        else if (input == "NO")
        {
            return;
        }
        else
        {
            Console.WriteLine("Please Type only [YES,NO]");
            IsTryAgain();        }

    }

    public void GetX()
    {
        Console.Write("Enter your X: ");
        string input = Console.ReadLine();
        decimal number = 0;

        if (decimal.TryParse(input, out number))
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

    public void GetY()
    {
        Console.Write("Enter your Y: ");
        string input = Console.ReadLine();
        decimal number = 0;

        if (decimal.TryParse(input, out number))
        {
            y = number;
            Console.WriteLine("Your X is " + y);
        }
        else
        {
            Console.WriteLine("Your X is not a number. Please input only 0-9");
            GetY();
        }
    }

    public void GetPosition()
    {
        Console.Write("Enter your decimal position: ");
        string input = Console.ReadLine();
        int number = 0;

        if (Int32.TryParse(input, out number))
        {
            decimalPosition = number;
            Console.WriteLine("Your Y is " + decimalPosition);
        }
        else
        {
            Console.WriteLine("Your decimal position is not a number. Please input only 0-9");
            GetY();
        }
    }

    public void GetDecimalValue()
    {
        Console.WriteLine(decimalValue);
        string strDecimal = dividedValue.ToString();
        var regex = new System.Text.RegularExpressions.Regex("(?<=[\\.])[0-9]+");
        if (regex.IsMatch(strDecimal))
        {
            decimalValue = regex.Match(strDecimal).Value;
        }
    }

    public void GetDecimalPositionValue()
    {
        char first = decimalValue[decimalPosition - 1];
        decimalPositionValue = first;
        Console.WriteLine("Decimal value in " + decimalPosition + " position is " + decimalPositionValue);

    }

    public void DivideXY()
    {
        decimal value;
        value = x / y;
        dividedValue = value;
        Console.WriteLine("X/Y = " + dividedValue);
    }



    public void PrintValue()
    {
        Console.WriteLine("X = " + x + ", Y = " + y + ", Decimal Position = " + decimalPosition);
    }
}