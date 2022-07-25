// Метод вызова вещественных чисел (те, что с плавающей запятой)

// негерируем новое рандомное целое число  + новую дробную часвть
// double num = (new Random().Next(1, 10)) + new Random().NextDouble();
                                                    // NextDouble() генерирует дробную часть

int[] CreateRandomArray(int size, int min, int max) // метод который создает массив
{
    int[] array = new int[size];
    for(int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max +1);
    }
    return array;
}

int[] myArray = CreateRandomArray(4, -3, 3);
double num = (new Random().Next(1, 10)) + new Random().NextDouble();
Console.WriteLine(num);

// можно отформатировать вывод дробного числа, чтобы выводилось определенное кол-во символов после запятой