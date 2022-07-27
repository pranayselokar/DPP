namespace LeapYear
{
    class Program
    {
        public static void Main(string[] args)
        {
            int y;
            Console.WriteLine(" Please enter the year in four digits ");
            y = Convert.ToInt32(Console.ReadLine());

            if ((y % 400) == 0 && (y % 4) == 0) ;
            {
                Console.WriteLine(" It is a leap year " + y);
            }
     
            else if ((y % 100) == 0) ;
            {
                Console.WriteLine(" It is not a leap year " + y);
            }

            else
            {
                Console.WriteLine(" It is not a leap year" + y);
            }
        }
    }
}
            
           

