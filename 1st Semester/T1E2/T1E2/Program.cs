using System;

namespace T1E2
{
    class Program
    {
        private static int _arrayLength;
        private static int _randomRange;
        private static int _firstEvenIndex;

        static void Main(string[] args)
        {
            // Запрос чисел
            GetNumbers();
            // Инициализация массива
            int[] array = RandomizeArray(_arrayLength, _randomRange);
            // Вывод исходного массива
            Console.WriteLine("Исходный массив: " + ArrayToString(array) + "\n");

            // Посик индекса первого чётного элемента
            FindEvenElement(array);
            // Сортировка массива, начиная с индекса первого чётного элемента
            SortArrayFromIndex(ref array);
            // Вывод отсортированного массива
            Console.WriteLine($"Массив отсортирован от индекса {_firstEvenIndex}");
            Console.WriteLine($"Отсортированный массив: {ArrayToString(array)}");
            Console.ReadLine();
        }
        private static void GetNumbers()
        {
            try
            {
                // Запрос чисел от пользователя
                RequestNumber("Введите длину массива (int): ", ref _arrayLength);
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
        public static void FindEvenElement(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] % 2 == 0)
                {
                    // Если элемент чётный, получить его индекс и прервать цикл
                    _firstEvenIndex = i + 1;
                    break;
                }
            }
        }
        public static void SortArrayFromIndex(ref int[] input)
        {
            // Сортировка пузырьком массив, начиная с индекса первого чётного элемента
            for (int i = _firstEvenIndex; i < input.Length; i++)
            {
                for (int j = _firstEvenIndex; j < input.Length; j++)
                {
                    if (input[i] < input[j])
                    {
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
        }
        private static int[] RandomizeArray(int length, int range)
        {
            Random random = new Random();
            int[] output = new int[length];
            for (int i = 0; i < length; i++)
            {
                // Рандомизация каждого элемента
                output[i] = random.Next(-range, range + 1);
            }
            return output;
        }
        private static string ArrayToString(int[] input)
        {
            string output = "";
            for (int i = 0; i < input.Length; i++)
            {
                // Добавление к строке значение текущего элемента, а также знака пробела
                output += input[i] + " ";
            }
            return output;
        }
    }
}
