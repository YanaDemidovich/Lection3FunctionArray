// Ввести массив из 9 рандомных чисел от -9 до 9 и сложить отдельно отрицательные и положительные.


int[] CreateRandomArray(int size, int min, int max) // метод который создает массив
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}

void ShowArray(int[] array) // метод, который выводит массив
{

    for(int i = 0; i < array.Length; i++) // до тех пор пока "for" (i=0 - первое число массива = индекс 0; пока индекс меньше длинны массива; добавялем +1 шаг)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int FindPositiveSum(int[] array) // метод поиска суммы положительных чисел
{
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > 0) sum += array[i]; // проверка на положителное число
    }
    return sum;
}
                            // int sise, min, max
int[] myArray = CreateRandomArray(12, -9, 9); // в () указано 12 элементов, min -9, max 9
ShowArray(myArray);
Console.WriteLine("Сумма " + FindPositiveSum(myArray));
