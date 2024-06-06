namespace Challenge5._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This program determines the missing number in an array from 0 to n");
            Console.WriteLine("Input size of Array");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] userArray = new int[size];
            HashSet<int> userSet = new HashSet<int>();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"input {i} element");
                userArray[i] = Convert.ToInt32(Console.ReadLine());
                userSet.Add(i);
            }
            for (int i = 0; i < size; i++)
            {
                userSet.Remove(userArray[i]);
            }
            Console.WriteLine($"Missing number is ");
            foreach (int i in userSet) { Console.WriteLine(i); }
        }
    }
}
