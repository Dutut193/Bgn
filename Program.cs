using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.WriteLine("Изберете език / Choose language: (BG/EN)");
        string language = Console.ReadLine().ToLower();

        if (language == "en")
        {
            Console.WriteLine("Calculator");
            Console.WriteLine("Please enter the type of currency (e.g., BGN): ");
        }
        else
        {
            Console.WriteLine("Калкулатор");
            Console.WriteLine("Моля, въведете вид на парите (например BGN): ");
        }
        string money = Console.ReadLine().ToLower();

        if (money == "bgn")
        {
            if (language == "en")
            {
                Console.WriteLine("Please enter the amount in BGN: ");
            }
            else
            {
                Console.WriteLine("Моля, въведете стойността в BGN: ");
            }
            int bgn = int.Parse(Console.ReadLine());
            if (language == "en")
            {
                Console.WriteLine("The amount is: " + bgn + " BGN");
            }
            else
            {
                Console.WriteLine("Стойността на парите е: " + bgn + " BGN");
            }
            if (language == "en")
            {
                Console.WriteLine("Enter the currency to convert to (euro, usd): ");
            }
            else
            {
                Console.WriteLine("Моля, въведете в каква валута искате да конвертирате (euro, usd): ");
            }
            string money2 = Console.ReadLine().ToLower();

            if (money2 == "euro")
            {
                int euro = (int)(bgn * 0.511);
                if (language == "en")
                {
                    Console.WriteLine("The amount is: " + euro + " EUR.");
                }
                else
                {
                    Console.WriteLine("Стойността на парите е: " + euro + " евро.");
                }
            }
            else if (money2 == "usd")
            {
                int usd = (int)(bgn * 0.577);
                if (language == "en")
                {
                    Console.WriteLine("The amount is: " + usd + " USD.");
                }
                else
                {
                    Console.WriteLine("Стойността на парите е: " + usd + " USD.");
                }  
            }
            else
            {
                Console.WriteLine(language == "en" ? "Invalid currency." : "Невалидна валута.");
            }
        }
        else if (money == "euro")
        {
            if (language == "en")
            {
                Console.WriteLine("Please enter the amount in EUR: ");
            }   
            else
            {
                Console.WriteLine("Моля, въведете стойността в евро: ");
            }
            int euro = int.Parse(Console.ReadLine());
            if (language == "en")
            {
                Console.WriteLine("The amount is: " + euro + " EUR.");
            }
            else
            {
                Console.WriteLine("Стойността на парите е: " + euro + " евро.");
            }
            if (language == "en")
            {
                Console.WriteLine("Enter the currency to convert to (bgn, usd): ");
            }
            else
            {
                Console.WriteLine("Моля, въведете в каква валута искате да конвертирате (bgn, usd): ");
            }

            string money2 = Console.ReadLine().ToLower();

            if (money2 == "bgn")
            {
                int bgn = (int)(euro * 1.956);
                if (language == "en")
                {
                    Console.WriteLine("The amount is: " + bgn + " BGN.");
                }
                else
                {
                    Console.WriteLine("Стойността на парите е: " + bgn + " BGN.");
                }  
            }
            else if (money2 == "usd")
            {
                int usd = (int)(euro * 1.14);
                if (language == "en")
                {
                    Console.WriteLine("The amount is: " + usd + " USD.");
                }
                else
                {
                    Console.WriteLine("Стойността на парите е: " + usd + " USD.");
                } 
            }
            else
            {
                Console.WriteLine(language == "en" ? "Invalid currency." : "Невалидна валута.");
            }
        }
        else if (money == "usd")
        {
            if (language == "en")
            {
                Console.WriteLine("Please enter the amount in USD: ");
            }
            else
            {
                Console.WriteLine("Моля, въведете стойността в USD: ");
            }

            int usd = int.Parse(Console.ReadLine());

            if (language == "en")
            {
                Console.WriteLine("The amount is: " + usd + " USD.");
            }
            else
            {
                Console.WriteLine("Стойността на парите е: " + usd + " USD.");
            }

            if (language == "en")
            {
                Console.WriteLine("Enter the currency to convert to (bgn, euro): ");
            }
            else
            {
                Console.WriteLine("Моля, въведете в каква валута искате да конвертирате (bgn, euro): ");
            }  

            string money2 = Console.ReadLine().ToLower();

            if (money2 == "bgn")
            {
                int bgn = (int)(usd * 1.735);
                if (language == "en")
                {
                    Console.WriteLine("The amount is: " + bgn + " BGN.");
                }
                else
                {
                    Console.WriteLine("Стойността на парите е: " + bgn + " BGN.");
                } 
            }
            else if (money2 == "euro")
            {
                int euro = (int)(usd * 0.879);
                if (language == "en")
                {
                    Console.WriteLine("The amount is: " + euro + " EUR.");
                }
                else
                {
                    Console.WriteLine("Стойността на парите е: " + euro + " евро.");
                }
            }
            else
            {
                Console.WriteLine(language == "en" ? "Invalid currency." : "Невалидна валута.");
            }
        }
        else
        {
            Console.WriteLine(language == "en" ? "Invalid input. Please enter a valid currency (BGN, EUR, USD)."
                                               : "Невалиден вход. Моля, въведете валидна валута (BGN, EUR, USD).");
        }
    }
}
