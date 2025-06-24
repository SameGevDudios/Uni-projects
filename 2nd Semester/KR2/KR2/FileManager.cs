using System;
using System.IO;

namespace KR2
{
    // Класс, обрабатывающий запись и чтение массива в текстовом файле
    class FileManager
    {
        // Метод преобразующий числовой массив в последовательность строк
        // С последующей записью в текстовый файл
        public static void WriteTxt(string fileName, int[] input)
        {
            string data = "";
            for (int i = 0; i < input.Length; i++) data += input[i].ToString() + "\n";
            File.WriteAllText(fileName, data);
        }
        // Метод чтения текстового файла и преобразования строк в числовой массив
        public static int[] ReadTxt(string fileName)
        {
            object[] primaryArray = File.ReadAllLines(fileName);
            int[] output = new int[primaryArray.Length];
            for (int i = 0; i < primaryArray.Length; i++)
            {
                output[i] = Convert.ToInt32(primaryArray[i]);
            }
            return output;
        }
    }
}
