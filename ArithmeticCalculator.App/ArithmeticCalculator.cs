namespace ArithmeticCalculator.App
{
    public class Calculator
    {
        private OperatorFactory _operatorFactory = new OperatorFactory();
        private OperatorTask _operatorTask;

        public IOperation SetOperation(string operation)
        {
            _operatorTask = new OperatorTask(_operatorFactory.GetOperator(operation));
            return _operatorTask.GetOperation();
        }
    }
}
