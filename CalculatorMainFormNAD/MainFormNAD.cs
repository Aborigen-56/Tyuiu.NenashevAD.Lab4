using OrdinaryCalc.Lib;
using ArithmeticCalc.Lib;
using ConversionCalc.Lib;
using FitnessCalc.Lib;

namespace CalculatorMainFormNAD
{
    public partial class MainFormNAD : Form
    {
        private double FirstValue;
        private string currentOperation;
        private OrdinaryCalcLib calculator;
        private ArithmeticCalcLib arifmetic_calculator;
        private Stack<double> valuesStack;
        private Stack<string> operationsStack;

        public MainFormNAD()
        {
            InitializeComponent();
            calculator = new OrdinaryCalcLib();
            arifmetic_calculator = new ArithmeticCalcLib();
            valuesStack = new Stack<double>();
            operationsStack = new Stack<string>();

            this.Size = new Size(400, 600);
            for (int i = 5; i < tableLayoutPanelChooseFunctionNAD.ColumnCount; i++)
            {
                tableLayoutPanelChooseFunctionNAD.ColumnStyles[i].SizeType = SizeType.Absolute;
                tableLayoutPanelChooseFunctionNAD.ColumnStyles[i].Width = 0;
            }
        }

        private void AppendDigit(string digit)
        {
            if (textBoxShowResultNAD.Text == "0" && digit != ",")
            {
                textBoxShowResultNAD.Text = digit;
            }
            else
            {
                textBoxShowResultNAD.Text += digit;
            }
        }

        private void buttonNumberZeroNAD_Click(object sender, EventArgs e)
        {
            AppendDigit("0");
        }

        private void buttonNumberOneNAD_Click(object sender, EventArgs e)
        {
            AppendDigit("1");
        }

        private void buttonNumberTwoNAD_Click(object sender, EventArgs e)
        {
            AppendDigit("2");
        }

        private void buttonNumberThreeNAD_Click(object sender, EventArgs e)
        {
            AppendDigit("3");
        }

        private void buttonNumberFourNAD_Click(object sender, EventArgs e)
        {
            AppendDigit("4");
        }

        private void buttonNumberFiveNAD_Click(object sender, EventArgs e)
        {
            AppendDigit("5");
        }

        private void buttonNumberSixNAD_Click(object sender, EventArgs e)
        {
            AppendDigit("6");
        }

        private void buttonNumberSevenNAD_Click(object sender, EventArgs e)
        {
            AppendDigit("7");
        }

        private void buttonNumberEightNAD_Click(object sender, EventArgs e)
        {
            AppendDigit("8");
        }

        private void buttonNumberNineNAD_Click(object sender, EventArgs e)
        {
            AppendDigit("9");
        }

        private void buttonSymbolPointNAD_Click(object sender, EventArgs e)
        {
            if (!textBoxShowResultNAD.Text.Contains(","))
            {
                textBoxShowResultNAD.Text += ",";
            }
        }

        private void buttonOperationSummaNAD_Click(object sender, EventArgs e)
        {
            PushOperation("+");
        }

        private void buttonOperationDifferenceNAD_Click(object sender, EventArgs e)
        {
            PushOperation("-");
        }

        private void buttonOperationMultiplicationNAD_Click(object sender, EventArgs e)
        {
            PushOperation("*");
        }

        private void buttonOperationQuotientNAD_Click(object sender, EventArgs e)
        {
            PushOperation("/");
        }

        private void buttonChangeSignNAD_Click(object sender, EventArgs e)
        {
            PushOperation("+-");
        }

        private void buttonOperationPercentNAD_Click(object sender, EventArgs e)
        {
            PushOperation("%");
        }

        private void buttonFindSqrtNAD_Click(object sender, EventArgs e)
        {
            PushOperation("sqrt");
        }

        private void buttonFindSquareNAD_Click(object sender, EventArgs e)
        {
            PushOperation("square");
        }

        private void buttonFindReciprocalNAD_Click(object sender, EventArgs e)
        {
            PushOperation("rec");
        }

        private void buttonFindLnNAD_Click(object sender, EventArgs e)
        {
            PushOperation("ln");
        }

        private void buttonFindExpNAD_Click(object sender, EventArgs e)
        {
            PushOperation("exp");
        }

        private void buttonFindPiNAD_Click(object sender, EventArgs e)
        {
            double pi = arifmetic_calculator.CalcPi();
            textBoxShowResultNAD.Text = pi.ToString();
        }

        private void buttonFindCosNAD_Click(object sender, EventArgs e)
        {
            PushOperation("cos");
        }

        private void buttonFindSinNAD_Click(object sender, EventArgs e)
        {
            PushOperation("sin");
        }

        private void buttonFindTanNAD_Click(object sender, EventArgs e)
        {
            PushOperation("tan");
        }

        private void buttonFindPowerOfTenNAD_Click(object sender, EventArgs e)
        {
            PushOperation("powoften");
        }

        private void buttonFindPowerOfNumbersNAD_Click(object sender, EventArgs e)
        {
            PushOperation("powofn");
        }

