namespace SnailByMe
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Snail mySnail = new Snail(1, "_@_ö");
                mySnail.racing();
        }
    }
    public class Snail
    {
        private int _actualPos;
        private string _snailForm;

        public Snail(int actualPos, string snailForm)
        {
            this._actualPos = actualPos;
            this._snailForm = snailForm;
        }

        public void racing()
        {
            Console.SetCursorPosition(0, 12);
            Console.CursorVisible = false;
            do
            {
                Console.SetCursorPosition(_actualPos, 12);
                Console.WriteLine("_@_ö");
                Console.SetCursorPosition(_actualPos - 1, 12);
                Console.WriteLine(" ");
                Console.SetCursorPosition(_actualPos, 12);
                _actualPos++;
                Thread.Sleep(150);

            } while (_actualPos < 30);

            Console.WriteLine("____");
        }
    }
}

