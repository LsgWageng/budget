using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budget
{
    class Program
    {
        static void Main(string[] args)
        {
            //obj object is used to access and call methods from the homeLoan class
            homeLoan obj = new homeLoan();

            int userResponse = 0;

            obj.setMonthlyIncome();

            obj.setMonthlyTax();

            obj.setGroceries();

            obj.setWaterNElectricity();

            obj.setTravelling();

            obj.setPhoneBill();

            obj.setOtherExpenses();

            //user will choose whether they want to buy or rent a property or exit the program

            Console.WriteLine("WOULD YOU LIKE TO RENT OR PURCHASE A PROPERTY \nPRESS (1) TO RENT OR (2) TO BUY OR ANY BUTTON TO EXIT:");

            userResponse = Convert.ToInt32(Console.ReadLine());

            //if they enter 1, the program will ask for the monthly rent that they pay

            if (userResponse == 1)
            {
                obj.setMonthlyRent();
            }

            //if they choose 2, they will be reqired to enter the price, deposit, interest and number of months for the property

            else if (userResponse == 2)
            {
                obj.setPropertyPrice();

                obj.setDepositAmount();

                obj.setInterestAmount();

                obj.setNumOfMonths();

                obj.calculateTotalRepayment();

                obj.calculateMonthlyRepayment();

                obj.calculatingThirdOfgross();

                //alerting the user that possibility of loan approval is unlikely

                if (obj.getMonthlyRepayment() > obj.getThirdOfGross())
                {
                    System.Media.SystemSounds.Beep.Play();

                    Console.WriteLine("*****POSSIBILITY OF LOAN REPAYMENT IS UNLIKELY******");
                }

            }

            //if the user chooses the third option then the program will exit

            else
            {
                System.Environment.Exit(0);
            }

            obj.calculatedAvailableMoney();
            obj.displayBudget();
        }
    }
}
