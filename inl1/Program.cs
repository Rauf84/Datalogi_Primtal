using System;
using System.Collections.Generic;

namespace inl1
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfInt = new List<int>();
            string choise = "";

            do
            {
                Console.WriteLine("-----------Menu-----------");
                Console.WriteLine("1. Mata in ett heltal");
                Console.WriteLine("2. Visa listan med primtal");
                Console.WriteLine("q. Avsluta programmet");
                Console.Write("Mata in ditt val: ");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Console.Write("Mata in ett heltal: ");
                        string input = Console.ReadLine();
                        if (CheckInput(input))
                        {
                            int addedInput = Convert.ToInt32(input);
                            if (CheckPrime(addedInput))
                            {
                                listOfInt.Add(addedInput);
                            }
                            else
                                {
                                    Console.WriteLine(addedInput + " är inte ett primtal.");
                                    Console.WriteLine("Press any key to continue");
                                    Console.ReadKey();
                                }
                            }
                        else
                        {
                            Console.WriteLine("Fel värdetyp. Vänligen mata in ett heltal");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                        }
                        break;
                    case "2":
                        if (listOfInt.Count > 0)
                        {
                            foreach (var i in listOfInt)
                            {
                                Console.Write(i + " ");
                            }
                            Console.WriteLine();
                        }
                        else
                        {
                            Console.WriteLine("Listan är tom. Välj menuval 1 för att lägga till ett tal i listan");
                            Console.WriteLine("Press any key to continue");
                            Console.ReadKey();
                        }
                            break;
                    case "q":
                        Console.WriteLine("Programmet avslutas!");
                        break;
                    default:
                        Console.WriteLine("Fel val. Vänligen försök igen");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;

                }
            }
            while (choise != "q");
        }

        static bool CheckInput(string input)
        {
            try
            {
                int i = Convert.ToInt32(input);
                return true;
            }
            catch
            {
                return false;
            }
        }

        static bool CheckPrime (int i)
        {
            int count = 0;
            for (int p = 2; p <= i; p++)
            {
                if (i%p == 0)
                {
                    count++;
                }
            }
            if (i==1 || i==0  || i == -1 || count > 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
