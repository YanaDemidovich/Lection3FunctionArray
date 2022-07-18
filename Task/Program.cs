// void - методы
// 1-ая группа: не принимает никаких аргументов и не возвращает
// 2-ая группа: принимает какие-то аргументы, но ничего не возвращает
// 3-яя группа: могу что-то возвращать, но не принимает никаких аргументов (например, генератор случайных чисел)
// 4-яя группа: что-то принимает и что-то возвращает

// 1-ая группа: не принимает никаких аргументов и не возвращает
//Вид 1

/* void Metod1()
{
    Console.WriteLine("Автор");
}
Metod1(); */

// 2-ая группа: принимает какие-то аргументы, но ничего не возвращает
// Вид 2
/*void Metod2(string msg)
{
    Console.WriteLine(msg);
}
Metod2(msg: "Текст сообщения");*/

/* void Metod21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
         Console.WriteLine(msg);
        i++;
    }
}
Metod21(msg: "Текст", count: 4);*/

// 3-яя группа: могу что-то возвращать, но не принимает никаких аргументов (например, генератор случайных чисел)
// Вид 3

/*int Metod3()
{
    return DateTime.Now.Year;
}
int year = Metod3();
Console.WriteLine(year);*/

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