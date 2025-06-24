using System;

namespace T1E1
{
    class Program
    {
        private static int _arrayLength;
        private static int _randomRange;
        private static int _requiredNumber;

        static void Main()
        {
            // Запрос чисел 
            GetNumbers();
            // Инициализация массива
            int[] array = RandomizeArray(_arrayLength, _randomRange);
            // Вывод исходного массива
            Console.WriteLine("исходный массив: " + ArrayToString(array));
            // Поиск чётного элемента, ближайшего к заданному числу
            int closestNumber = FindClosestNumber(array);
            // Вывод этого числа
            Console.WriteLine($"Чётное число в массиве, ближайшее к запрошенному: {closestNumber}");
            Console.ReadLine();
        }

        private static void GetNumbers()
        {
            try
            {
                // Запрос чисел от пользователя
                RequestNumber("Введите длину массива (int): ", ref _arrayLength);
                RequestNumber("Введите промежуток случайных чисел (int): ", ref _randomRange);
                RequestNumber("Введите число, которое необходимо найти в массиве: (int) ", ref _requiredNumber);
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
        public static int FindClosestNumber(int[] input)
        {
            // Инициализация переменной ближайшего числа
            int closestNumber = input[0];
            // Инициализация переменной предыдущей разницы элемента массива и запрошенного числа
            int previousDelta = _requiredNumber * 100;
            for (int i = 0; i < input.Length; i++)
            {
                // Если элемент чётный...
                if (input[i] % 2 == 0)
                {
                    // Просчитать разницу между элементом массива и запрошенного числа
                    int delta = _requiredNumber - input[i];

                    // Сравнить модули разниц
                    if (Math.Abs(delta) < Math.Abs(previousDelta))
                    {
                        // Если текущая разница меньше предыдущей, взять элемент массива как наименьший
                        closestNumber = input[i];
                        previousDelta = delta;
                    }
                }
            }
            // Вернуть значение наименьшего числа
            return closestNumber;
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
