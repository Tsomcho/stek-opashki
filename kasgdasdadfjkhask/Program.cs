namespace kasgdasdadfjkhask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Въведете естествено число (между 5 и 55): ");
            } while ((n = int.Parse(Console.ReadLine())) < 5 || n > 55);
            Stack<int> stak = new Stack<int>();

            int a = 1, b = 1;

            stak.Push(a);
            stak.Push(b);

            for (int i = 3; i <= n; i++)
            {
                int nextFib = a + b;
                stak.Push(nextFib);
                a = b;
                b = nextFib;
            }
            List<int> list = new List<int>();
            while (stak.Count > 0)
            {
                list.Add(stak.Pop());
            }
            list.Reverse();
            foreach (int i in list)
            {
                Console.Write(i + "; ");
            }
        }
    }
}
