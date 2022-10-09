//string hello = "hell";
//var Hello = "Hello";

//string? firstName;
//Console.WriteLine("Imya");
//firstName = Console.ReadLine();

//Console.WriteLine("Vozrast");

//double age = Convert.ToDouble(Console.ReadLine());


//Console.Write($"Familiya: , Imya: {firstName}, Otchestvo:, Age: {age}");
//Console.WriteLine();
//double a = 10;
//double b = 3;
//double c = a / b;
//Console.WriteLine($"a = {a}");
//Console.WriteLine($"b = {b}");

//Console.WriteLine("C = a / b = {0}", c);


//если в качестве операндов указать литералы (не переменные), то результат может быть целым
using System.Data.SqlTypes;

double z = 10 / 3;

//или дробным (если указал вещественные литералы
double zz = 10.0 / 3.0;
Console.WriteLine("z = " + z + ";  zz " + zz);


Console.WriteLine("остаток от деления 10/3 = " + 10 % 3);


//логическое умножение & : 1011 & 1110 = 1010 = "10"
Console.WriteLine("11 & 14 = " + (11 & 14));

//логическое сложение | : 1010 & 1100 = 1110 = "14"
Console.WriteLine("10 | 12 = " + (10 | 12));

//исключающее или
int x = 42;
int key = 777;

int encrypt = x ^ key;
Console.WriteLine("42 зашифровано: " + (encrypt)); // 10 1010 + 11 0000 1001 = 00 1101 1011

int decrypt = encrypt ^ key;
Console.WriteLine("42 расшифровано: " + (decrypt));

//инвертирование разрядов ~
int y = 14;
Console.WriteLine("Инвертированный Х = " + y + " = " + (~y));

//присваивание со сдвигом разрядов
int x2 = 4;
Console.WriteLine($"x2 = {x2}. Сдвинуть на 4 разряда влево: X2 << 4 = {x2 << 2}");

byte ab = 4;
byte bb = (byte)(ab + 1);

//явное приведение
double d3 = 14.0;
decimal dc3 = (decimal)d3;
Console.WriteLine("Decimal dc3 = {0}", dc3);

//Console.WriteLine("Введите два числа");
//int num1, num2;
//num1 = Convert.ToInt32(Console.ReadLine());
//num2 = Convert.ToInt32(Console.ReadLine());
//string? result = null;

//if (num1 > num2)
//{
//    result = "больше";
//}
//else if (num1 < num2)
//{
//    result = "меньше";
//}


//Console.WriteLine($"num1 " + result + ", чем num2");

//циклы
Console.WriteLine("Циклы");
//for (int i = 1; i < 5; i++)
//{
//    Console.Write($"{i}, ");
//}

//int j = 6;
//for (; j < 10;)
//{
//    Console.Write($"{j}, ");
//    j++;

//}


int a, b;
a = b = 1;
for (; a < 11; a++)
{   
    for (; b < 11; b++)
    {
        Console.Write((a * b) + ", ");
    }

    b = a;
    Console.WriteLine();
}


//for (int i = 0; i < 100; i++)
//{
//    Console.WriteLine(i);
//    if (i > 10 && i < 20)
//    {
//        i += 5;
//    }

//    if (i > 50)
//    {
//        i = 99;
//    }
//}

//Массивы
int[] nums = new int[5];

for(int i = 0; i < nums.Length; i++)
{
    nums[i] = i+5;
}


foreach (int xit in nums)
{
    Console.WriteLine(xit + ", ");
    
}

Console.WriteLine("Последний и предпоследний элементы");
//длина массива - свойство .Lenght
//последний, предпоследний элемент - операторы [^1], [^2]
Console.WriteLine(nums[^1]);
Console.WriteLine(nums[^2]);


//метод для вывода русского приветствия
void PrintHelloRu(string name)
{
    Console.WriteLine("Привет метод (русск) " + name);
}

//метод для вывода En приветствия
void PrintHelloEn(string name)
{
    Console.WriteLine("Hello Yellow (english)" + name);
}

Console.WriteLine("Your name is... ");
string name = Console.ReadLine();

Console.WriteLine("Выберете Ru / En");
string langChoice = "";


Console.WriteLine($"Вы ввели имя: {name} и язык метода {langChoice}.");

if (langChoice == "Ru") PrintHelloRu(name); 
if (langChoice == "En") PrintHelloEn(name);

Console.WriteLine("Ещё раз через switch...");
switch (langChoice)
{
    case "En":
        PrintHelloEn(name);
        break;
    case "Ru":
        PrintHelloRu(name);
        break;
}




















