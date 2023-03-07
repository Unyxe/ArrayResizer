using System;

namespace ArrayScaler
{
    class Program
    {
        static Random rn = new Random();

        const int width = 10;
        const int length = 10;
        static int[][] arr = new int[length][];

        const int resc_width = 23;
        const int resc_length = 23;
        static int[][] resc_arr = new int[resc_length][];

        static string char_c = "ijJoTePwmQM";
        static void Main(string[] args)
        {
            /*
            for(int i = 0; i < length;i++)
            {
                arr[i] = new int[width];
                for(int j = 0; j < width;j++)
                {
                    arr[i][j] = rn.Next() % 10;
                }
                
            }
            */
            arr[0] = new int[width] { 9, 9, 9, 9, 0, 0, 9, 9, 9, 9 };
            arr[1] = new int[width] { 9, 1, 1, 9, 0, 0, 9, 1, 1, 9 };
            arr[2] = new int[width] { 9, 1, 1, 9, 0, 0, 9, 1, 1, 9 };
            arr[3] = new int[width] { 9, 9, 9, 9, 0, 0, 9, 9, 9, 9 };
            arr[4] = new int[width] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            arr[5] = new int[width] { 0, 0, 9, 0, 0, 0, 0, 9, 0, 0 };
            arr[6] = new int[width] { 0, 9, 1, 9, 9, 9, 9, 1, 9, 0 };
            arr[7] = new int[width] { 0, 0, 9, 1, 1, 1, 1, 1, 9, 0 };
            arr[8] = new int[width] { 0, 0, 0, 9, 9, 1, 9, 9, 0, 0 };
            arr[9] = new int[width] { 0, 0, 0, 0, 0, 9, 0, 0, 0, 0 };
            PrintArray(arr);
            Console.WriteLine("__________");
            int[][] buff = new int[length][];
            int line_c = 0;
            foreach (int[] line in arr)
            {
                int[] l = new int[width * resc_width];
                for(int i = 0; i < width; i++)
                {
                    for(int j = 0; j < resc_width; j++)
                    {
                        l[i * resc_width + j] = line[i];
                    }
                }
                int[] a = new int[resc_width];
                int sum = 0;
                int ind = 0;
                for(int i = 0; i < width * resc_width; i++)
                {
                    
                    sum += l[i];
                    if ((i+1) % width == 0)
                    {
                        double g = ((sum * 1.0) / width) - sum / width;
                        a[ind] = sum / width;
                        if(g > 0.5)
                        {
                            a[ind]++;
                        }
                        sum = 0;
                        ind++;
                    }
                }
                buff[line_c] = a;
                line_c++;

            }
            int[][] buff2 = new int[resc_length][];
            for(int i = 0; i < resc_length; i++)
            {
                buff2[i] = new int[resc_width];
            }
            for (int m = 0; m < resc_width; m++)
            {
                int[] l = new int[length * resc_length];
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j < resc_length; j++)
                    {
                        l[i * resc_length + j] = buff[i][m];
                    }
                }
                int[] a = new int[resc_length];
                int sum = 0;
                int ind = 0;
                for (int i = 0; i < length * resc_length; i++)
                {

                    sum += l[i];
                    if ((i + 1) % length == 0)
                    {
                        double g = ((sum * 1.0) / length) - sum / length;
                        a[ind] = sum / length;
                        if (g > 0.5)
                        {
                            a[ind]++;
                        }
                        sum = 0;
                        ind++;
                    }
                }
                for (int i = 0; i < resc_length; i++)
                {
                    buff2[i][m] = a[i];
                }
            }
            
            PrintArray(buff2);
        }

        static void PrintArray(int[][] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array[0].Length; j++)
                {
                    Console.Write(char_c[array[i][j]]);
                }
                Console.WriteLine();
            }
        }
    }
}
