using System;

public class StateManager
{

    private decimal x;
    private decimal y;
    private decimal dividedValue;
    private int decimalPosition;
    private string decimalValue;
    private char decimalPositionValue;

    GetX getX = new GetX();
    GetY getY = new GetY();
    GetPosition getPosition = new GetPosition();


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
        getX.GetXByInput();
        x = getX.GetXValue();

        getY.GetYByInput();
        y = getY.GetYValue();

        getPosition.GetDecimalPositionInput();
        decimalPosition = getPosition.GetDecimalPosition();

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
            IsTryAgain();
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