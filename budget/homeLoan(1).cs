using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget
{
    class homeLoan : expenses
    {
        public override void setMonthlyIncome()
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
        public override double getMonthlyIncome()
        {
            return monthlyIncome;
        }

        //setting the tax dedution 
        public override void setMonthlyTax()
        {
            do
            {
                try
                {
                    //prompt for tax deduction percentage from salary
                    Console.WriteLine("PLEASE ENTER YOUR ESTIMATED MONTHLY TAX(PERCENTAGE) :");
                    userExpenses[0] = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY,YOU DID NOT ENTER THE PERCENTAGE AMOUNT \n");
                }
            } while (userExpenses[0] == 0);
        }

        //method will return the users tax deduction percentage as a whole number
        public override double getMonthlyTax()
        {
            return userExpenses[0];
        }

        //setting the groceries
        public override void setGroceries()
        {
            do
            {
                try
                {
                    //prompt for how much they spend on grocerries
                    Console.WriteLine("PLEASE ENTER THE ESTIMATED AMOUNT YOU SPEND ON GROCERIES:");
                    userExpenses[1] = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY, YOU DID NOT ENTER HOW MUCH YOU SPEND ON GROCERIES \n");
                }
            } while (userExpenses[1] == 0);
        }

        //method will return the total amount spent on groceries
        public override double getGroceries()
        {
            return userExpenses[1];
        }

        //setting the water and electricity
        public override void setWaterNElectricity()
        {
            do
            {
                try
                {
                    //prompt for how much they spend on water and electricity
                    Console.WriteLine("PLEASE ENTER THE ESTIMATED AMOUNT YOU SPEND ON WATER AND ELECTRICITY:");
                    userExpenses[2] = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY YOU DID NOT ENTER HOW MUCH YOU SPEND ON WATER AND ELECTRICITY \n");
                }
            } while (userExpenses[2] == 0);
        }

        //method will return how much the user spends on water and electricity combined
        public override double getWaterNElectricity()
        {
            return userExpenses[2];
        }

        //setting the travelling
        public override void setTravelling()
        {
            do
            {
                try
                {
                    //prompt for how much they spend on travelling
                    Console.WriteLine("PLEASE ENTER THE ESTIMATED AMOUNT YOU SPEND ON TRAVELLING INCLUDING PETROL:");
                    userExpenses[3] = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY, YOU DID NOT ENTER THE AMOUNT YOU SPEND ON TRAVELLING \n");
                }
            } while (userExpenses[3] == 0);
        }

        //method will return the travelling amount
        public override double getTravelling()
        {
            return userExpenses[3];
        }

        //setting the phone bill
        public override void setPhoneBill()
        {
            do
            {
                try
                {
                    //prompt for how much they spend on their phone bill
                    Console.WriteLine("PLEASE ENTER THE ESTIMATED CELL PHONE AND TELEPHONE BILL:");
                    userExpenses[4] = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY YOU DID NOT ENTER THE AMOUNT THAT YOU SPEND ON YOUR CELL PHONE AND TELEPHONE BILL \n");

                }
            } while (userExpenses[4] == 0);
        }

        //method to return the phoneBill amount
        public override double getPhoneBill()
        {
            return userExpenses[4];
        }

        //setting the other expenses
        public override void setOtherExpenses()
        {
            do
            {
                try
                {
                    //prompt for other expenses
                    Console.WriteLine("PLEASE ENTER THE ESTIMATED TOTAL AMOUNT OF ANY OTHER EXPENSES:");
                    userExpenses[5] = Double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY YOU DID NOT ENTER THE AMOUNT YOU SPEND ON OTHER EXPENSES \n");
                }
            } while (userExpenses[5] == 0);
        }

        //method will return the value of other expenses
        public override double getOtherExpenses()
        {
            return userExpenses[5];
        }

        //prompting for monthly rent
        public override void setMonthlyRent()
        {
            do
            {
                try
                {
                    Console.WriteLine("YOU HAVE DECIDED TO RENT THE PROPERTY \n PLEASE ENTER THE MONTHLY RENT AMOUNT FOR THE PROPERTY");
                    userExpenses[6] = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY YOU DID NOT ENTER THE PRICE OF THE PROPERTY");
                }

            } while (userExpenses[6] == 0);
        }

        //returing the monthly rent
        public override double getMonthyRent()
        {
            return userExpenses[6];
        }

        //promping for price of property
        public override void setPropertyPrice()
        {
            do
            {
                try
                { 
                    Console.WriteLine("YOU HAVE DECIDED TO BUY THE PROPERTY \n PLEASE ENTER THE PURCHASE PRICE OF THE PROPERTY");
                    userExpenses[7] = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY YOU DID NOT ENTER THE PRICE OF THE PROPERTY");
                }

            } while (userExpenses[7] == 0);
        }

        //returning the price of the property
        public override double getPropertyPrice()
        {
            return userExpenses[7];
        }

        //prompting for the deposite that the user is going to pay
        public override void setDepositAmount()
        {
            do
            {
                try
                {
                    Console.WriteLine("PLEASE ENTER THE DEPOSIT AMOUNT FOR THE PROPERTY:");
                    userExpenses[8] = double.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY YOU DID NOT ENTER THE DEPOSIT AMOUNT \n");
                }
            } while (userExpenses[8] == 0);
        }

        //returning deposite amount
        public override double getDepositAmount()
        {
            return userExpenses[8];
        }

        //promping for interest amount the user is going to pay
        public override void setInterestAmount()
        {
            do
            {
                try
                {
                    Console.WriteLine("PLEASE ENTER THE INTEREST CHARGED(PERCENTAGE) :");
                    userExpenses[9] = (double.Parse(Console.ReadLine()));
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY YOU DID NOT ENTER THE INTEREST AMOUNT \n");
                }
            } while (userExpenses[9] == 0);
        }

        //returning the interest 
        public override double getInterestAmount()
        {
            return userExpenses[9];
        }

        //prompting for the number of months that the user is going to use to repay the loan
        public override void setNumOfMonths()
        {
            do
            {
                try
                {
                    Console.WriteLine("PLEASE ENTER THE NUMBER OF MONTHS BETWEEN 240-360 THAT YOU ARE GOING TO NEED TO REPAY THE HOME LOAN:");
                    userExpenses[10] = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("SORRY YOU DID NOT ENTER THE NUMBER OF MONTHS \n");
                }
            } while (userExpenses[10] == 0);
        }

        //returning the number if months
        public override double getNumOfMonths()
        {
            return userExpenses[10];
        }

        //calculating how much the user is going to pay for the home loan
        public override void calculateTotalRepayment()
        {
            //local variables to store the pricple, interest and years

            double principle = getPropertyPrice() - getDepositAmount();

            double interest = getInterestAmount() / 100;

            double years = getNumOfMonths() / 12;

            userExpenses[11] = principle * (1 + (interest * years));
        }

        //returning the calculated loan 
        public override double getTotalRepayment()
        {
            return userExpenses[11];
        }

        //calculating the monthly repayments
        public override void calculateMonthlyRepayment()
        {
            userExpenses[12] = getTotalRepayment() / getNumOfMonths();
        }

        //returning the monthly repayment
        public override double getMonthlyRepayment()
        {
            return userExpenses[12];
        }

        //calculating a third of the users salary
        public override void calculatingThirdOfgross()
        {
            userExpenses[13] = getMonthlyIncome() / 3;
        }

        //returing third of gross monhtly salary
        public override double getThirdOfGross()
        {
            return userExpenses[13];
        }

        //calculating how much money the user has left
        public override void calculatedAvailableMoney()
        {
            //local variable to store tax and taxed monthly salary
            double tax = getMonthlyTax() / 100;

            double monthlySalary = getMonthlyIncome() - (tax * getMonthlyIncome());

            availableMoney = monthlySalary - (getGroceries() + getWaterNElectricity() + getTravelling() + getPhoneBill() + getOtherExpenses() + getMonthlyRepayment() + getMonthyRent());
        }

        //returning the calculated available money
        public override double getCalculatedAvailableMoney()
        {
            return availableMoney;
        }

        //displaying the budget
        public void displayBudget()
        {
            //local variable used to increase readability of display statements

            double taxedSalary = getMonthlyIncome() - (getMonthlyIncome() * (getMonthlyTax() / 100))  ;

            Console.WriteLine("BUDGET CALCULATOR\n" +
                              "************************************************");

            Console.WriteLine("TAX:\t\t\t\t" + getMonthlyTax());

            Console.WriteLine("GROCERIES:\t\t\tR" + getGroceries());

            Console.WriteLine("WATER AND ELECTRICITY:\t\tR" + getWaterNElectricity());

            Console.WriteLine("TRAVELLING:\t\t\tR" + getTravelling());

            Console.WriteLine("PHONE BILL:\t\t\tR" + getPhoneBill());

            Console.WriteLine("OTHER EXPENSES:\t\t\tR" + getOtherExpenses());

            Console.WriteLine("MONTHLY RENT:\t\t\tR" + getMonthyRent());

            Console.WriteLine("PROPERTY PRICE:\t\t\tR" + getPropertyPrice());

            Console.WriteLine("DEPOSITE AMOUNT:\t\tR" + getDepositAmount());

            Console.WriteLine("INTEREST CHARGED:\t\t" + getInterestAmount()+"%");

            Console.WriteLine("NUMBER OF MONTHS TO REPAY LOAN: " + getNumOfMonths());

            Console.WriteLine("*************************************************\n" +
                              "GROSS INCOME:\t\t\tR" + getMonthlyIncome());

            Console.WriteLine("*************************************************\n" +
                              "MOTHLY TAXED INCOME:\t\tR" + taxedSalary);

            Console.WriteLine("TOTAL LOAN REPAYMENT:\t\tR" + getTotalRepayment());

            Console.WriteLine("*************************************************\n" +
                              "AVILABLE MONEY:\t\t\tR" + getCalculatedAvailableMoney()+
                              "\n*************************************************");
            Console.ReadKey();
        }
    }
}
