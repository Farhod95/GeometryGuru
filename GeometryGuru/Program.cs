internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n ******************************************************** ");
        Console.WriteLine(" ***    Geometrik shakllar o'lchamlarini xisoblash    *** ");
        Console.WriteLine(" ******************************************************** \n");

        bool savol = false;
        while (!savol)
        {
            savol = true;
            Console.WriteLine(" ===================================================");
            Console.WriteLine(" =       Kerakli shaklni tanlang:                  =");
            Console.WriteLine(" ===================================================");
            Console.WriteLine(" =       Doira: D                                  =");
            Console.WriteLine(" =       Uchburchak: W                             =");
            Console.WriteLine(" =       Teng tomonli uchburchak: U                =");
            Console.WriteLine(" =       Kvadrat: K                                =");
            Console.WriteLine(" =       To'g'ri burchakli to'rtburchak: T         =");
            Console.WriteLine(" ===================================================\n");

            Console.WriteLine(" -------------------------------------------------");
            Console.Write("     Kerakli shaklni klaviaturadan kiriting: ");
            string shakl = Console.ReadLine().ToLower();
            Console.WriteLine(" -------------------------------------------------\n");

            switch (shakl)
            {
                case "d":
                    {
                        Console.WriteLine(" -------------------------------------------------");
                        Console.Write("     Doira radiusini kiriting: R=");
                        if (!double.TryParse(Console.ReadLine(), out double R))
                        {
                            NotoriAmalKirtildi();
                            if (QaytaIshgaTushirish()) {savol=false;continue; }
                            else continue;
                        }
                        Console.WriteLine(" -------------------------------------------------");
                        Doira(R);
                        if (QaytaIshgaTushirish()) { savol = false; continue; }
                        else continue;
                        break;
                    }
                case "w":
                    {
                        Console.WriteLine(" -------------------------------------------------");
                        Console.Write(" Uchburchak birinchi tomonini kiriting: a=");
                        if (!double.TryParse(Console.ReadLine(), out double a))
                        {
                            NotoriAmalKirtildi();
                            if (QaytaIshgaTushirish()) { savol = false; continue; }
                            else continue;
                        }
                        Console.Write("\n Uchburchak Ikkinchi tomonini kiriting: b=");
                        if (!double.TryParse(Console.ReadLine(), out double b))
                        {
                            NotoriAmalKirtildi();
                            if (QaytaIshgaTushirish()) { savol = false; continue; }
                            else continue;
                        }
                        Console.Write($"\n Uchburchak Uchinchi tomonini kiriting {Math.Abs(a - b)} < c < {a + b}: c=");
                        if (!double.TryParse(Console.ReadLine(), out double c))
                        {
                            NotoriAmalKirtildi();
                            if (QaytaIshgaTushirish()) { savol = false; continue; }
                            else continue;
                        }
                        if (!(Math.Abs(a - b) < c) || !(c < a + b))
                        {
                            NotoriAmalKirtildi();
                            if (QaytaIshgaTushirish()) { savol = false; continue; }
                            else continue;
                        }
                        Console.WriteLine(" -------------------------------------------------");
                        Uchburchak(a, b, c);
                        if (QaytaIshgaTushirish()) { savol = false; continue; }
                        else continue;
                    }
                case "u":
                    {
                        Console.WriteLine(" -------------------------------------------------");
                        Console.Write(" Teng tomonli uchburchak tomoni uzunligini kiriting: a=");
                        if (!double.TryParse(Console.ReadLine(), out double a))
                        {
                            NotoriAmalKirtildi();
                            if (QaytaIshgaTushirish()) { savol = false; continue; }
                            else continue;
                        }
                        Console.WriteLine(" -------------------------------------------------");
                        TengTomonliUchburchak(a);
                        if (QaytaIshgaTushirish()) { savol = false; continue; }
                        else continue;
                    }
                case "k":
                    {
                        Console.WriteLine(" -------------------------------------------------");
                        Console.Write(" Kvadrat tomoni uzunligini kiriting: a=");
                        if (!double.TryParse(Console.ReadLine(), out double a))
                        {
                            NotoriAmalKirtildi();
                            if (QaytaIshgaTushirish()) { savol = false; continue; }
                            else continue;
                        }
                        Console.WriteLine(" -------------------------------------------------");
                        Kvadrat(a);
                        if (QaytaIshgaTushirish()) { savol = false; continue; }
                        else continue;
                    }
                case "t":
                    {
                        Console.WriteLine(" -------------------------------------------------");
                        Console.Write(" To'g'ri burchakli to'rtburchakning eni uzunligini kiriting: a=");
                        if (!double.TryParse(Console.ReadLine(), out double a))
                        {
                            NotoriAmalKirtildi();
                            if (QaytaIshgaTushirish()) { savol = false; continue; }
                            else continue;
                        }
                        Console.Write("\n To'g'ri burchakli to'rtburchakning bo'yi uzunligini kiriting: b=");
                        if (!double.TryParse(Console.ReadLine(), out double b))
                        {
                            NotoriAmalKirtildi();
                            if (QaytaIshgaTushirish()) { savol = false; continue; }
                            else continue;
                        }
                        Console.WriteLine(" -------------------------------------------------");
                        TogriBurchakliTortburchak(a, b);
                        if (QaytaIshgaTushirish()) { savol = false; continue; }
                        else continue;
                    }
                default:
                    {
                        NotoriAmalKirtildi();
                        if (QaytaIshgaTushirish()) { savol = false; continue; }
                        else continue;
                    }
            }
        }
    }

    static void Doira(double R)
    {
        Console.WriteLine("\n +------------------------------------------------------------+");
        Console.WriteLine($" | Doira diametri => P=2*R = {2 * R}                           |");
        Console.WriteLine($" | Doira uzunligi  => L=2*π*R = {2 * Math.PI * R}              |");
        Console.WriteLine($" | Doira yuzi     => S=π*R^2 = {Math.PI * Math.Pow(R, 2)}      |");
        Console.WriteLine(" +--------------------------------------------------------------+\n");
    }

    static void Uchburchak(double a, double b, double c)
    {
        double P = a + b + c;
        Console.WriteLine("\n +-------------------------------------------------------------------------------------------------------------+");
        Console.WriteLine($" | Uchburchak perimetri => P=a+b+c = {P}                                                                        |");
        Console.WriteLine($" | Uchburchak yuzi      => S=√p(p-a)(p-b)(p-c) = {Math.Sqrt((P / 2) * (P / 2 - a) * (P / 2 - b) * (P / 2 - c))} |");
        Console.WriteLine(" +---------------------------------------------------------------------------------------------------------------+\n");
    }

    static void TengTomonliUchburchak(double a)
    {
        Console.WriteLine("\n +-----------------------------------------------------------------------------------------------------+");
        Console.WriteLine($" | Teng tomonli uchburchak perimetri => P=3*a = {3 * a}                                                 |");
        Console.WriteLine($" | Teng tomonli uchburchak balandligi  => h=(√3/2)*a = {Math.Sqrt(3) / 2 * a}                           |");
        Console.WriteLine($" | Teng tomonli uchburchak yuzi          => S=(√3/4)*a^2 = {Math.Sqrt(3) / 4 * Math.Pow(a, 2)}          |");
        Console.WriteLine(" +-------------------------------------------------------------------------------------------------------+\n");
    }

    static void Kvadrat(double a)
    {
        Console.WriteLine("\n  +-----------------------------------------------------------------------------------------------+");
        Console.WriteLine($"  | Kvadrat perimetri => P=4*a = {4 * a}                                                           |");
        Console.WriteLine($"  | Kvadrat yuzi      => S=a^2 = {Math.Pow(a, 2)}                                                  |");
        Console.WriteLine("  +-------------------------------------------------------------------------------------------------+\n");
    }

    static void TogriBurchakliTortburchak(double a, double b)
    {
        Console.WriteLine("\n   +---------------------------------------------------------------------------------------+");
        Console.WriteLine($"   | To'g'ri burchakli to'rtburchak perimetri => P=(a+b)*2 = {(a + b) * 2}                  |");
        Console.WriteLine($"   | To'g'ri burchakli to'rtburchak yuzi      => S=a*b = {a * b}                            |");
        Console.WriteLine("   +-----------------------------------------------------------------------------------------+\n");
    }

    static bool QaytaIshgaTushirish()
    {
        Console.Write("\n Dasturni qayta ishga tushirishni istaysizmi ? (yes/no): ");
        return Console.ReadLine().ToLower() == "yes";
    }

    static void NotoriAmalKirtildi()
    {
        Console.WriteLine("\n +----------------------------------------------------------------+");
        Console.WriteLine(" | Noto'g'ri amalni kiritdingiz, qayta urinib koring!               |");
        Console.WriteLine(" +------------------------------------------------------------------+\n");
    }
}
