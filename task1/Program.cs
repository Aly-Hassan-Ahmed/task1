namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double small_cost = 25;
            double large_cost = 35;
            double cost = 0;
            double tax = 0;
            Console.WriteLine("Estimate for carpet cleaning service");
            Console.Write("Number of small carpets: ");
            int small_num = Convert.ToInt32(Console.ReadLine());
            Console.Write("Number of large carpets: ");
            int large_num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Price per small room: $25");
            Console.WriteLine("Price per large room: $35");
           
            if (small_num > 0)
            {
                cost += small_num * small_cost;
            }
            if (large_num > 0)
            {
                cost += large_num * large_cost;   
            }
            tax +=  cost * 0.06;
            Console.WriteLine($"Cost : ${cost}");
            Console.WriteLine($"Tax : ${tax}");
            Console.WriteLine("===============================");
            Console.WriteLine($"Total estimate: ${cost+tax}");
            Console.WriteLine("This estimate is valid for 30 days");
        }
    }
}