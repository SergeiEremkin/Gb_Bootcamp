/*
Дана последовательность из N целых чисел и число K. 
Необходимо сдвинуть всю последовательность (сдвиг - циклический) на |K| элементов вправо, 
если K – положительное и влево, если отрицательное.

Входные данные
Первая строка входного файла INPUT.TXT содержит натуральное число N, во второй строке записаны N целых чисел Ai, а в последней – целое число K. (1 ≤ N ≤ 105, |K| ≤ 105, |Ai| ≤ 100).

Выходные данные
В выходной файл OUTPUT.TXT выведите полученную последовательность.
*/


int[] ShiftArray(int[] array, int K)
{
    int[] result = new int[array.Length];
    if (K > 0)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (i + K >= array.Length)
            {
                result[i + K - array.Length] = array[i];
            }
            else
            {
                result[i + K] = array[i];
            }
        }
    }
    else
    {
        K = (-1) *K;
       for (int i = 0; i < array.Length; i++)
        {
            if (i - K < 0)
            {
                result[array.Length + (i-K)] = array[i];
            }
            else
            {
                result[i - K] = array[i];
            }
        }
    }
    return result;
}

int[] ReadFileForArray(string path)
{
    StreamReader sr = new StreamReader(path);
    int N = int.Parse(sr.ReadLine());
    string arr = sr.ReadLine();
    sr.Close();
    int[] array = new int[N];
    array = arr.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
    return array;
}
int ReadFileForShift(string path)
{
    StreamReader sr = new StreamReader(path);
    sr.ReadLine();
    sr.ReadLine();
    int K = int.Parse(sr.ReadLine());
    sr.Close();
    return K;
}
void WriteFile(string path, int [] array)
{
    StreamWriter sw = new StreamWriter(path);
    for (int i = 0; i < array.Length; i++)
    {
        sw.Write($"{array[i]} ");
    }
    sw.Close();
    
}
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}
string path = @"C:\Users\Пользователь\source\GB_Bootcamp\Task3\INPUT.TXT";
string path2 = @"C:\Users\Пользователь\source\GB_Bootcamp\Task3\OUTPUT.TXT";
int[] array = ReadFileForArray(path);
PrintArray(array);
int K = ReadFileForShift(path);
System.Console.WriteLine(K);
int[] sArray = ShiftArray(array, K);
PrintArray(sArray);
WriteFile(path2, sArray);


