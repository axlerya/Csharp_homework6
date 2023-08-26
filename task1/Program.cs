Console.WriteLine("Введите числа через запятую");
int[] myArray = Array.ConvertAll<string, int>(Console.ReadLine().Split(','), elem => { return System.Convert.ToInt32(elem); });

int positiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

Console.WriteLine("Положительных чисел введеных пользователем: " + positiveNumbers(myArray));