namespace _6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*X(n) ve Y(n) deye 2 massiv verilmishdir/Ele x[i] elementi tapmaq lazimdir ki x[i] = y[i] ^ 2 (eyni indexdeki x elementi hemin indexdeki y elementin kvadratina beraber olsun)*/
            int n;
            l1:

            Console.Write("Massivin elementlerinin sayini qeyd edin: ");
            if (!int.TryParse(Console.ReadLine(), out n)) {
                goto l1;
            
            }
            int[] X=new int[n];
            int[] Y=new int[n];

            for (int i = 0; i < n; i++)
            {
                l2:
                Console.Write($"X massivinin {i+1}-ci elementi: ");
                if(!int.TryParse(Console.ReadLine(),out X[i]))
                {
                    goto l2;
                }
            }
            for (int i = 0; i < n; i++)
            {
            l3:
                Console.Write($"Y massivinin {i + 1}-ci elementi: ");
                if (!int.TryParse(Console.ReadLine(), out Y[i]))
                {
                    goto l3;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (X[i] == Math.Pow(Y[j], 2))
                    {
                    Console.WriteLine(X[i]);

                    }

                }
                
                
            }



        }
    }
}