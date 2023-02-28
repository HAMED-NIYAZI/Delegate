namespace MulticastDelegate
{
    internal class Program
    {
        public delegate void Print(int value);

        static void Main(string[] args)
        {
            Print printDel = PrintNumber;
            printDel += PrintHexadecimal;
            printDel += PrintMoney;

            printDel(100000);
        }
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0,-12:N0}", num);
        }

        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }

        public static void PrintHexadecimal(int dec)
        {
            Console.WriteLine("Hexadecimal: {0:X}", dec);
        }
    }
}