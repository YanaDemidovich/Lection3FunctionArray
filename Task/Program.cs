// void - методы
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

// Цикл for
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


//WHILE, FOR и циклы в цикле
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

// Вывод таблицы умножения на экран

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