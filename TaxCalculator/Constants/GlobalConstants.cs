namespace TaxCalculator.Constants
{
    public class GlobalConstants
    {
        public const decimal LOWEST_TAXATION_LINE = 1000;
        public const decimal HIGHEST_TAXATION_LINE = 3000;
        public const decimal INCOME_TAX_PERCENTAGE = 0.1m;
        public const decimal SOCIAL_CONTRIBUTIONS_PERCENTAGE = 0.15m;
        public const decimal MAX_TAXABLE_AMOUNT_FOR_SOC_CONTR = HIGHEST_TAXATION_LINE - LOWEST_TAXATION_LINE;
    }
}
