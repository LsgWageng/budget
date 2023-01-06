using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget
{
    abstract class expenses
    {
        //array to store all the expenses 
        public double [] userExpenses = new double[14];

        //varible to store monthly income
        public double monthlyIncome = 0;

        //variable to store remaining money
        public double availableMoney = 0;

        //all the set methods prompt the user for income and the get methods return the inputted value
        abstract public void setMonthlyIncome();
        abstract public double getMonthlyIncome();

        abstract public void setMonthlyTax();

        abstract public double getMonthlyTax();

        abstract public void setGroceries();

        abstract public double getGroceries();

        abstract public void setWaterNElectricity();

        abstract public double getWaterNElectricity();

        abstract public void setTravelling();

        abstract public double getTravelling();

        abstract public void setPhoneBill();

        abstract public double getPhoneBill();

        abstract public void setOtherExpenses();

        abstract public double getOtherExpenses();

        abstract public void setMonthlyRent();

        abstract public double getMonthyRent();

        abstract public void setPropertyPrice();

        abstract public double getPropertyPrice();

        abstract public void setDepositAmount();

        abstract public double getDepositAmount();

        abstract public void setInterestAmount();

        abstract public double getInterestAmount();

        abstract public void setNumOfMonths();

        abstract public double getNumOfMonths();

        abstract public void calculateTotalRepayment();

        abstract public double getTotalRepayment();

        //method to calculate the monthly repayment of the home loan
        abstract public void calculateMonthlyRepayment();

        abstract public double getMonthlyRepayment();

        abstract public void calculatingThirdOfgross();

        abstract public double getThirdOfGross();

        //method will calculate how much the user has left every month after all the dedutions have been made
        abstract public void calculatedAvailableMoney();

        abstract public double getCalculatedAvailableMoney();


    }
}
