using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace tfeller1730ex2h
{
    public class Ex2hCalculations
    {
        //Date Calculation Methods
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
            return result;
            
        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }
            return result;

        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();

            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            try
            {
                DateTime DateA = DateTime.Parse(strDateA);
                DateTime DateB = DateTime.Parse(strDateB);
                TimeSpan date = DateA.Subtract(DateB);
                int newDate = date.Days;
                result = newDate.ToString() + " days";
            }
            catch { }
            return result;

        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            try
            {
                DateTime DateA = DateTime.Parse(strDateA);
                DateTime DateB = DateTime.Parse(strDateB);
                if (DateA > DateB)
                {
                    TimeSpan date = DateA.Subtract(DateB);
                    int newDate = date.Days;
                    result = newDate.ToString() + " days past due";
                }
                if(DateA <= DateB)
                {
                    result = "On time";
                }
            }
            catch { }
            return result;

        }

        //String Calculation Methods
        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
            try
            {
                string original = s;
                String modified = original.Remove(0, 1);
                result = modified.Insert(0, "cr");
            }
            catch { }
            return result;
        }
        public static string StringCalc02(string s)
        {
            string result = "Invalid input";
            try
            {
                string original = s;
                String mod = original.Remove(1, 1);
                result = mod.Insert(1, "rit");
            }
            catch { }
            return result;
        }
        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            try
            {
                string original = s;
                String mod = original.Substring(2, 4);
                result = mod.ToUpper();
            }
            catch { }
            return result;
        }
        public static string StringCalc04(string s)
        {
            string result = "Invalid input";
            try
            {
                string original = s;
                result = original.PadLeft(10, '*');
            }
            catch { }
            return result;
        }
        public static string StringCalc05(string s)
        {
            string result = "Invalid input";
            try
            {
                string original = s;
                string mod = original.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", "");
                result = mod;
            }
            catch { }
            return result;
        }
        public static string StringCalc06(string s)
        {
            string result = "Invalid input";
            try
            {
                string original = s;
                String mod = original.Replace('(', ' ').Replace(')', ' ').Replace('-', ' ').Replace(" ", "");

                if (mod.Length >= 11)
                    result = "Invalid input";

                if (mod.Length >= 7 && mod.Length < 10)
                    result = mod.Insert(3, ".");

                else result = mod.Insert(3, ".").Insert(7, ".");

            }
            catch { }
            return result;
        }
        public static string StringCalc07(string s)
        {
            string result = "Invalid input";

            string original = s.ToLower();

            if (original.Contains("pioneer"))
                result = "Found";
            else result = "Not found";

            return result;
        }
        public static string StringCalc08(string s)
        {
            string result = "Invalid input";
            try
            {
                int cityIndex = s.IndexOf(",") + 10;
                result = cityIndex.ToString();
            }
            catch { }
            return result;
        }
        //public static string StringCalc09(string s)
        //{

        //}
        //public static string StringCalc10(string s1, string s2, string s3)
        //{
        //    StringBuilder sb = new StringBuilder(100);

        //    return "";
        //}
    }
}