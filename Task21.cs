//ЗАДАЧА №21____________________________________________________________________

double GetDistance(int x1, int x2, int y1, int y2, int z1, int z2){
    double distance = Math.Sqrt(Math.Pow((x2-x1), 2) +  Math.Pow((y2-y1), 2) + Math.Pow((z2-z1), 2));
    return distance;
}

Console.Write("Введите координату A(x): ");
bool isNumberAx = int.TryParse(Console.ReadLine(), out int x1);
Console.Write("Введите координату A(y): ");
bool isNumberAy = int.TryParse(Console.ReadLine(), out int y1);
Console.Write("Введите координату A(z): ");
bool isNumberAz = int.TryParse(Console.ReadLine(), out int z1);

Console.Write("Введите координату B(x): ");
bool isNumberBx = int.TryParse(Console.ReadLine(), out int x2);
Console.Write("Введите координату B(y): ");
bool isNumberBy = int.TryParse(Console.ReadLine(), out int y2);
Console.Write("Введите координату B(z): ");
bool isNumberBz = int.TryParse(Console.ReadLine(), out int z2);

if(!isNumberAx || !isNumberAy || !isNumberAz || !isNumberBx || !isNumberBy || !isNumberBz){
   Console.WriteLine("Числа введены неверно.");
}
else{
    double result = GetDistance(x1, x2, y1, y2, z1, z2);
    Console.WriteLine(Math.Round(result, 2));
}
