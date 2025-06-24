using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace KR2
{
    public partial class SearchOptimizationResearchForm : Form
    {
        // Перемнная, отвечающая за количество иттераций поиска (количество раз вызова метода поиска)
        private int _searchItteraions = 10;
        // Количество пройденных циклов метода поиска
        int _methodCycles = 0;
        public SearchOptimizationResearchForm()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        // Событие нажатия на кнопку создания массива (метод генерации массива чисел)
        private void GenerateArrayButton_Click(object sender, EventArgs e)
        {
            // Обработка исключений в случаях, когда какое-либо текстовое поле пустое 
            if(GenerateArrayLengthText.Text == "")
            {
                GenerateArrayTextOutput.Text = "Введите длину массива.";
            }
            else if (GenerateArrayMinText.Text == "")
            {
                GenerateArrayTextOutput.Text = "Введите минимальное значение массива.";
            }
            else if(GenerateArrayMaxText.Text == "")
            {
                GenerateArrayTextOutput.Text = "Введите максимальное значение массива.";
            }
            else if(Convert.ToInt32(GenerateArrayLengthText.Text) < 1)
            {
                GenerateArrayTextOutput.Text = "Введите длину массива с положительным значением.";
            }
            else
            {
                // Смена курсора на "вращающийся"
                Cursor.Current = Cursors.WaitCursor;
                Random random = new Random();
                GenerateArrayTextOutput.Text = "";
                // Получение значений массива из текстовых полей
                int length = Convert.ToInt32(GenerateArrayLengthText.Text);
                int min = Convert.ToInt32(GenerateArrayMinText.Text);
                int max = Convert.ToInt32(GenerateArrayMaxText.Text);
                // Инициализация переменной для массива
                int[] array = new int[length];
                // Цикл рандомизации массива
                for (int i = 0; i < length; i++)
                {
                    // Запись случайного числа в массив
                    array[i] = random.Next(min, max);
                    // Вывод этого числа в текстовое поле вывода
                    GenerateArrayTextOutput.Text += array[i] + Environment.NewLine;
                }
                // Запись массива в текстовый файл
                FileManager.WriteTxt("Array.txt", array);
                // Смена курсора на обычный
                Cursor.Current = Cursors.Default;
            }
        }
        // Событие нажатия на кнопку вызова линейного поиска
        private void LinearSearchButton_Click(object sender, EventArgs e)
        {
            // Смена курсора на "вращающийся"
            Cursor.Current = Cursors.WaitCursor;
            // Если поле ввода числа для поиска не пустое, то выполнить линейный поиск. В ином случае вывести сообщеие пользователю
            if (FindElementTextLinear.Text != "") LinearSearch(Convert.ToInt32(FindElementTextLinear.Text));
            else LinearSearchTextOutput.Text = "Введите значение элемента для поиска";
            // Смена курсора на обычный
            Cursor.Current = Cursors.Default;
        }
        // событие нажатия на кнопку вызова интерполяционного поиска
        private void InterpolationSearchButton_Click(object sender, EventArgs e)
        {
            // Смена курсора на "вращающийся"
            Cursor.Current = Cursors.WaitCursor;
            // Если поле ввода числа для поиска не пустое, то выполнить интерполяционный поиск. В ином случае вывести сообщеие пользователю
            if (FindElementTextInterpolation.Text != "") InterpolationSearch(Convert.ToInt32(FindElementTextInterpolation.Text));
            else InterpolationSearchTextOutput.Text = "Введите значение элемента для поиска";
            // Смена курсора на обычный
            Cursor.Current = Cursors.Default;
        }
        // Событие нажатия на кнопку вызова бинарного поиска
        private void BinarySearchButton_Click(object sender, EventArgs e)
        {
            // Смена курсора на "вращающийся"
            Cursor.Current = Cursors.WaitCursor;
            // Если поле ввода числа для поиска не пустое, то выполнить бинарный поиск. В ином случае вывести сообщеие пользователю
            if (FindElementTextBinary.Text != "") BinarySearch(Convert.ToInt32(FindElementTextBinary.Text));
            else BinarySearchTextOutput.Text = "Введите значение элемента для поиска";
            // Смена курсора на обычный
            Cursor.Current = Cursors.Default;
        }
        // Событие нажатия на кнопку вызова всех методов сортировки
        private void StartAllSearchButton_Click(object sender, EventArgs e)
        {
            // Смена курсора на "вращающийся"
            Cursor.Current = Cursors.WaitCursor;

            if (FindElementTextLinear.Text != "") LinearSearch(Convert.ToInt32(FindElementTextLinear.Text));
            else LinearSearchTextOutput.Text = "Введите значение элемента для поиска";

            if (FindElementTextInterpolation.Text != "") InterpolationSearch(Convert.ToInt32(FindElementTextInterpolation.Text));
            else InterpolationSearchTextOutput.Text = "Введите значение элемента для поиска";

            if (FindElementTextBinary.Text != "") BinarySearch(Convert.ToInt32(FindElementTextBinary.Text));
            else BinarySearchTextOutput.Text = "Введите значение элемента для поиска";

            // Смена курсора на обычный
            Cursor.Current = Cursors.Default;
        }
        // Событие нажатия на кнопку уменьшения количества иттераций поиска, если это значение не меньше десяти
        private void DecreaseIterationsButton_Click(object sender, EventArgs e)
        {
            // Уменьшение количества итераций поиска, если это значение не меньше десяти
            if (_searchItteraions >= 10)
            {
                _searchItteraions = (int)(_searchItteraions * 0.1f);
                IterationsText.Text = _searchItteraions.ToString("N0");
            }
        }
        // Событие нажатия на кнопку увеличения количества итераций поиска
        private void IncreaseIterationsButton_Click(object sender, EventArgs e)
        {
            // Увеличение количества итераций поиска
            if(_searchItteraions < 1000000000)
            {
                _searchItteraions *= 10;
                IterationsText.Text = _searchItteraions.ToString("N0");
            }
        }
        // Метод линейного поиска
        private void LinearSearch(int elementToFind)
        {
            // Инициализация массива из текстового файла
            int[] array = FileManager.ReadTxt("array.txt");
            // Создание копии массива. Необходимо для восстановления исходного масиива после каждой иттерации поиска
            int[] backupArray = new int[array.Length];
            // Обнуление количества пройденных циклов метода поиска
            _methodCycles = 0;
            Array.Copy(array, backupArray, array.Length);
            // Начало отсчёта времени выполнения алгоритма поиска
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Цикл, вызывающий метод поиска столько раз, сколько выбрано иттераций поиска
            for (int i = 0; i < _searchItteraions; i++)
            {
                // Флаг для проверки на нахождение нужного элемента
                int f = 0;
                // восстановление исходного массива из запасного
                Array.Copy(backupArray, array, array.Length);
                // Цикл линейного поиска
                for (int j = 0; j < array.Length; j++)
                {
                    // Подсчёт количества пройденных циклов поиска
                    _methodCycles++;
                    // Если найден искомый элемент, то...
                    if(array[j] == elementToFind)
                    {
                        // ... вывести сообщение пользователю
                        LinearSearchTextOutput.Text = "Элемент найден: " + array[j];
                        // Выставить флаг для проверки на нахождение искомого элемента
                        f = 1;
                        // Завершить 
                        break;
                    }
                }
                // Если элемент не найден, то вывести сообщение пользователю
                if(f == 0) LinearSearchTextOutput.Text = "Элемент не найден.";
            }
            // Остановка таймера после прохождения всех иттераций поиска
            stopwatch.Stop();
            // Преобразование результатов таймера для дальнейшего вывода сообщения
            TimeSpan timeSpan = stopwatch.Elapsed;
            // Вывод сообщение пользователю о затраченном времени на выполнение поиска и о пройденных циклах поиска
            LinearSearchTextOutput.Text += Environment.NewLine + $"Время поиска: " +
                $"{timeSpan.Minutes} м, " +
                $"{timeSpan.Seconds} с, {timeSpan.Milliseconds} мc";
            LinearSearchTextOutput.Text += Environment.NewLine + $"Количество циклов поиска: {_methodCycles/_searchItteraions}";
        }
        // Метод интерполяционного поиска
        private void InterpolationSearch(int elementToFind)
        {
            // Инициализация массива из текстового файла
            int[] array = FileManager.ReadTxt("array.txt");
            // Создание запасного массива
            int[] backupArray = new int[array.Length];
            // Обнуление количества пройденных циклов метода поиска
            _methodCycles = 0;
            Array.Copy(array, backupArray, array.Length);
            // Пузырьковая сортировка исходного массива, которая необходима для интерполяционного поиска
            BubbleSort(array);
            // Начало отсчёта времени выполнения алгоритма поиска
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Цикл, вызывающий метод поиска столько раз, сколько выбрано иттераций поиска
            for (int i = 0; i < _searchItteraions; i++)
            {
                // Вызов метода для отдельной иттерации интерполяционного поиска и запись результата его выполнения в переменную
                int result = InterpolationSearchUtil(array, elementToFind);
                // Если переменная не равна максимальному значению типа данных int (это значение в программе используется в том случае, 
                // если элемент не найден), то вывести сообщение о нахождении элемента. В ином случае вывести сообщения, что такой элемент не найден
                InterpolationSearchTextOutput.Text = result != int.MaxValue ? $"Элемент найден: {result}" : "Элемент не найден.";
            }
            // Остановка таймера после прохождения всех иттераций поиска
            stopwatch.Stop();
            // Преобразование результатов таймера для дальнейшего вывода сообщения
            TimeSpan timeSpan = stopwatch.Elapsed;
            // Вывод сообщение пользователю о затраченном времени на выполнение поиска и о пройденных циклах поиска
            InterpolationSearchTextOutput.Text += Environment.NewLine + $"Время поиска: " +
                $"{timeSpan.Minutes} м, " +
                $"{timeSpan.Seconds} с, {timeSpan.Milliseconds} мc";
            InterpolationSearchTextOutput.Text += Environment.NewLine + $"Количество циклов поиска: {_methodCycles/_searchItteraions}";
        }
        // Метод отдельной иттерации интерполяционного поиска
        private int InterpolationSearchUtil(int[] array, int target)
        {
            // Перменные для начального и конечного индексов для поиска
            int low = 0;
            int high = array.Length - 1;
            // Пока искомый элемент лежит в пределах между начальным и конечным элементами массива...
            while (low <= high && target >= array[low] && target <= array[high])
            {
                // Подсчёт пройденных циклов поиска
                _methodCycles++;
                // ... если минимальный и максимальный индексы поиска равны, то...
                if (low == high)
                {
                    // Если выбранный элемент массива равен искомому значению, то вернуть это искомое значение
                    if (array[low] == target) return array[low];
                    // Иначе вернуть значение максимального целого числа в C#, которое в программе используется 
                    // Для обозначения отсутствия искомого элемента
                    return int.MaxValue;
                }

                // Рассчитываем предполагаемую позицию элемента с использованием формулы интерполяции
                int position = low + ((target - array[low]) * (high - low) / (array[high] - array[low]));

                // Если элемент массива с предполагаемой позицией равен искомому элементу, то вернуть его значение
                if (array[position] == target)
                {
                    return array[position];
                }
                // Если элемент массива с предполагаемым индексом меньше значения исходного элемента, то...
                if (array[position] < target)
                {
                    // ищем элемент в правом подмассиве, сдвигая переменуню low на одну позицию вправо
                    low = position + 1;
                }
                else
                {
                    // иначе ищем элемент в левом подмассиве, сдвигая переменную high на одну позицию влево
                    high = position - 1;
                }
            }
            // Возвращаем значение, обозначающее, что элемент с таким значением не найден
            return int.MaxValue; 
        }
        // Метод бинарного поиска
        private void BinarySearch(int elementToFind)
        {
            // Инициализация массива из текстового файла
            int[] array = FileManager.ReadTxt("array.txt");
            // Инициализация запасного массива
            int[] backupArray = new int[array.Length];
            // Обнуление количества пройденных циклов метода поиска
            _methodCycles = 0;
            Array.Copy(array, backupArray, array.Length);
            // Пузырьковая сортировка, необходимая для бинарного поиска
            BubbleSort(array);
            // Начало отсчёта времени выполнения алгоритма поиска
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            // Цикл, вызывающий метод поиска столько раз, сколько выбрано иттераций поиска
            for (int i = 0; i < _searchItteraions; i++)
            {
                // Флаг для обозначения нахождения элемента
                int f = 0;
                // Начальный (low) и конечный (high) индексы для поиска
                int low = 0;
                int high = array.Length - 1;
                // Цикл поиска
                while (low <= high)
                {
                    // Подсчёт пройденных циклов поиска
                    _methodCycles++;
                    // Находим середину текущего диапазона поиска
                    int mid = low + (high - low) / 2;

                    // Если элемент массива под индексом mid равен искомому, то вывести сообщение и прервать поиск
                    if (array[mid] == elementToFind)
                    {
                        BinarySearchTextOutput.Text = "Элемент найден: " + array[mid];
                        f = 1;
                        break;
                    }
                    // Если элемент массива под индексом меньше искомого, то сдвинуть минимальный индекс поиска на один вправо
                    if (array[mid] < elementToFind)
                    {
                        low = mid + 1;
                    }
                    // Иначе сдвинуть максимальный индекс поиска на один влево
                    else
                    {
                        high = mid - 1;
                    }
                }
                // Вывод сообщения пользователю, если элемент не найден
                if (f == 0) BinarySearchTextOutput.Text = "Элемент не найден";
            }
            // Остановка таймера после прохождения всех иттераций поиска
            stopwatch.Stop();
            // Преобразование результатов таймера для дальнейшего вывода сообщения
            TimeSpan timeSpan = stopwatch.Elapsed;
            // Вывод сообщение пользователю о затраченном времени на выполнение поиска и о пройденных циклах поиска
            BinarySearchTextOutput.Text += Environment.NewLine + $"Время поиска: " +
                $"{timeSpan.Minutes} м, " +
                $"{timeSpan.Seconds} с, {timeSpan.Milliseconds} мc";
            BinarySearchTextOutput.Text += Environment.NewLine + $"Количество циклов поиска: {_methodCycles/_searchItteraions}";
        }
        // Метод сортировки пузырьком
        private void BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (array[i] < array[j])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }
    }
}
