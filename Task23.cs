//ЗАДАЧА №23____________________________________________________________________

Console.Write("Введите число: ");
bool isNumber = int.TryParse(Console.ReadLine(), out int N);

if(!isNumber)
{
    Console.WriteLine("Ошибка.");
    return;
}

PrintCube (GetCube(N));
int[] GetCube(int n)
{
    int i = 1;
    int[] res = new int[n];
    while(i<=n){
        res[i-1] = (int)Math.Pow(i,3);
        i++;
    }
    return res;
}

void PrintCube(int[] cube){
    int i = 0;
    int length = cube.Length;
    while(i<length)
    {
        Console.WriteLine(cube[i]);
        i++;
    }
}