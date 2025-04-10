namespace _08.AccountBalance
{
    internal class AccountBalance
    {
        static void Main(string[] args)
        {
            double balance = 0;
            string line; //                                
            while ((line = Console.ReadLine()) != "End")            
            {                
                double moneyAmount = double.Parse(line);
                balance += moneyAmount;
                if (moneyAmount >= 0)
                {
                    Console.WriteLine($"Increase: {moneyAmount:F2}");
                }
                else
                {
                    Console.WriteLine($"Decrease: {Math.Abs(moneyAmount):F2}");
                }
            }

            Console.WriteLine($"Balance: {balance:F2}");
        }
    }
}