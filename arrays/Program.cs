namespace arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] nums = new int[10,15]; 
            Random random = new Random();

            //создание массива (без вывода)
            for(int i = 0; i< nums.GetLength(0); i++) //перебор строк
            {
                for(int j = 0; j< nums.GetLength(1); j++) //перебор элементов внутри строк
                {
                    nums[i, j] = random.Next(10, 100); 
                }
            }
            int[] averagesInColums = new int[nums.GetLength(1)]; //вектор средних значений
            //вычисление средних значений по столбцу и запись их в вектор
            for(int j=0; j< nums.GetLength(1); j++) //перебор столбцов
            {
                int summ = 0; // обнулена сумма для каждого столбца
                for (int i = 0; i< nums.GetLength(0); i++) //перебор элементов внутри столбца
                {
                    summ += nums[i, j];
                }
                int average = (int)summ/nums.GetLength(0); // среднее значение для столбца
                averagesInColums[j] = average;
            }

            for (int i = 0; i< nums.GetLength(0); i++) //перебор столбцов
            {
                for (int j = 0; j< nums.GetLength(1); j++) //перебор элементов внутри столбца
                {
                    if (nums[i,j] == averagesInColums[j]) //если значение тек. элемента совпадает со средним
                    {
                        Console.BackgroundColor = ConsoleColor.DarkGreen;
                        Console.Write(nums[i,j]+" ");
                        Console.BackgroundColor = ConsoleColor.Black;
                    }
                    else
                        Console.Write(nums[i, j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\nсредние значения по столбцам:");
            foreach(int i in averagesInColums)
                Console.Write(i +" ");
        }
    }
}