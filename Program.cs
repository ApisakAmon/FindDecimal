using System;

namespace FindDecimal
{
    class Program
    {
        static void Main(string[] args)
        {
            GetValue getValue = new GetValue();
            getValue.GetX();
            getValue.GetY();
            getValue.GetPosition();
            getValue.PrintValue();
            getValue.DivideXY();
            getValue.GetDecimalValue();
            getValue.GetDecimalPositionValue();
        }
    }
}
