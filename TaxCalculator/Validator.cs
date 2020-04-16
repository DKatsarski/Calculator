namespace TaxCalculator
{
    public static class Validator
    {
        public static bool IsNumber(string str)
        {
            decimal valueType;
            return decimal.TryParse(str, out valueType);
        }

        public static bool IsPositiveNumber(string str)
        {
            return decimal.Parse(str) < 0;
        }
    }
}
