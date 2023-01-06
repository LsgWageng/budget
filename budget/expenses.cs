using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget
{
    abstract class expenses
    {
        //LIST to store all the expenses 

        static int size = 19;

        protected List<double> userExpenses = new List<double>(new double[size]);

        public string modelNMAke;

        //varible to store monthly income
        public double monthlyIncome = 0;

        //variable to store remaining money
        public double availableMoney = 0;

        //all the set methods prompt the user for income and the get methods return the inputted value
        abstract public void setGrossMonthlyIncome();
        abstract public double getGrossMonthlyIncome();

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

        abstract public void calculateTotalPropertyRepayment();

        abstract public double getTotalPropertyRepayment();

        //method to calculate the monthly repayment of the home loan
        abstract public void calculateMonthlyRepayment();

        abstract public double getMonthlyRepayment();

        abstract public void calculatingThirdOfgross();

        abstract public double getThirdOfGross();

        abstract public double getCalculatedAvailableMoney();

        //method to prompt for vehicle make and model
        abstract public void setModelNMake();

        //method to return make and model
        abstract public string getModelNMake();

        //method to prompt for vehicle puchase price
        abstract public void setPurchasePrise();

        //method to return vehicle pruchase price
        abstract public double getPurchasePrice();

        abstract public void setVehicleDeposit();

        abstract public double getVehicleDeposit();

        abstract public void setVehicleInterestRate();

        abstract public double getVehicleInterestRate();

        abstract public void setInsurance();

        abstract public double getInsurance();

        abstract public void setVehicleMonthlyCost();

        abstract public double getVehicleMonhtlyCost();
      
    }
}
