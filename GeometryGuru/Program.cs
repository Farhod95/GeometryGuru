internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("\n *** Geometrik shakllar o'lchamlarini xisoblash *** \n");
        while (true)
        {
            Console.WriteLine("\n Kerakli shaklni tanlang: \n");
            Console.WriteLine(" Doira: D");
            Console.WriteLine(" Uchburchak: W ");
            Console.WriteLine(" Teng tomonli uchburchak: U");
            Console.WriteLine(" Kvadrat: K");
            Console.WriteLine(" To'g'ri burchakli to'rtburchak: T \n");

            Console.Write(" Kerakli shaklni klaviaturadan kiriting:");
            string shakl = Console.ReadLine().ToLower();

            switch (shakl)
            {
                case "d":
                    {
                        Console.Write("\n Doira radiusini kiriting: R=");
                        if (!double.TryParse(Console.ReadLine(), out double R))
                        {
                            NotoriAmalKirtildi();
                            if (!QaytaIshgaTushirish()) return;
                            else continue;
                        }

                        Doira(R);

                        if (!QaytaIshgaTushirish()) return;
                        break;
                    }
                case "w":
                    {
                        Console.Write("\n Uchburchak birinchi tomonini kiriting: a=");
                        if (!double.TryParse(Console.ReadLine(), out double a))
                        {
                            NotoriAmalKirtildi();
                            if (!QaytaIshgaTushirish()) return;
                            else continue;
                        }
                        Console.Write("\n Uchburchak Ikkinchi tomonini kiriting: b=");
                        if (!double.TryParse(Console.ReadLine(), out double b))
                        {
                            NotoriAmalKirtildi();
                            if (!QaytaIshgaTushirish()) return;
                            else continue;
                        }
                        Console.Write($"\n Uchburchak Uchinchi tomonini kiriting {Math.Abs(a - b)} < c < {a + b}: c=");
                        if (!double.TryParse(Console.ReadLine(), out double c))
                        {
                            NotoriAmalKirtildi();
                            if (!QaytaIshgaTushirish()) return;
                            else continue;
                        }
                        if (!(Math.Abs(a - b) < c) || !(c < a + b))
                        {
                            NotoriAmalKirtildi();
                            if (!QaytaIshgaTushirish()) return;
                            else continue;

                        }
                        Uchburchak(a, b, c);

                        if (!QaytaIshgaTushirish()) return;
                        break;
                    }
                case "u":
                    {
                        Console.Write("\n Teng tomonli uchburchak tomoni uzunligini kiriting: a=");
                        if (!double.TryParse(Console.ReadLine(), out double a))
                        {
                            NotoriAmalKirtildi();
                            if (!QaytaIshgaTushirish()) return;
                            else continue;
                        }

                        TengTomonliUchburchak(a);

                        if (!QaytaIshgaTushirish()) return;
                        break;
                    }
                case "k":
                    {
                        Console.Write("\n Kvadrat tomoni uzunligini kiriting: a=");
                        if (!double.TryParse(Console.ReadLine(), out double a))
                        {
                            NotoriAmalKirtildi();
                            if (!QaytaIshgaTushirish()) return;
                            else continue;
                        }
                        Kvadrat(a);

                        if (!QaytaIshgaTushirish()) return;
                        break;
                    }
                case "t":
                    {
                        Console.Write("\n To'g'ri burchakli to'rtburchakning eni uzunligini kiriting: a=");
                        if (!double.TryParse(Console.ReadLine(), out double a))
                        {
                            NotoriAmalKirtildi();
                            if (!QaytaIshgaTushirish()) return;
                            else continue;
                        }
                        Console.Write("\n To'g'ri burchakli to'rtburchakning bo'yi uzunligini kiriting: b=");
                        if (!double.TryParse(Console.ReadLine(), out double b))
                        {
                            NotoriAmalKirtildi();
                            if (!QaytaIshgaTushirish()) return;
                            else continue;
                        }
                        TogriBurchakliTortburchak(a, b);

                        if (!QaytaIshgaTushirish()) return;
                        break;
                    }
                default:
                    {
                        NotoriAmalKirtildi();

                        QaytaIshgaTushirish();
                        break;
                    }
            }
        }
    }

    static void Doira(double R)
    {
        Console.WriteLine($"\n Doira diametri => P=2*R = {2 * R} !");
        Console.WriteLine($"\n Doira uzunligi  => L=2*𝜋*R = {2 * Math.PI * R} !");
        Console.WriteLine($"\n Doira yuzi  => S=𝜋*R^2 = {Math.PI * Math.Pow(R, 2)} !");
    }
    static void Uchburchak(double a, double b, double c)
    {
        double P = a + b + c;
        Console.WriteLine($"\n Uchburchak perimetri => P=a+b+c = {P} !");
        Console.WriteLine($"\n TUchburchak yuzi  => S=√p(p-a)(p-b)(p-c) = {Math.Sqrt((P / 2) * (P / 2 - a) * (P / 2 - b) * (P / 2 - c))} !");
    }

    static void TengTomonliUchburchak(double a)
    {
        Console.WriteLine($"\n Teng tomonli uchburchak perimetri => P=3*a = {3 * a} !");
        Console.WriteLine($"\n Teng tomonli uchburchak balandligi  => h=(√3/2)*a = {Math.Sqrt(3) / 2 * a} !");
        Console.WriteLine($"\n Teng tomonli uchburchak yuzi  => S=(√3/4)*a^2 = {Math.Sqrt(3) / 4 * Math.Pow(a, 2)} !");
    }

    static void Kvadrat(double a)
    {
        Console.WriteLine($"\n Kvadrat perimetri => P=4*a = {4 * a} !");
        Console.WriteLine($"\n Kvadrat yuzi  => S=a^2 = {Math.Pow(a, 2)} !");
    }

    static void TogriBurchakliTortburchak(double a, double b)
    {
        Console.WriteLine($"\n To'g'ri burchakli to'rtburchakning perimetri => P=(a+b)*2 = {(a + b) * 2} !");
        Console.WriteLine($"\n To'g'ri burchakli to'rtburchakning yuzi  => S=a*b = {a * b} !");
    }

    static bool QaytaIshgaTushirish()
    {
        Console.Write("\n Dasturni qayta ishga tushirishni istaysizmi ? (yes/no):");
        return Console.ReadLine().ToLower() == "yes";
    }
    static void NotoriAmalKirtildi()
    {
        Console.WriteLine("\n Noto'g'ri amalni kiritdingiz qayta urinib koring!");
    }
}