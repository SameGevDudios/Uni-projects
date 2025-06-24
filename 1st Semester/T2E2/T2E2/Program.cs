using System;
namespace T2E2
{
    class Program
    {
        private static int _arrayRows;
        private static int _arrayCollumns;
        private static int _randomRange;
        static void Main(string[] args)
        {
            // Запросить числа
            GetNumbers();
            // Инициализация матрицы
            int[,] array = RandomizeArray();
            // Вывод исходной матрицы
            Console.WriteLine($"Исходная матрица:\n{MatrixToString(array)}");
            // Вывод неповторяющихся строк матрицы
            Console.WriteLine($"Матрица без повторяющихся строк:\n{NoRepeatArray(array)}");
            Console.ReadLine();
        }
        private static void GetNumbers()
        {
            try
            {
                // Запрос чисел от пользователя
                RequestNumber("Введите кол-во рядов матрицы (int): ", ref _arrayRows);
                RequestNumber("Введите кол-во столбцов матрицы (int): ", ref _arrayCollumns);
                RequestNumber("Введите промежуток случайных чисел (int): ", ref _randomRange);
            }
            catch (FormatException e)
            {
                // Перезапуск программы, если пользователь ввёл данные неправильного типа
                Console.WriteLine($"Ошибка: {e.Message}\n");
                GetNumbers();
            }
        }
        public static void RequestNumber(string userMessage, ref int number)
        {
            // Вывод сообщения пользователю
            Console.Write(userMessage);
            // Присвоение значения запрошенной переменной
            number = Convert.ToInt32(Console.ReadLine());
        }
        private static int[,] RandomizeArray()
        {
            Random random = new Random();
            int[,] output = new int[_arrayRows, _arrayCollumns];
            for (int i = 0; i < _arrayRows; i++)
            {
                for (int j = 0; j < _arrayCollumns; j++)
                {
                    output[i, j] = random.Next(-_randomRange, _randomRange+1);
                }
            }
            return output;
        }
        private static string MatrixToString(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            string output = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    output += array[i, j] + "\t";
                }
                output += "\n\n";
            }
            return output;
        }
        private static string NoRepeatArray(int[,] array)
        {
            int rows = array.GetLength(0);
            int cols = array.GetLength(1);
            string output = "";
            for (int i = 0; i < rows; i++)
            {
                string currentRow = "";
                for (int j = 0; j < cols; j++)
                {
                    currentRow += array[i, j] + "\t";
                }
                currentRow += "\n";
                string[] uniqueRows = output.Split('\n');
                int flag = 0;
                foreach(string row in uniqueRows)
                {
                    if(row + "\n" == currentRow)
                    {
                        flag = 1;
                        break;
                    }
                }
                if(flag == 0)
                {
                    output += currentRow + "\n";
                }
            }
            return output;
        }
    }
}
