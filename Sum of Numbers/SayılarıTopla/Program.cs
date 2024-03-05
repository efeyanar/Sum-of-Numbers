namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            Console.Write("Başlangıç sayısını giriniz: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş sayısını giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                int yedek = b;
                b = a;
                a = yedek;
            } 
            for (int i= a; i <= b; i++)
            {
                toplam += i;
            }
            Console.WriteLine("Toplam sayınız: " + toplam);
            Console.ReadKey();
        }
    }
}
