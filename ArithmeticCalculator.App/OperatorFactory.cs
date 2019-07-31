using System;

namespace ArithmeticCalculator.App
{
    public class OperatorFactory
    {
        public IOperation GetOperator(string operatorType)
        {
            switch(operatorType.ToLowerInvariant())
            {
                case "add":
                    return new Addition();
                case "subtract":
                    return new Subtraction();
                case "multiply":
                    return new Multiplication();
                case "divide":
                    return new Division();
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}
