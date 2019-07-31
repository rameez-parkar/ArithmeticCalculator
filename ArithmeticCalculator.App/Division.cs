using System;

namespace ArithmeticCalculator.App
{
    public class Division : IOperation
    {
        private double _firstOperand;
        private double _secondOperand;

        void IOperation.AcceptOperands(double firstOperand, double secondOperand)
        {
            this._firstOperand = firstOperand;
            this._secondOperand = secondOperand;
        }

        double IOperation.PerformCalculation()
        {
            if (_secondOperand != 0)
            {
                double division = _firstOperand / _secondOperand;
                return division;
            }
            else
            {
                throw new DivideByZeroException();
            }
        }
    }
}
