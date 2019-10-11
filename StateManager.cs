using System;

public class StateManager
{

    private int x;
    private int y;

    private int decimalPosition;

    GetX getX = new GetX();
    GetY getY = new GetY();
    GetPosition getPosition = new GetPosition();

    public void ResetState()
    {
        x = 0;
        y = 0;
        decimalPosition = 0;
        // decimalValue = null;
        // decimalPositionValue = '\0';
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

    public void DivideXY()
    {
        int firstDecimal = x % y;
        int Remainder = 0;
        int result = 0;
        for (int i = 0; i < decimalPosition; i++)
        {
            if (i == 0)
            {
                Remainder = firstDecimal;
                Remainder *= 10;
                result = Remainder / y;
            }
            else
            {
                Remainder %= y;
                Remainder *= 10;
                result = Remainder / y;
            }
        }

        Console.WriteLine("the result is " + result);
    }

    public void PrintValue()
    {
        Console.WriteLine("X = " + x + ", Y = " + y + ", Decimal Position = " + decimalPosition);
    }
}