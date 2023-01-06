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
            
            Console.WriteLine("WELCOME TO THE BUDGET CALCULATOR");

            int userResponse = 0;

               obj. setGrossMonthlyIncome();

               obj. setMonthlyTax();

               obj. setGroceries();

               obj. setWaterNElectricity();

               obj. setTravelling();

               obj. setPhoneBill();

               obj. setOtherExpenses();


            //user will choose whether they want to buy or rent a property or exit the program

            Console.WriteLine(
                               "\nPRESS (1) TO RENT PROPERTY " +
                               "\nPRESS (2) TO BUY PROPERTY " +
                               "\nPRESS (3) TO BUY A CAR ");

              userResponse = Convert.ToInt32(Console.ReadLine());

              //if they enter 1, the program will ask for the monthly rent that they pay

              if (userResponse == 1)
              {
                  obj.setMonthlyRent();

                  obj.rentPropertyBudget();
              }

               //if they choose 2, they will be reqired to enter the price, deposit, interest and number of months for the property

                  else if (userResponse == 2)
                  {
                    obj.setPropertyPrice();

                    obj.setDepositAmount();

                    obj.setInterestAmount();

                    obj.setNumOfMonths();

                    obj.calculateTotalPropertyRepayment();

                    obj.calculateMonthlyRepayment();

                    obj.calculatingThirdOfgross();

                   //alerting the user that possibility of loan approval is unlikely

                    if (obj.getMonthlyRepayment() > obj.getThirdOfGross())
                    {
                        System.Media.SystemSounds.Beep.Play();

                        Console.WriteLine("*****POSSIBILITY OF LOAN REPAYMENT IS UNLIKELY******");
                    }

                    obj.buyPropertyBudget();

                  }

              //if they choose 3, they will be be required to enter all of the details related to the car
              else if (userResponse == 3)
              {
                obj.setModelNMake();

                obj.setPurchasePrise();

                obj.setVehicleDeposit();

                obj.setVehicleInterestRate();

                obj.setInsurance();

                obj.buyVehicleBudget();
              }

              //if the user chooses the third option then the program will exit

              else
              {
                  System.Environment.Exit(0);
              }

            Console.ReadKey();
        }
    }
}
