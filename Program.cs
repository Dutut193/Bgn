using System;

class CurrencyConverter
{
    static void Main()
    {
        Console.WriteLine("Calculator");
        Console.WriteLine("Моля, въведете вид на парите (например BGN): ");
        string money = Console.ReadLine().ToLower();

        if (money == "bgn")
        {
            Console.WriteLine("Моля, въведете стойността в BGN: ");
            int bgn = int.Parse(Console.ReadLine());
            Console.WriteLine("Стойността на парите е: " + bgn + " BGN");

            Console.WriteLine("Моля, въведете в каква валута искате да конвертирате (euro, usd): ");
            string money2 = Console.ReadLine().ToLower();

            if (money2 == "euro")
            {
                // Преобразуване от BGN към EUR
                int euro = (int)(bgn * 0.511);  // Приемаме, че 1 BGN = 0.511 EUR
                Console.WriteLine("Стойността на парите е: " + euro + " евро.");
            }
            else if (money2 == "usd")
            {
                // Преобразуване от BGN към USD
                int usd = (int)(bgn * 0.577);  // Приемаме, че 1 BGN = 0.577 USD
                Console.WriteLine("Стойността на парите е: " + usd + " USD.");
            }
            else
            {
                Console.WriteLine("Невалидна валута.");
            }
        }
        else if (money == "euro")
        {
            Console.WriteLine("Моля, въведете стойността в евро: ");
            int euro = int.Parse(Console.ReadLine());
            Console.WriteLine("Стойността на парите е: " + euro + " евро.");

            Console.WriteLine("Моля, въведете в каква валута искате да конвертирате (bgn, usd): ");
            string money2 = Console.ReadLine().ToLower();

            if (money2 == "bgn")
            {
                // Преобразуване от EUR към BGN
                int bgn = (int)(euro * 1.956);  // Приемаме, че 1 EUR = 1.956 BGN
                Console.WriteLine("Стойността на парите е: " + bgn + " BGN.");
            }
            else if (money2 == "usd")
            {
                // Преобразуване от EUR към USD
                int usd = (int)(euro * 1.14);  // Приемаме, че 1 EUR = 1.14 USD
                Console.WriteLine("Стойността на парите е: " + usd + " USD.");
            }
            else
            {
                Console.WriteLine("Невалидна валута.");
            }
        }
        else if (money == "usd")
        {
            Console.WriteLine("Моля, въведете стойността в USD: ");
            int usd = int.Parse(Console.ReadLine());
            Console.WriteLine("Стойността на парите е: " + usd + " USD.");

            Console.WriteLine("Моля, въведете в каква валута искате да конвертирате (bgn, euro): ");
            string money2 = Console.ReadLine().ToLower();

            if (money2 == "bgn")
            {
                // Преобразуване от USD към BGN
                int bgn = (int)(usd * 1.735);  // Приемаме, че 1 USD = 1.735 BGN
                Console.WriteLine("Стойността на парите е: " + bgn + " BGN.");
            }
            else if (money2 == "euro")
            {
                // Преобразуване от USD към EUR
                int euro = (int)(usd * 0.879);  // Приемаме, че 1 USD = 0.879 EUR
                Console.WriteLine("Стойността на парите е: " + euro + " евро.");
            }
            else
            {
                Console.WriteLine("Невалидна валута.");
            }
        }
        else
        {
            Console.WriteLine("Невалиден вход. Моля, въведете валидна валута (BGN, EUR, USD).");
        }
    }
}
