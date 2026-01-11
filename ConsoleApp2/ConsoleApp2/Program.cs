using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== Ласкаво просимо до Cafe Menu vafelka ===\n");

        Console.WriteLine("Бургер       - 120 грн/шт");
        Console.WriteLine("Картопля фрі - 55 грн/порція");
        Console.WriteLine("Піцца        - 180 грн/шт");
        Console.WriteLine("Кока-кола    - 35 грн/склянка");
        Console.WriteLine("Кава         - 45 грн/чашка");
        Console.WriteLine("коньяк-100мл   - 120 грн/шт\n");

        
        double burgerPrice = 120;
        double friesPrice = 55;
        double pizzaPrice = 180;
        double colaPrice = 35;
        double coffeePrice = 45;
        double cognacPrice = 75;

        
        Console.Write("Введіть кількість бургерів: ");
        double burgers = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість картоплі фрі: ");
        double fries = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість піц: ");
        double pizzas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість склянок коли: ");
        double colas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість чашок кави: ");
        double coffees = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введіть кількість коньячка: ");
        double cognac = Convert.ToDouble(Console.ReadLine());

       
        double total = burgers * burgerPrice +
                       fries * friesPrice +
                       pizzas * pizzaPrice +
                       colas * colaPrice +
                       coffees * coffeePrice +
                       cognac * cognacPrice;

        
        Random rnd = new Random();
        double discount = rnd.Next(5, 16); // 5 до 15 %
        double discountAmount = total * (discount / 100);
        double totalWithDiscount = total - discountAmount;

    
        Console.WriteLine($"\nЗагальна сума: {total:F2} грн");
        Console.WriteLine($"Знижка: {discount}%");
        Console.WriteLine($"Сума зі знижкою: {totalWithDiscount:F2} грн");
    }
}