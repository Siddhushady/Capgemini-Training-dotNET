using System;
using System.Reflection.Metadata;
using System.Security;
using System.Text.RegularExpressions;

namespace Methods
{
    public class Method
    {
        public static void PosOrNeg()
        {
            Console.WriteLine("Sign of a number \n");

            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            String sign = n > 0 ? "Postive" : "Negative";
            Console.WriteLine("Entered number is " + sign + "\n");
        }

        public static void ATMWithdrawal()
        {
            Console.WriteLine("ATM Withdrawal Logic \n");

            int minBal = 1000;
            int maxLimit = 20000;
            Console.WriteLine("Mininum Balance must be " + minBal + " and the daily maximum withdraw limit is " + maxLimit);

            Console.WriteLine("Enter current balance: ");
            int curBal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter amount you wish to withdraw: ");
            int withAmt = Convert.ToInt32(Console.ReadLine());

            if (curBal > minBal && withAmt < maxLimit)
            {
                Console.WriteLine("Withdrawal successful \n");
            }
            else
            {
                if (curBal < minBal && withAmt > maxLimit)
                {
                    Console.WriteLine("Withdraw request rejected. \nReason: \n1. Current balance does not satisfy minimum balance requirement \n2. The amount you wish to withdraw is over the daily limit \n");
                }
                else if (curBal < minBal)
                {
                    Console.WriteLine("Withdraw request rejected. \nReason: \n1. Current balance does not satisfy minimum balance requirement \n");
                }
                else
                {
                    Console.WriteLine("Withdraw request rejected. \nReason: \n1. The amount you wish to withdraw is over the daily limit \n");
                }
            }
        }

        public static void PasswordChecker()
        {
            Console.WriteLine("Passsword Strength Checker \n");

            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            bool hasLength = password.Length >= 8;
            bool hasDigit = Regex.IsMatch(password, @"\d");
            bool hasSpecial = Regex.IsMatch(password, @"[^a-zA-Z0-9]");

            if (hasLength && hasDigit && hasSpecial)
                Console.WriteLine("Strong");
            else if (hasLength && (hasDigit || hasSpecial))
                Console.WriteLine("Medium");
            else
                Console.WriteLine("Weak");
        }

        public static void AbsoluteValue()
        {
            Console.WriteLine("Absolute value of a number \n");

            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int abs = n < 0 ? -n : n;
            Console.WriteLine("Absolute value of the number is " + abs + "\n");
        }

        public static void Divisibility()
        {
            Console.WriteLine("Check if a number is divisible by 3 or 5 but not both \n");

            Console.WriteLine("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            if ((n % 3 == 0) ^ (n % 5 == 0))
                Console.WriteLine("Yes \n");
            else
                Console.WriteLine("No \n");

        }

        public static void TempLevel()
        {
            Console.WriteLine("Level of temperature \n");

            Console.WriteLine("Enter temperature: ");
            double temp = Convert.ToDouble(Console.ReadLine());

            switch (temp)
            {
                case < 0:
                    Console.WriteLine("Freezing \n");
                    break;

                case <= 20:
                    Console.WriteLine("Cold \n");
                    break;

                case <= 35:
                    Console.WriteLine("Warm \n");
                    break;

                default:
                    Console.WriteLine("Hot \n");
                    break;
            }
        }

        public static void FoodOrder()
        {
            Console.WriteLine("Food Order Acceptance status \n");

            Console.WriteLine("Is restaurant open? (Yes/No)");
            bool restaurantOpen = Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase);

            Console.WriteLine("Is delivery partner available? (Yes/No)");
            bool deliveryAvailable = Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase);

            Console.WriteLine("Is customer Prime? (Yes/No)");
            bool isPrimeCustomer = Console.ReadLine().Equals("Yes", StringComparison.OrdinalIgnoreCase);

            Console.WriteLine("Enter order amount:");
            int orderAmount = Convert.ToInt32(Console.ReadLine());

            if (restaurantOpen && deliveryAvailable &&
                (isPrimeCustomer || orderAmount >= 200))
                Console.WriteLine("Order Accepted");
            else
                Console.WriteLine("Order Rejected");
        }
    }
}
