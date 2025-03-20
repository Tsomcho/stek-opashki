namespace asdfghjk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            do
            {
                Console.Write("Въведете естествено число (между 10 и 100): ");
            }while ((n=int.Parse(Console.ReadLine())) < 10 || n > 100);

            Random rand = new Random();
            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                int num = rand.Next(1, 102);
                stack.Push(num);
            }

            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();

            Console.WriteLine("Steka:");

            while (stack.Count > 0)
            {
                int num = stack.Pop();
                Console.Write(num + " ");
                if (num % 2 == 0)
                    evenNumbers.Add(num);
                else
                    oddNumbers.Add(num);
            }
            Console.WriteLine();
            Console.WriteLine("Steka s podredeni purvo chetnite i posle nechetnite v obraten red:");
            foreach (var num in evenNumbers)
            {
                Console.Write(num + " ");
            }

            for (int i = oddNumbers.Count - 1; i >= 0; i--)
            {
                Console.Write(oddNumbers[i] + " ");
            }
        }
    }
}
