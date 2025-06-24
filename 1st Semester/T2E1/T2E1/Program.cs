using System;

namespace T2E1
{
    class Program
    {
        private static int _arrayLength;
        private static int _randomRange;

        static void Main(string[] args)
        {
            // Запроси чисел
            GetNumbers();
            // Инициализация массива
            int[,] array = RandomizeArray();
            // Вывод исходного массива
            Console.WriteLine($"Исходная матрица: \n{MatrixToString(array)}");
            // Поиск наименьшего массива
            int lowestElement = FindLowestElement(array);
            // Замена элементов, расположенных выше побочной диагонали на минимальный элемент в этой области
            array = ReplaceElements(array, lowestElement);
            // Вывод отсортированного по условиям задачи массива
            Console.WriteLine($"Минимальный элемент в области матрицы, выше побочной диагонали: {lowestElement}" +
                $"\nОтсортированный массив: \n{MatrixToString(array)}");
            Console.ReadLine();
        }
        public static void GetNumbers()
        {
            try
            {
                // Запрос чисел от пользователя
                RequestNumber("Введите размерность квадратной матрицы (int): ", ref _arrayLength);
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
        private static int[,] RandomizeArray()
        {
            Random random = new Random();
            int[,] output = new int[_arrayLength, _arrayLength];
            for (int i = 0; i < _arrayLength; i++)
            {
                for (int j = 0; j < _arrayLength; j++)
                {
                    output[i, j] = random.Next(-_randomRange, _randomRange);
                }
            }
            return output;
        }
        private static int[,] ReplaceElements(int[,] array, int input)
        {
            for (int i = 0; i < _arrayLength; i++)
            {
                for (int j = 0; j < _arrayLength; j++)
                {
                    array[i, j] = input;
                }
            }
            return array;
        }
        private static int FindLowestElement(int[,] input)
        {
            // Поиск наименьшего элемента в верхней части побочной диагонали
            int lowestNumber = _randomRange * 10;
            for (int i = 0; i < _arrayLength; i++)
            {
                for (int j = 0; j < _arrayLength - i; j++)
                {
                    if (input[i, j] < lowestNumber)
                    {
                        lowestNumber = input[i, j];
                    }
                }
            }
            return lowestNumber;
        }
    }
}
