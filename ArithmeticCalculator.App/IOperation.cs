namespace ArithmeticCalculator.App
{
    public interface IOperation
    {
        void AcceptOperands(double firstOperand, double secondOperand);
        double PerformCalculation();
    }
}