        private void buttonFindFactorialNAD_Click(object sender, EventArgs e)
        {
            PushOperation("fact");
        }

        private void buttonFindAbsNAD_Click(object sender, EventArgs e)
        {
            PushOperation("abs");
        }

        private void buttonClearAllNAD_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void buttonClearSymbolNAD_Click(object sender, EventArgs e)
        {
            if (textBoxShowResultNAD.Text.Length > 0)
            {
                textBoxShowResultNAD.Text = textBoxShowResultNAD.Text.Substring(0, textBoxShowResultNAD.Text.Length - 1);
            }
        }

        private void buttonOperationResultNAD_Click(object sender, EventArgs e)
        {
            CalculateResult();
        }

        private void PushOperation(string operation)
        {
            double currentValue = Convert.ToDouble(textBoxShowResultNAD.Text);
            valuesStack.Push(currentValue);
            operationsStack.Push(operation);
            textBoxShowResultNAD.Text = "0";
        }

        private void CalculateResult()
        {
            double currentValue = Convert.ToDouble(textBoxShowResultNAD.Text);
            valuesStack.Push(currentValue);

            while (operationsStack.Count > 0)
            {
                string operation = operationsStack.Pop();
                double value2 = valuesStack.Pop();
                double value1 = valuesStack.Pop();
                double result = PerformOperation(operation, value1, value2);
                valuesStack.Push(result);
            }

            double finalResult = valuesStack.Pop();
            textBoxShowResultNAD.Text = finalResult.ToString();
            labelShowExpressionNAD.Text = finalResult.ToString();
        }

        private double PerformOperation(string operation, double value1, double value2)
        {
            switch (operation)
            {
                case "+":
                    return calculator.CalcSumma(value1, value2);
                case "-":
                    return calculator.CalcDifference(value1, value2);
                case "*":
                    return calculator.CalcMultiplication(value1, value2);
                case "/":
                    return calculator.CalcQuotient(value1, value2);
                case "+-":
                    return -value1;
                case "%":
                    return calculator.CalcPercentage(value1);
                case "sqrt":
                    return calculator.CalcSquareRoot(value1);
                case "square":
                    return calculator.CalcSquare(value1);
                case "rec":
                    return calculator.CalcReciprocal(value1);
                case "ln":
                    return arifmetic_calculator.CalcNaturalLogarithm(value1);
                case "exp":
                    return arifmetic_calculator.CalcExponent(value1);

                case "cos":
                    return arifmetic_calculator.CalcCos(value1);
                case "sin":
                    return arifmetic_calculator.CalcSin(value1);
                case "tan":
                    return arifmetic_calculator.CalcTan(value1);
                case "powoften":
                    return arifmetic_calculator.CalcPowerOfTen(value1);
                case "powofn":
                    return arifmetic_calculator.CalcPowerOfNumber(value1, value2);
                case "fact":
                    return arifmetic_calculator.CalcFactorial(value1);
                case "abs":
                    return arifmetic_calculator.CalcAbsoluteValue(value1);
                default:
                    throw new InvalidOperationException("Неизвестная операция");
            }
        }

        private void ClearAll()
        {
            textBoxShowResultNAD.Clear();
            labelShowExpressionNAD.Text = "";
            FirstValue = 0;
            currentOperation = string.Empty;
            valuesStack.Clear();
            operationsStack.Clear();
        }

        private void ToolStripMenuItemArithmeticNAD_Click(object sender, EventArgs e)
        {
            this.Size = new Size(550, 600);
            int columnCount = tableLayoutPanelChooseFunctionNAD.ColumnCount;
            for (int i = 0; i < columnCount; i++)
            {
                tableLayoutPanelChooseFunctionNAD.ColumnStyles[i].SizeType = SizeType.Percent;
                tableLayoutPanelChooseFunctionNAD.ColumnStyles[i].Width = 100.0f / columnCount;
            }
        }

        private void ToolStripMenuItemOrdinaryNAD_Click(object sender, EventArgs e)
        {
            this.Size = new Size(400, 600);
            for (int i = 5; i < tableLayoutPanelChooseFunctionNAD.ColumnCount; i++)
            {
                tableLayoutPanelChooseFunctionNAD.ColumnStyles[i].SizeType = SizeType.Absolute;
                tableLayoutPanelChooseFunctionNAD.ColumnStyles[i].Width = 0;
            }
        }

        private void ToolStripMenuItemConversionNAD_Click(object sender, EventArgs e)
        {
            ConversionFormNAD conversionForm = new ConversionFormNAD();
            conversionForm.Show();
        }

        private void ToolStripMenuItemFitnessNAD_Click(object sender, EventArgs e)
        {
            FitnessFormNAD fitnessForm = new FitnessFormNAD();
            fitnessForm.Show();
        }

        private void ToolStripMenuItemInfoNAD_Click(object sender, EventArgs e)
        {
            InfoFormNAD infoForm = new InfoFormNAD();
            infoForm.Show();
        }
    }
}
