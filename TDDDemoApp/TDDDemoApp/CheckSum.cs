using System;

namespace TDDDemoApp
{
    public class CheckSum {
        public string CheckSumInput (double first, double secound, double third) {
            var sum = first + secound;
            if (sum.Equals(third)) {
                return "Yes";
            }
            return "No";
        }
    }
}