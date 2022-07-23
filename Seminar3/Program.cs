// ====== К какой четверти относится заданная координата? ======
int FindQuart(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x > 0 && y < 0) return 3;
    if(x < 0 && y < 0) return 4;
    return -1;
}

Console.Write("Input X coord: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Input Y coord: ");
int y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Number of quart for out point is " + FindQuart(x,y));
