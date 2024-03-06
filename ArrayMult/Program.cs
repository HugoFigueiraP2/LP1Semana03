using System;

namespace ArrayMult
{
    class Program
    {
        static void Main(string[] args)
        {
            float [,] matrix_1 = new float[2,2];
            float [,] matrix_2 = new float[2,1];
            matrix_1[0,0] = float.Parse(args[0]);
            matrix_1[0,1] = float.Parse(args[1]);
;           matrix_1[1,0] = float.Parse(args[2]);
            matrix_1[1,1] = float.Parse(args[3]);

            matrix_2[0,0] = 

            for (int i = 0; i < 2; i++)
            {
                int value = 0;
                for (int j = 0; j < 2; j++)
                {
                    value += matrix_1[i, j] * matrix_2[j, 0];
                    
                }

            }   Console.WriteLine(value);
        }
    }
}
