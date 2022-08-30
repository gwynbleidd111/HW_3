//ЗАДАЧА №19____________________________________________________________________

string GetString(int n)
{
    string numberString = n.ToString();
    return numberString;
}

bool VerifyNumber(string nS)
{
    if(nS[0]==nS[4] && nS[1]==nS[3]){
        
        return true;
    }
    else{
        return false;
    }
}

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number>9999 && number<100000){
    string numberString = GetString(number);
    bool result = VerifyNumber(numberString);
    if(result==true){
        Console.WriteLine("Палиндромом.");
    }
    else{
        Console.WriteLine("Не палиндромом.");
    }
}
else{
    Console.WriteLine("Вы ввели неверное число!");
}
