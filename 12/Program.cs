namespace _12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*X(20) massivinin ilk yarisinin ededi ortasini ikinci yarisinin hendesi ortasini tapmaq*/
            int[] numbers=new int[20];
            
            long ed = 0, hen = 1;
            for (int i = 0; i < 20; i++)
            {
                l1:
                Console.Write($"Massivin {i+1}-ci elementi: ");
                if(!int.TryParse(Console.ReadLine(),out numbers[i]))
                {
                    goto l1;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                ed += numbers[i];
            }
            for (int i = 10; i < 20; i++)
            {
                
                hen *= numbers[i];
            }
            double ededi = ed / 10;
          
            double hendesi = Math.Pow(hen, 0.1);

            Console.WriteLine($"Massivin ilk 10 elementinin ededi ortasi: {ededi}");
            Console.WriteLine($"Massivin son 10 elementinin hendesi ortasi: {hendesi}");
           
;
        }
    }
}