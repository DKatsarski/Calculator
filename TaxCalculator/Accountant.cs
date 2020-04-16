using TaxCalculator.Constants;

namespace TaxCalculator
{
    public class Accountant
    {
        public decimal TaxSalary(decimal salary)
        {
            decimal socialContributionsTax = 0;
            decimal incomeTax = 0;

            if (salary <= GlobalConstants.LOWEST_TAXATION_LINE)
            {
                return salary;
            }

            var taxableAmount = salary - GlobalConstants.LOWEST_TAXATION_LINE;
            incomeTax = taxableAmount * GlobalConstants.INCOME_TAX_PERCENTAGE;

            if (salary > GlobalConstants.HIGHEST_TAXATION_LINE)
            {
                socialContributionsTax = GlobalConstants.MAX_TAXABLE_AMOUNT_FOR_SOC_CONTR * GlobalConstants.SOCIAL_CONTRIBUTIONS_PERCENTAGE;
            }
            else
            {
                socialContributionsTax = taxableAmount * GlobalConstants.SOCIAL_CONTRIBUTIONS_PERCENTAGE;
            }

            salary = salary - incomeTax - socialContributionsTax;

            return salary;
        }
    }
}
