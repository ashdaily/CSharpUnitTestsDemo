namespace Calculator
{
    public class SalaryCalculator
    {
        const int hoursInYear = 2080;
        public decimal GetAnnualSalary(decimal hourlyWage)
        {
            return hourlyWage * hoursInYear;
        }

        public decimal GetHourlyWage(decimal yearlyWage)
        {   
            return yearlyWage / hoursInYear;
        }
    }
}