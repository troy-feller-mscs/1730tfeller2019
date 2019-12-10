using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfeller1730ex3b
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;

            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }
        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

        }
        public static decimal CalculateFutureValue (decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m; 

            for (int i = 1; i <= months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyIntrestRate, int months, ref decimal futureValue)
        {
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyIntrestRate);
            }

        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double celsius = fahrenheit;
            celsius = (fahrenheit - 32) / 1.8;

            return celsius;
        }
        public static void CelsiusToFahrenheit(double celsius, out double fahrenheit)
        {
            fahrenheit = (celsius * 1.8) + 32;
        }
        public static decimal GrossPay(decimal hours, decimal rate)
        {
            decimal GrossPay = 0m;
            if (hours <= 40)
                GrossPay = hours * rate;
            else
                GrossPay = (40 * rate) + (hours - 40) * (rate * 1.5m);
            return GrossPay;
        }
        public static decimal TotalHours(string Numbers)
        {
            decimal total = 0;
            int startIndex = 0;
            while (startIndex < Numbers.LastIndexOf(' '))
            {
                int endIndex = Numbers.IndexOf(' ', startIndex);
                string sequence = Numbers.Substring(startIndex, endIndex - startIndex);
                Decimal value = Decimal.Parse(sequence);
                total += value;
                startIndex = endIndex + 1;
            }
            return total;
        }
        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal totalHours = TotalHours(strNumbers);
            return GrossPay(totalHours, rate);
        }
    }
}
