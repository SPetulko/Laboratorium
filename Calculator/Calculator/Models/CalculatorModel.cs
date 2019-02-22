using System;
using System.Globalization;

namespace Calculator.Models
{
    public class CalculatorModel
    {
        public string Display { get; set; }
        public bool shouldClearDisplay;
        public string FirstOperand { get; set; }
        public string SecondOperand { get; set; }
        public string Operation { get; set; }
        public string LastOperation { get; set; }
        public bool isDisabled;
        private string _result;

        public CalculatorModel()
        {
            Clear();
        }

        public void Clear()
        {
            Display = "0";
            shouldClearDisplay = false;
            isDisabled = false;
            _result = string.Empty;
            LastOperation = string.Empty;
            Reset();
        }

        private void Reset()
        {
            FirstOperand = string.Empty;
            SecondOperand = string.Empty;
            Operation = string.Empty;
        }

        public void Process(string button)
        {
            switch (button)
            {
                case "+/-":
                    if (Display == "0")
                        break;
                    else if (Display.Contains("-"))
                    {
                        Display = Display.Remove(Display.IndexOf("-"), 1);
                    }
                    else
                        Display = "-" + Display;
                    break;

                case ".":
                    var c = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator;
                    if (Display == "0")
                        Display = "0" + c;
                    else
                    {
                        if (!Display.Contains(c))
                            Display = Display + c;
                    }
                    break;

                case "C":
                    Clear();
                    break;

                default:
                    if (Display == "0" || shouldClearDisplay)
                        Display = button;
                    else
                        Display = Display + button;
                    break;
            }
            if (button != ".")
                shouldClearDisplay = false;
        }

        public void ProcessOperation(string operation)
        {
            if (FirstOperand == string.Empty || (shouldClearDisplay && LastOperation != "="))
            {
                FirstOperand = Display;
                LastOperation = operation;
                shouldClearDisplay = true;
            }
            else
            {
                SecondOperand = Display;
                Operation = LastOperation;
                CalculateResult();
                LastOperation = operation;
                FirstOperand = _result;
                shouldClearDisplay = true;
            }
            if (operation == "=")
                Reset();
            else if (operation == "sqrt")
            {
                FirstOperand = Display;
                Operation = operation;
                CalculateResult();
                LastOperation = operation;
                FirstOperand = string.Empty;
                shouldClearDisplay = true;
            }
        }

        private void CalculateResult()
        {
            double result;
            switch (Operation)
            {
                case ("+"):
                    result = Convert.ToDouble(FirstOperand) + Convert.ToDouble(SecondOperand);
                    break;

                case ("-"):
                    result = Convert.ToDouble(FirstOperand) - Convert.ToDouble(SecondOperand);
                    break;

                case ("*"):
                    result = Convert.ToDouble(FirstOperand) * Convert.ToDouble(SecondOperand);
                    break;

                case ("/"):
                    result = Convert.ToDouble(FirstOperand) / Convert.ToDouble(SecondOperand);
                    break;

                case ("sqrt"):
                    result = Math.Sqrt(Convert.ToDouble(FirstOperand));
                    break;

                case ("%"):
                    result = Convert.ToDouble(FirstOperand) * Convert.ToDouble(SecondOperand) / 100;
                    break;

                default:
                    result = Double.NaN;
                    break;
            }
            _result = result.ToString();
            Display = _result;
            if (Double.IsNaN(result) || Double.IsNegativeInfinity(result) || Double.IsPositiveInfinity(result))
            {
                isDisabled = true;
                Display = "ERR";
            }
        }
    }
}