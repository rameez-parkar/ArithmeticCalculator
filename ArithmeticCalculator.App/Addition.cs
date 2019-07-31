namespace ArithmeticCalculator.App
{
    public class Addition : IOperation
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
            double addition = _firstOperand + _secondOperand;
            return addition;
        }
    }
}
