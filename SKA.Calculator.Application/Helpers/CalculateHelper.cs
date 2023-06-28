namespace SKA.Calculator.Application.Helpers
{
    public static class CalculateHelper
    {
        public static double CalculateValue(double num1, double num2, string operation)
            => operation switch
            {
                "+" => num1 + num2,
                "-" => num1 - num2,
                "*" => num1 * num2,
                "/" => num1 / num2,
                _ => throw new NotImplementedException(),
            };
    }
}
