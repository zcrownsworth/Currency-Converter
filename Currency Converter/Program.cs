using System;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Привет");
            Console.WriteLine("Выбери валюту для конвертации");
            Console.WriteLine("1-UDS.2-EUR.3-CHF.4-GBP.5-FPY.6-UAH.7-CAD");
            string selection = Console.ReadLine();
            Console.WriteLine("Сумма для конвертации");
            string value = Console.ReadLine();

            /*
             /
               Совет от Патрицио , значения валют брать из интернета
               Некст раз
            /
           */

            double[] Currencies = new double[7];

            Currencies[0] = 72.66; //UDS
            Currencies[1] = 85.36; //EUR
            Currencies[2] = 78.48; //CHF
            Currencies[3] = 100.08; //GBP
            Currencies[4] = 0.66; //FPY
            Currencies[5] = 2.72; //UAH
            Currencies[6] = 57.29; //CAD


            switch (selection)
            {
                case "1":                
                    double USD = Currencies[0] * Convert.ToDouble(value);
                    Console.WriteLine($"{USD}");
                    break;
                case "2":
                    double EUR = Currencies[1] * Convert.ToDouble(value);
                    Console.WriteLine($"{EUR}");

                    break;
                case "3":
                    double CHF = Currencies[2] * Convert.ToDouble(value);
                    Console.WriteLine($"{CHF}");


                    break;
                case "4":
                    double GBP = Currencies[3] * Convert.ToDouble(value);
                    Console.WriteLine($"{GBP}");

                    break;
                case "5":
                    double FPY = Currencies[4] * Convert.ToDouble(value);
                    Console.WriteLine($"{FPY}");

                    break;
                case "6":
                    double UAH = Currencies[5] * Convert.ToDouble(value);
                    Console.WriteLine($"{UAH}");

                    break;
                case "7":
                    double CAD = Currencies[6] * Convert.ToDouble(value);
                    Console.WriteLine($"{CAD}");

                    break;
                default:
                    Console.WriteLine("Вы ввели некорректное число");
                    break;
            }

            Console.ReadKey();

           

        }
    }
}
