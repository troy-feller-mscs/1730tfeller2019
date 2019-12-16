using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tfeller1730ex3c
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            if (index <= 0 || index >= 8)
                return "Invalid index";
            else
            {
                int i = index - 1;
                string[] days = {
                    "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                string day = days[i];
                return day;
            }
        }
        public static string Calc1(string search)
        {
            string search1 = search.Trim();
            string search2 = search1.ToUpper();
            string[] days = {
                "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = {
                "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            int index = Array.IndexOf(days, search2);
            if (index < 0 || index > 6)
                return "Invalid input";

            string HoO = hours[index];
            return HoO.ToString();
        }

        public static int Calc2(int[] numbers2)
        {
            int sum = 0;
            foreach (int total in numbers2)
                sum += total;
            return sum;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double sum = 0.0;
            if (count > numbers.GetLength(0))
                sum = 0.0;
            else
            {
                for (int i = 0; i < count; i++)
                    sum += numbers[i];
            }
            return sum;
        }
        public static double Calc5(double[] numbers)
        {
            int count = numbers.Length;
            double numbers1 = Calc3(numbers, count);
            double average = numbers1 / count;
            return average;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                foreach (double num in numbers)
                {
                    if (num >= avg)
                        aboveAvgList.Add(num);
                }
            }
            return aboveAvgList.ToArray();
        }
    }
}
