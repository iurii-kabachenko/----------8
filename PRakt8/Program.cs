// See https://aka.ms/new-console-template for more information
using System;
class Program
{

    struct Lud
    {
        public string nametoy;
        public int articul;
        public int price;
        public int vikOT;
        public int vikDO;

        public string Vivod()
        {
            return $"{nametoy,-15} {articul,-10} {price,-8} {vikOT,-8} {vikDO,-8}";
        }
    }

    static int TryReadInt(string prompt)
    {
        int value;
        while (true)
        {
            Console.Write(prompt);
            if (int.TryParse(Console.ReadLine(), out value)) break;
            Console.WriteLine("Некоректне число, спробуйте ще раз.");
        }
        return value;
    }

    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        

        List<Lud> toyes = new List<Lud>();
        int n = 5;

        Console.WriteLine("Введіть дані (Назва / артикул / ціна / вік від / вік до)");

        for (int i = 0; i < n; i++)
        {
            Lud toys = new Lud();

            Console.Write("Назва: ");
            toys.nametoy = Console.ReadLine();

            toys.articul = TryReadInt("Артикул: ");
            toys.price = TryReadInt("Ціна: ");
            toys.vikOT = TryReadInt("Вік від: ");
            toys.vikDO = TryReadInt("Вік до: ");

            toyes.Add(toys);
        }

        Console.WriteLine("\n{0,-15} {1,-10} {2,-8} {3,-8} {4,-8}", "Назва", "Артикул", "Ціна", "Вік від", "Вік до");
        Console.WriteLine(new string('-', 60));

        foreach (var item in toyes)
        {
            Console.WriteLine(item.Vivod());
        }
    }

    //struct Lud
    //{
    //    public string nametoy;
    //    public int articul;
    //    public int price;
    //    public int vikOT;
    //    public int vikDO;

    //    public string Vivod()
    //    {
    //        string s = nametoy + " " + Convert.ToString(articul) + " " + Convert.ToString(price)+" "+Convert.ToString(vikOT)+" "+Convert.ToString(vikDO);
    //        return s;
    //    }
    //}

    //static void Main(string[] args)
    //{
    //    Console.OutputEncoding = System.Text.Encoding.UTF8;
    //    Console.InputEncoding = System.Text.Encoding.UTF8;
    //    List<Lud> toyes=new List<Lud>();
    //    Lud toys;
    //    Lud mx =new Lud();
    //    int n = 5;
    //    Console.WriteLine("Введіть данні(Назва/артикул/ціна/вік від/ вік до)");
    //    for (int i = 0; i < n; i++)
    //    {
    //        Lud toys = new Lud(); // ← створюємо новий об'єкт КОЖНОГО разу

    //        Console.Write("Назва: ");
    //        toys.nametoy = Console.ReadLine();

    //        Console.Write("Артикул: ");
    //        toys.articul = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Ціна: ");
    //        toys.price = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Вік від: ");
    //        toys.vikOT = Convert.ToInt32(Console.ReadLine());

    //        Console.Write("Вік до: ");
    //        toys.vikDO = Convert.ToInt32(Console.ReadLine());

    //        toyes.Add(toys);
    //    }

    //    Console.WriteLine("\n{0,-15} {1,-10} {2,-8} {3,-8} {4,-8}",
    //"Назва", "Артикул", "Ціна", "Вік від", "Вік до");
    //    Console.WriteLine(new string('-', 60));

    //    foreach (var item in toyes)
    //    {
    //        Console.WriteLine("{0,-15} {1,-10} {2,-8} {3,-8} {4,-8}",
    //            item.nametoy, item.articul, item.price, item.vikOT, item.vikDO);
    //    }





    //Console.WriteLine("Список іграшок: ");

    //Console.WriteLine("Назва=====Артикул========Ціна=====Вік від==Вік до");

    //for (int i = 0; i < n; i++)
    //{
    //    Console.WriteLine(toyes[i].Vivod());
    //}







}
