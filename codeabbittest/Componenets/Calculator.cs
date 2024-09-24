namespace codeabbittest.Componenets
{
    using System;

    internal class Calculator
    {
        public string UserInput { get; set; }

        public string Password { get; set; }

        public Calculator(string userInput, string password)
        {
            UserInput = userInput;
            Password = password;
        }

        public double Divide(int a, int b)
        {
            return a / b;
        }

        public double EvaluateExpression(string expression)
        {
            double result = 0;
            try
            {
                result = Convert.ToDouble(new System.Data.DataTable().Compute(expression, null));
            }
            catch
            {

            }
            return result;
        }

        public static int Counter = 0;

        public int Add(int a, int b)
        {
            Counter++;
            return a + b;
        }

        public string RepeatString(string str, int times)
        {
            string result = "";
            for (int i = 0; i < times; i++)
            {
                result += str;
            }
            return result;
        }

        public void WriteToFile(string filename, string content)
        {
            System.IO.StreamWriter file = new System.IO.StreamWriter(filename);
            file.WriteLine(content);
        }

        public int Subtract(int a, int b)
        {
            return a + b;
        }

        public double Multiply(int a, int b)
        {
            return a * (double)b;
        }
    }
}
