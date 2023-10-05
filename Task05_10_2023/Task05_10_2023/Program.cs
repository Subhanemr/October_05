// Task 1
//namespace Task05_10_2023
//{
//    internal class Program
//    {
//        public static int[] InsertArray(int[] oldArray, params int[] valuesToAdd)
//        {
//            int oldarrlength = oldArray.Length;
//            int newarrlength = valuesToAdd.Length + oldarrlength;
//            int[] newarr = new int[newarrlength];
//            for (int i = 0; i < oldarrlength; i++) 
//            {
//                newarr[i] = oldArray[i];
//            }
//            for (int i = 0;i < valuesToAdd.Length; i++) 
//            {
//                newarr[oldarrlength + i] = valuesToAdd[i];
//            }
//            return newarr;
//        }
//    static void Main(string[] args)
//        {
//            int[] oldarr = { 1, 2, 3, 4 };
//            int[] valuesToAdd = { 5, 6, 7, 8 };
//            int[] newarr = InsertArray(oldarr, valuesToAdd);
//            foreach (int value in newarr)
//            {
//                Console.Write(value + " ");
//            }

//        }
//    }
//}


// Task 2

using System;
public class ATM
{
    public static void Main(string[] args)
    {
        double balance = 500;
        while (true) 
        {
            Console.WriteLine("==========");
            Console.WriteLine("ATM");
            Console.WriteLine("==========");
            Console.WriteLine("ATM Banka xosh gelmisiniz: ");
            Console.WriteLine("[1] Balansi gosterin");
            Console.WriteLine("[2] Pul chixar");
            Console.WriteLine("[3] Cash in ");
            Console.WriteLine("[0] Chix");
            Console.WriteLine("Sechiminizi edin: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 0:
                    { 
                        Console.WriteLine(); 
                        return; 
                    }
                case 1: 
                    {
                        CheckBalance(balance);
                        break;
                    }
                case 2:
                    {
                        double withdrawAmount = WithdrawAmount(balance);
                        balance=withdrawAmount;
                        Console.WriteLine("Balans: " + withdrawAmount);
                        break;
                    }
                case 3:
                    {
                        double cashIn = CashIn(balance);
                        balance = cashIn;
                        Console.WriteLine("Balans: " + cashIn);
                        break;
                    }

            }

        }
    }
    public static void CheckBalance(double balance)
    {
        Console.WriteLine($"Sizin balans: {balance}");
    }
    public static double WithdrawAmount(double balance) 
    {
     
        Console.WriteLine("Chixarmaq istediyiniz meblegi yazin:");
        double amount = double.Parse(Console.ReadLine());
        if (amount < balance && amount>= 1) { return balance -= amount; }
        else { Console.WriteLine("Balansinizda kifayet qeder mebleg yoxdur"); return balance; }

    }
     public static double CashIn(double balance) 
    {
     
        Console.WriteLine("Daxil etmek istediyiniz meblegi yazin:");
        double amount = double.Parse(Console.ReadLine());
        if (amount < balance && amount >= 1) { return balance += amount; }
        else { Console.WriteLine("Duzgun mebleg qeyd edin"); return balance; }

    }

}

