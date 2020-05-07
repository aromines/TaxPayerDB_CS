using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARomines
{
    class Taxpayer
    {
        //properties from stage 1
        public String Name { get; private set; }
        public double Salary { get; private set; }
        public double Investment { get; private set; }
        public int Exemption { get; private set; }
        public bool Married { get; private set; }

        //properties from stage 2
        public double Taxable { get; private set; }
        public double Rate { get; private set; }

        //static fields
        public static int MarriedCount { get; private set; }
        public static int UnmarriedCount { get; private set; } 
        public static double TotalTax { get; private set; }

        //constructor
        public Taxpayer(String nameString, double salaryDouble, double investmentDouble, int exemptionInt, bool marriedBool)
        {
            this.Name = nameString;
            this.Salary = salaryDouble;
            this.Investment = investmentDouble;
            this.Exemption = exemptionInt;
            this.Married = marriedBool;

            double taxDouble;

            //computations
            //--compute taxable
            if ((Salary + Investment) > ComputeTotalDeduction())
            { Taxable = (Salary + Investment) - ComputeTotalDeduction(); }            
            //end if statement

            //--compute tax rate
            if(Married == true)
            {
                if(Taxable > 100000)
                { Rate = 0.2; }
                else
                { Rate = 0.15; }
                //end if statement
            }
            else
            {
                if(Taxable > 70000)
                    { Rate = 0.15; }
                else
                { Rate = 0.10; }
                //end if statement
            }
            //end if statement

            //--compute tax
            taxDouble = Taxable * Rate;

            //update totals
            if (marriedBool == true)
            {
                MarriedCount = MarriedCount + 1;
            }
            else
            {
                UnmarriedCount = UnmarriedCount + 1;
            }
            //end if statement

            TotalTax = TotalTax + taxDouble;            
        }

        //========================METHODS===========================
        public String Info()
        {           
            return Name + "\t" +
                (Salary + Investment).ToString("C") + "\t" +
                (Taxable * Rate).ToString("C") + "\t";            
        }
        //save() method for save button
        public String Save() //CSV
        {          
            return Name + "," + Salary.ToString()
                + "," + Investment.ToString()
                + "," + Taxable.ToString()
                + "," + (Rate * 100).ToString()
                + "," + (Taxable * Rate).ToString();
        }
        //method for static summary
        public static String Summary()
        {            
            return "Number of married taxpayers: " + MarriedCount.ToString() + "\r\n" +
                "Number of unmarried taxpayers: " + UnmarriedCount.ToString() + "\r\n" + 
                "Average tax across all taxpayers: " + ComputeAverageTax().ToString("C");
        }
        //method to reset static globals
        public static void ResetCounts()
        {
            MarriedCount = 0;
            UnmarriedCount = 0;
            TotalTax = 0;
        }        
        //method to compute total deduction
        public int ComputeTotalDeduction()
        {
            int deduction;

            if(Married == true)
            { deduction = ((Exemption * 400) + 600); }
            else
            { deduction = ((Exemption * 225) + 300); }

            return deduction;
        }
        //method to compute average tax
        public static double ComputeAverageTax()
        {
            double average = 0; //prevent division by 0

            if((MarriedCount + UnmarriedCount) > 0)
            { average = TotalTax / (MarriedCount + UnmarriedCount); }

            return average;
        }
    }
}
