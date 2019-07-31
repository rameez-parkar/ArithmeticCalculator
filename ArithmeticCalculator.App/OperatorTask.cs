namespace ArithmeticCalculator.App
{
    public class OperatorTask
    {
        private IOperation _operator;

        public OperatorTask(IOperation operatorTask)
        {
            _operator = operatorTask;
        }

        public IOperation GetOperation()
        {
            return _operator;
        }
    }
}
