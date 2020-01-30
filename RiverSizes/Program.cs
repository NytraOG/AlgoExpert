namespace Riversizes
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var finder = new RiverFinder();

            finder.RiverSizes(new[,]
                              {
                                  { 1, 0, 0, 1, 0 },
                                  { 1, 0, 1, 0, 0 },
                                  { 0, 0, 1, 0, 1 },
                                  { 1, 0, 1, 0, 1 },
                                  { 1, 0, 1, 1, 0 },
                                  { 0, 1, 1, 0, 1 }
                              });

            //var x = RekursionsPower(1, 5);

            //Console.WriteLine(x);
        }

        public static int RekursionsPower(int a, int b)
        {
            var sum = a;

            if (a < b)
            {
                a++;

                sum += RekursionsPower(a, b);
            }

            return sum;
        }
    }
}