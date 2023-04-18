namespace Lab2
{
    

    internal class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            matrix mat = new matrix();
            mat.GetMass();
            mat.GetCh();
            mat.SortMatrix();
        }
    }

    public class matrix
    {
        Random rnd = new Random();
        int[,] mass = new int[5,5];
        int[] ch = new int[5];
        int sum;

        public matrix() {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    mass[i, j] = rnd.Next(-10, 10);
                }
            }

            for (int j = 0; j < 5; j++)
            {   
                sum = 0;
                
                for (int i = 0; i < 5; i++)
                {
                    if ( mass[i,j] < 0 && (mass[i, j] %2 == 1 || mass[i, j] % 2 == -1)) 
                    {
                        sum += Math.Abs(mass[i, j]);
                    }

                    

                }

                ch[j] = sum;
                sum = 0;
            }
        }

        public void GetMass() 
        {
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mass[i, j] + " \t");
                }
                Console.WriteLine();
            }
        }

        public void GetCh() 
        {
            Console.WriteLine("Характеристика стовпцiв");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(ch[i] + "\t");
                
            }
            Console.WriteLine();
        }

        public void SortMatrix() 
        {
            Console.WriteLine("Вiдсортована матриця: ");
            for (int i = 0; i < 5 - 1; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    if (ch[i] > ch[j])
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            int temp = mass[k, i];
                            mass[k, i] = mass[k, j];
                            mass[k, j] = temp;
                        }
                        int tempChar = ch[i];
                        ch[i] = ch[j];
                        ch[j] = tempChar;
                    }
                }
            }

            int sum = 0;
            for (int j = 0; j < 5; j++)
            {
                bool hasNegative = false;
                for (int i = 0; i < 5; i++)
                {
                    if (mass[i, j] < 0)
                    {
                        hasNegative = true;
                        break;
                    }
                }
                if (hasNegative)
                {
                    for (int i = 0; i < 5; i++)
                    {
                        sum += mass[i, j];
                    }
                }
            }

            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Сума вiдємних елементiв: " + sum);
        }


    }
}