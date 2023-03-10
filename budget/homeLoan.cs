using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget
{
     class homeLoan : expenses
    {
     
        public override void setGrossMonthlyIncome()
        {
            //do while loop will execute the try block and then the catch block will catch an error that occurs
            //if the error continues occuring, the loop will continue until the user enters the correct information
            do
            {
                try
                {
                    Console.WriteLine(" PLEASE ENTER YOUR GROSS MONTHLY INCOME BEFORE ANY DEDUCTIONS:");
                    monthlyIncome = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY, YOU DID NOT ENTER YOUR INCOME \n");
                }
            }

            while (monthlyIncome == 0);
        }


        //method will return the grossIncome of the user
        public override double getGrossMonthlyIncome()
        {
            return monthlyIncome;
        }

        //setting the tax dedution 
        public override void setMonthlyTax()
        {
            //prompt for tax deduction percentage from salary

           Console.WriteLine("PLEASE ENTER YOUR ESTIMATED MONTHLY TAX(PERCENTAGE) :");
            userExpenses.Insert(0,Double.Parse(Console.ReadLine()));

        }

        //method will return the users tax deduction percentage as a whole number
        public override double getMonthlyTax()
        {
            return userExpenses[0];
        }

        //setting the groceries
        public override void setGroceries()
        {
           
            
                    //prompt for how much they spend on grocerries
                    Console.WriteLine("PLEASE ENTER THE ESTIMATED AMOUNT YOU SPEND ON GROCERIES:");

                    userExpenses.Insert(1, Double.Parse(Console.ReadLine()));
                
        }

        //method will return the total amount spent on groceries
        public override double getGroceries()
        {
            return userExpenses[1];
        }

        //setting the water and electricity
        public override void setWaterNElectricity()
        {
            
                    //prompt for how much they spend on water and electricity
                    Console.WriteLine("PLEASE ENTER THE ESTIMATED AMOUNT YOU SPEND ON WATER AND ELECTRICITY:");
                    userExpenses.Insert(2, Double.Parse(Console.ReadLine()));
                
        }

        //method will return how much the user spends on water and electricity combined
        public override double getWaterNElectricity()
        {
            return userExpenses[2];
        }

        //setting the travelling
        public override void setTravelling()
        {
            
                    //prompt for how much they spend on travelling
                    Console.WriteLine("PLEASE ENTER THE ESTIMATED AMOUNT YOU SPEND ON TRAVELLING INCLUDING PETROL:");
                    userExpenses.Insert(3, Double.Parse(Console.ReadLine()));
                
        }

        //method will return the travelling amount
        public override double getTravelling()
        {
            return userExpenses[3];
        }

        //setting the phone bill
        public override void setPhoneBill()
        {
            
                    //prompt for how much they spend on their phone bill
                    Console.WriteLine("PLEASE ENTER THE ESTIMATED CELL PHONE AND TELEPHONE BILL:");
                    userExpenses.Insert(4, Double.Parse(Console.ReadLine()));
                
        }

        //method to return the phoneBill amount
        public override double getPhoneBill()
        {
            return userExpenses[4];
        }

        //setting the other expenses
        public override void setOtherExpenses()
        {
            
                
                    //prompt for other expenses
                    Console.WriteLine("PLEASE ENTER THE ESTIMATED TOTAL AMOUNT OF ANY OTHER EXPENSES:");
                    userExpenses.Insert(5, Double.Parse(Console.ReadLine()));
                
        }

        //method will return the value of other expenses
        public override double getOtherExpenses()
        {
            return userExpenses[5];
        }

        //prompting for monthly rent
        public override void setMonthlyRent()
        {
            
                    Console.WriteLine("YOU HAVE DECIDED TO RENT THE PROPERTY \n PLEASE ENTER THE MONTHLY RENT AMOUNT FOR THE PROPERTY");
                    userExpenses.Insert(6, double.Parse(Console.ReadLine()));
                
        }

        //returing the monthly rent
        public override double getMonthyRent()
        {
            return userExpenses[6];
        }

        //promping for price of property
        public override void setPropertyPrice()
        {
            
                    Console.WriteLine("YOU HAVE DECIDED TO BUY THE PROPERTY \n PLEASE ENTER THE PURCHASE PRICE OF THE PROPERTY");
                    userExpenses.Insert(7, double.Parse(Console.ReadLine()));
                
        }

        //returning the price of the property
        public override double getPropertyPrice()
        {
            return userExpenses[7];
        }

        //prompting for the deposite that the user is going to pay
        public override void setDepositAmount()
        {
            
                    Console.WriteLine("PLEASE ENTER THE DEPOSIT AMOUNT FOR THE PROPERTY:");
                    userExpenses.Insert(8, double.Parse(Console.ReadLine()));
                
        }

        //returning deposite amount
        public override double getDepositAmount()
        {
            return userExpenses[8];
        }

        //promping for interest amount the user is going to pay
        public override void setInterestAmount()
        {
           
                    Console.WriteLine("PLEASE ENTER THE INTEREST CHARGED(PERCENTAGE) :");
                    userExpenses.Insert(9, (double.Parse(Console.ReadLine())));
                
        }

        //returning the interest 
        public override double getInterestAmount()
        {
            return userExpenses[9];
        }

        //prompting for the number of months that the user is going to use to repay the loan
        public override void setNumOfMonths()
        {
            
                    Console.WriteLine("PLEASE ENTER THE NUMBER OF MONTHS BETWEEN 240-360 THAT YOU ARE GOING TO NEED TO REPAY THE HOME LOAN:");
                    userExpenses.Insert(10, Convert.ToInt32(Console.ReadLine()));
                
        }

        //returning the number if months
        public override double getNumOfMonths()
        {
            return userExpenses[10];
        }

        //calculating how much the user is going to pay for the home loan
        public override void calculateTotalPropertyRepayment()
        {
            //local variables to store the pricple, interest and years

            double principle = getPropertyPrice() - getDepositAmount();

            double interest = getInterestAmount() / 100;

            double years = getNumOfMonths() / 12;

            userExpenses.Insert(11, (principle * (1 + (interest * years))) );
        }

        //returning the calculated loan 
        public override double getTotalPropertyRepayment()
        {
            return userExpenses[11];
        }

        //calculating the monthly repayments
        public override void calculateMonthlyRepayment()
        {
            userExpenses.Insert(12, (getTotalPropertyRepayment() / getNumOfMonths()) );
        }

        //returning the monthly repayment
        public override double getMonthlyRepayment()
        {
            return userExpenses[12];
        }

        //calculating a third of the users salary
        public override void calculatingThirdOfgross()
        {
            userExpenses.Insert(13, (getGrossMonthlyIncome() / 3) );
        }

        //returing third of gross monhtly salary
        public override double getThirdOfGross()
        {
            return userExpenses[13];
        }

        //returning the calculated available money
        public override double getCalculatedAvailableMoney()
        {
            return availableMoney;
        }

        public override void setModelNMake()
        {
            Console.WriteLine("PLEASE ENTER THE MAKE AND MODEL OF THE CAR:");
            modelNMAke = Console.ReadLine();
        }

        public override string getModelNMake()
        {
            return modelNMAke;
        }

        public override void setPurchasePrise()
        {
            
                    Console.WriteLine("PLEASE ENTER VEHICLE PRUCHASE PRICE");

                    userExpenses.Insert(14, Double.Parse(Console.ReadLine()));
                
           
        }

        public override double getPurchasePrice()
        {
            return userExpenses[14];
        }

        public override void setVehicleDeposit()
        {
            
                    Console.WriteLine("PLEASE ENTER VEHICLE DEPOSIT");

                    userExpenses.Insert(15, Double.Parse(Console.ReadLine()));
                
        }

        public override double getVehicleDeposit()
        {
            return userExpenses[15];
        }

        public override void setVehicleInterestRate()
        {
            
                    Console.WriteLine("PLEASE ENTER VEHICLE INTEREST RATE CHARGED (PERCENTAGE)");

                    userExpenses.Insert(16, Double.Parse(Console.ReadLine()));
                
        }

        public override double getVehicleInterestRate()
        {
            return userExpenses[16];
        }

        public override void setInsurance()
        {
            
                    Console.WriteLine("PLEASE ENTER VEHICLE INSURANCE CHARGED PER MONTH");

                    userExpenses.Insert(17, Double.Parse(Console.ReadLine()));
                
        }

        public override double getInsurance()
        {
            return userExpenses[17];
        }

        public override void setVehicleMonthlyCost()
        {
            double principle = getPurchasePrice() - getVehicleDeposit();

            double interest = getVehicleInterestRate() / 100;

            double years = 5;

            double totalRepayment = principle * (1 + (interest * years));

            double monthlyPayment = (totalRepayment/ 12) + getInsurance();

            userExpenses.Insert(18, monthlyPayment );
        }

        public override double getVehicleMonhtlyCost()
        {
            return userExpenses[18];
        }

        public double getTaxedMonthlyIncome()
        {
            double tax = getMonthlyTax() / 100;

            double monthlySalary = getGrossMonthlyIncome() - (tax * getGrossMonthlyIncome());

            return monthlySalary;
        }

        public void rentPropertyBudget()
        {
            double totalExpenses = getGroceries() + getWaterNElectricity() + getTravelling() + getPhoneBill() + getOtherExpenses() + getMonthyRent();

            double availableMoney = getTaxedMonthlyIncome() - totalExpenses;

            Console.WriteLine("BUDGET CALCULATOR\n" +
                              "************************************************");

            Console.WriteLine("TAX:\t\t\t\t" + getMonthlyTax()+"%");

            Console.WriteLine("GROCERIES:\t\t\tR" + getGroceries());

            Console.WriteLine("WATER AND ELECTRICITY:\t\tR" + getWaterNElectricity());

            Console.WriteLine("TRAVELLING:\t\t\tR" + getTravelling());

            Console.WriteLine("PHONE BILL:\t\t\tR" + getPhoneBill());

            Console.WriteLine("OTHER EXPENSES:\t\t\tR" + getOtherExpenses());

            Console.WriteLine("MONTHLY RENT:\t\t\tR" + getMonthyRent());

            Console.WriteLine("*************************************************\n" +
                              "GROSS INCOME:\t\t\tR" + getGrossMonthlyIncome());

            Console.WriteLine("*************************************************\n" +
                              "MONTHLY TAXED INCOME:\t\tR" + getTaxedMonthlyIncome());

            Console.WriteLine("TOTAL EXPENSES:\t\tR" + totalExpenses);

            Console.WriteLine("*************************************************\n" +
                              "AVILABLE MONEY:\t\t\tR" + availableMoney +
                              "\n*************************************************");
        }

        public void buyPropertyBudget()
        {
            double totalExpenses = getGroceries() + getWaterNElectricity() + getTravelling() + getPhoneBill() + getOtherExpenses() + getMonthlyRepayment();

            double availableMoney = getTaxedMonthlyIncome() - totalExpenses;

            Console.WriteLine("BUDGET CALCULATOR\n" +
                              "************************************************");

            Console.WriteLine("TAX:\t\t\t\t" + getMonthlyTax()+"%");

            Console.WriteLine("GROCERIES:\t\t\tR" + getGroceries());

            Console.WriteLine("WATER AND ELECTRICITY:\t\tR" + getWaterNElectricity());

            Console.WriteLine("TRAVELLING:\t\t\tR" + getTravelling());

            Console.WriteLine("PHONE BILL:\t\t\tR" + getPhoneBill());

            Console.WriteLine("OTHER EXPENSES:\t\t\tR" + getOtherExpenses());

            Console.WriteLine("PROPERTY PRICE:\t\t\tR" + getPropertyPrice());

            Console.WriteLine("DEPOSITE AMOUNT:\t\tR" + getDepositAmount());

            Console.WriteLine("INTEREST CHARGED:\t\t" + getInterestAmount() + "%");

            Console.WriteLine("NUMBER OF MONTHS TO REPAY LOAN: " + getNumOfMonths());

            Console.WriteLine("*************************************************\n" +
                              "GROSS INCOME:\t\t\tR" + getGrossMonthlyIncome());

            Console.WriteLine("*************************************************\n" +
                              "MONTHLY TAXED INCOME:\t\tR" + getTaxedMonthlyIncome());

            Console.WriteLine("TOTAL PROPERTY LOAN REPAYMENT:\t\tR" + getTotalPropertyRepayment());

            Console.WriteLine("TOTAL MONTHLY PROPERTY PAYMENTS:\t\tR" + getMonthlyRepayment());

            Console.WriteLine("TOTAL EXPENSES:\t\tR" );

            Console.WriteLine("*************************************************\n" +
                              "AVILABLE MONEY:\t\t\tR" + availableMoney +
                              "\n*************************************************");

            //check if expenses > 75%
            double seventyFivePercentOfSalary = getTaxedMonthlyIncome() * (75 / 100);

            if (totalExpenses > seventyFivePercentOfSalary)
            {
                System.Media.SystemSounds.Beep.Play();

                Console.WriteLine("*****EXPENSES EXCEED 75% OF SALARY******");
            }
        }

        public void buyVehicleBudget()
        {
            double totalExpenses = getGroceries() + getWaterNElectricity() + getTravelling() + getPhoneBill() + getOtherExpenses() + getVehicleMonhtlyCost();

            double availableMoney = getTaxedMonthlyIncome() - totalExpenses;

            Console.WriteLine("BUDGET CALCULATOR\n" +
                              "************************************************");

            Console.WriteLine("TAX:\t\t\t\t" + getMonthlyTax()+"%");

            Console.WriteLine("GROCERIES:\t\t\tR" + getGroceries());

            Console.WriteLine("WATER AND ELECTRICITY:\t\tR" + getWaterNElectricity());

            Console.WriteLine("TRAVELLING:\t\t\tR" + getTravelling());

            Console.WriteLine("PHONE BILL:\t\t\tR" + getPhoneBill());

            Console.WriteLine("OTHER EXPENSES:\t\t\tR" + getOtherExpenses());

            Console.WriteLine("VEHICLE MAKE AND MODEL:\t\tR" + getModelNMake());

            Console.WriteLine("VEHICLE PURCHASE PRICE:\t\tR" + getPurchasePrice());

            Console.WriteLine("VEHICLE DEPOSIT:\t\tR" + getVehicleDeposit());

            Console.WriteLine("VEHICLE INTERST RATE CHARGED FOR VEHICLE:\t\tR" + getVehicleInterestRate());

            Console.WriteLine("VEHICLE INSURANCE PREMIUM CHARGED:\t\tR" + getInsurance());

            Console.WriteLine("VEHICLE MONTHLY COST:\t\tR" + getVehicleMonhtlyCost());

            Console.WriteLine("*************************************************\n" +
                              "GROSS INCOME:\t\t\tR" + getGrossMonthlyIncome());

            Console.WriteLine("*************************************************\n" +
                              "MONTHLY TAXED INCOME:\t\tR" + getTaxedMonthlyIncome());

            Console.WriteLine("TOTAL EXPENSES:\t\tR" + totalExpenses);

            Console.WriteLine("*************************************************\n" +
                              "AVILABLE MONEY:\t\t\tR" + availableMoney +
                              "\n*************************************************");

        }
    }
}
