namespace SnailByMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int actualPos = 2;
            
            Console.SetCursorPosition(0, 12);
            Console.CursorVisible = false;
            do
            {
                Console.SetCursorPosition(actualPos, 12);
                Console.WriteLine("_@_ö");
                Console.SetCursorPosition(actualPos - 1, 12);
                Console.WriteLine(" ");
                Console.SetCursorPosition(actualPos, 12);
                actualPos ++;
                Thread.Sleep(150);
                
            } while (actualPos < 30);

            Console.WriteLine("____");
        }
    }
}
