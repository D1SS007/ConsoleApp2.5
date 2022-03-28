using System;

namespace ConsoleApp2._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rubToUsd = 90; 
            int usdToRub = 110;
            int rubToEur = 120;
            int eurToRub = 140;
            float usdToEur = 1.1f;
            float eurToUsd = 1.2f;

            float usd = 100;
            float eur = 100;
            float rub = 100;
            float exchangeCount;

            string userInput;
            string userInput2;
            string userInput3;
            string userInput4;

            string exitWord = "";

            while (exitWord != "exit")
            {
                Console.WriteLine($"Ваш баланс: {rub} рублей, {usd} долларов, {eur} евро");
                Console.WriteLine("Какую валюту меняем?\n1-рубли\n2-доллары\n3-евро");

                userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("На какую валюту менаяем?\n1-доллары\n2-евро");
                        userInput2 = Console.ReadLine();

                        switch (userInput2)
                        {
                            case "1":
                                Console.WriteLine("Сколько обменять");
                                exchangeCount = Convert.ToSingle(Console.ReadLine());
                                if (rub >= exchangeCount)
                                {
                                    rub -= exchangeCount;
                                    usd += exchangeCount / rubToUsd;
                                }
                                else
                                {
                                    Console.WriteLine("Недостаточное количество рублей");
                                }
                                break;
                            case "2":
                                Console.WriteLine("Сколько обменять");
                                exchangeCount = Convert.ToSingle(Console.ReadLine());
                                if (rub >= exchangeCount)
                                {
                                    rub -= exchangeCount;
                                    eur += exchangeCount / rubToEur;
                                }
                                else
                                {
                                    Console.WriteLine("Недостаточное количество рублей");
                                }
                                break;
                        }
                        break;

                    case "2":
                        Console.WriteLine("На какую валюту менаяем?\n1-рубли\n2-евро");
                        userInput3 = Console.ReadLine();

                        switch (userInput3)
                        {
                            case "1":
                                Console.WriteLine("Сколько обменять");
                                exchangeCount = Convert.ToSingle(Console.ReadLine());
                                if (usd >= exchangeCount)
                                {
                                    usd -= exchangeCount;
                                    rub += exchangeCount / usdToRub;
                                }
                                else
                                {
                                    Console.WriteLine("Недостаточное количество долларов");
                                }
                                break;

                            case "2":
                                Console.WriteLine("Сколько обменять");
                                exchangeCount = Convert.ToSingle(Console.ReadLine());
                                if (usd >= exchangeCount)
                                {
                                    usd -= exchangeCount;
                                    eur += exchangeCount / usdToEur;
                                }
                                else
                                {
                                    Console.WriteLine("Недостаточное количество долларов");
                                }
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine("На какую валюту менаяем?\n1-рубли\n2-доллары");
                        userInput4 = Console.ReadLine();

                        switch (userInput4)
                        {
                            case "1":
                                Console.WriteLine("");
                                exchangeCount = Convert.ToSingle(Console.ReadLine());
                                if (eur >= exchangeCount)
                                {
                                    eur -= exchangeCount;
                                    rub += exchangeCount / eurToRub;
                                }
                                else
                                {
                                    Console.WriteLine("Недостаточное количество евро");
                                }
                                break;

                            case "2":
                                Console.WriteLine("");
                                exchangeCount = Convert.ToSingle(Console.ReadLine());
                                if (eur >= exchangeCount)
                                {
                                    eur -= exchangeCount;
                                    usd += exchangeCount / eurToUsd;
                                }
                                else
                                {
                                    Console.WriteLine("Недостаточное количество евро");
                                }
                                break;
                        }
                        break;
                }
                Console.WriteLine($"Ваш баланс: {rub} рублей, {usd} долларов, {eur} евро");
                Console.WriteLine("Введите 1 чтобы продолжить работу с обменником , введите exit что бы выйти");
                exitWord = Console.ReadLine();
            }              
        }
    }
}
