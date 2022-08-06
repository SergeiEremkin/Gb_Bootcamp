/*
QuickSort
1. arr = {1, 0, -6, 2, 5, 3, 2} 
2. pivot = arr[6]  (опорный элемент)
3. Вызвать шаги 1-2 для подмассива слева от pivot и справа от pivot
*/
int[] arr = { 0, -5, 2, 7, 5, 9, -1, 3 };
QuickSort(arr, 0, arr.Length);
Console.Write($"Отсортированный массив {string.Join(", ", arr)}");

static void QuickSort(int[] inputArray, int minIndex, int maxIndex)
{
    if (minIndex >= maxIndex) return;
    int pivot = GetPivotIndex(inputArray, minIndex, maxIndex);
    QuickSort(inputArray, minIndex, pivot);
    QuickSort(inputArray, pivot + 1, maxIndex);
    return;
}
static int GetPivotIndex(int[] inputArray, int minIndex, int maxIndex)
{
    int pivotIndex = minIndex;
    int pivot = inputArray[minIndex];
    for (int i = minIndex + 1; i < maxIndex; i++)
    {
        if (inputArray[i] < pivot)
        {
            pivotIndex++;
            Swap(inputArray, i, pivotIndex);
        }
    }
    Swap(inputArray, minIndex, pivotIndex);
    return pivotIndex;
}
static void Swap(int[] inputArray, int leftValue, int rightValue)
{
    int temp = inputArray[leftValue];
    inputArray[leftValue] = inputArray[rightValue];
    inputArray[rightValue] = temp;
}
