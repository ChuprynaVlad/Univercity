using System;


namespace Pifagor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] line1 = new int[9];
            int[] line2 = new int[9];
            string Tabl = "";

            for (int i = 0; i < 9; i++)
            {
                line1[i] = i + 1;
                line2[i] = i + 1;
            }


            for (int i = 0; i < line2.Length; i++)
            {
                for (int z = 0; z < line1.Length; z++)
                {
                    Tabl += "\t" + line2[i] * line1[z];
                }
                Tabl += "\n";
            }

            Console.WriteLine(Tabl);

            Console.ReadKey();
        }
    }
}