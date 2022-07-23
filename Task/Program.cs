// ===== void - методы =====
// 1-ая группа: не принимает никаких аргументов и не возвращает
// 2-ая группа: принимает какие-то аргументы, но ничего не возвращает
// 3-яя группа: могу что-то возвращать, но не принимает никаких аргументов (например, генератор случайных чисел)
// 4-яя группа: что-то принимает и что-то возвращает

// 1-ая группа: не принимает никаких аргументов и не возвращает
//Вид 1

/*void Metod1()
{
    Console.WriteLine("Автор");
}
Metod1();

// 2-ая группа: принимает какие-то аргументы, но ничего не возвращает
// Вид 2
void Metod2(string msg)
{
    Console.WriteLine(msg);
}
Metod2(msg: "Текст сообщения");

void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
         Console.WriteLine(msg);
        i++;
    }
}
Metod21(msg: "Текст", count: 4);

// 3-яя группа: могу что-то возвращать, но не принимает никаких аргументов (например, генератор случайных чисел)
// Вид 3

int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);

// 4-яя группа: что-то принимает и что-то возвращает
// Вид 4

string Metod4(int count, string Text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + Text;
        i++;
    }
    return result;
}
string res = Metod4(10, "Текст");
Console.WriteLine(res);

// ===== Цикл for =====
/*for(int i + 0; i < 10; i++)
{
    Console.WriteLine(i);
}

string Metod4(int count, string Text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + Text;
    }
    return result;
}
string res = Metod4(10, "Текст");
Console.WriteLine(res);*/


//===== WHILE, FOR и циклы в цикле =====
// Пример
/*
for(int i = 0; i < 10; i++)
{
    for(int j = 0; j < 10; j++)
    {
        Console.WriteLine(i*j);
    }
}
Console.WriteLine();
*/

// ===== Вывод таблицы умножения на экран =====

/*
for(int i = 2; i <= 10; i++)
{
    for(int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }    
    Console.WriteLine();
} 
*/

// ====== Работа с текстом ======
// Дан текст. В тексте нужно заменить пробелы черточками, 
// маленькие "к" на большие "К", 
// и большие "С", заменить на маленькие "с".

// Ясна ли задача?

/*
string text = "- Я думаю, - сказал князь, улыбаяCь, - что, "
            + "ежели бы вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие пруCCкого короля. "
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012 
// s[3]  // r

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;

    int length = text.Length;
    for(int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, ' ', '/');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(newText, 'к', 'К');
Console.WriteLine(newText);
newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);
*/

// ======= Сортировка от меньшего числа к большему=======

/* int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;

    for(int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);

PrintArray(arr); */


