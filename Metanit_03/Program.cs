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

/*
using System.Data.SqlTypes;

double z = 10 / 3;

//или дробным (если указал вещественные литералы
double zz = 10.0 / 3.0;
Console.WriteLine("z = " + z + ";  zz " + zz);


Console.WriteLine("остаток от деления 10/3 = " + 10 % 3);

*/

/*
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

Console.WriteLine();
*/

/*

//метод с передачей параметров
void PrintMessage(string message)
{
    Console.WriteLine("I print this: " + message);
}

PrintMessage("weroijo");
PrintMessage("234234");

//метод с двумя параметрами
void MethSum(int num1, int num2)
{
    Console.WriteLine("This method wil print sum of two numbers");
    int result = num1 + num2;
    Console.WriteLine($"num1 ({num1}) + num2({num2}) = {result}");
}
//call method
MethSum(5, 3);
MethSum(5, 3*5);

//разные типы параметров в методе
void PrintTwo(string a, int b)
{
    Console.WriteLine(a + b);
}
int b = 203;
Console.WriteLine();
Console.WriteLine("Вызов метода с двумя параметрами разных типов");
PrintTwo("cстрока", b);


//метод с НЕОБЯЗАТЕЛЬНЫМИ параметрами
//если в определении метода задаешь дефолтное значение,
//то можно и не передавать эти параметры
void UnnessecairyParams(int g, string b = "defaulT string", byte s = 127)
{
    Console.WriteLine($"В метод передается три параметра: g = {g}, b = {b}, c = {s}");
}
Console.WriteLine();
Console.WriteLine("Вызов метода с Тремя параметрами, два из которых необязательные (имеют дефолт)");
UnnessecairyParams(132, "iujl");

Console.WriteLine();
Console.WriteLine("Тот же вывод, но с передачей параметров по имени, а не по позиции");
UnnessecairyParams(42, s: 5, b: "InsteadDefault");

//метод с возвращаемым значением (не void)
int GetSum(int num1, int num2)
{
    int result = num1 + num2;
    return result;
}

Console.WriteLine("sum for two nums: " + GetSum(5, 3));
*/

/*
// передача в метод параметров по ссылку https://metanit.com/sharp/tutorial/2.27.php
// если передавать параметр по занчению (обычным способом)
// то в метод передаетсяс КОПИЯ переменной
// и изменений переменной вне метода нет
// Чтобы передать по ссылке нужно использовать перед параметром ref
// тогда внутри метода переменная будет изменена
void Increment(int num)
{
    num++;
    Console.WriteLine("Переменная внутри метода (передана ПО ЗНАЧЕНИЮ): " + num);
}

int num = 5;
Console.WriteLine($"1. Исходное значение переменной num = {num}");
Console.Write("2. Вызов метода Increment()");
Increment(num);
Console.WriteLine($"3. Значение переменной после метода Increment (не изменится) num = {num}");
Console.WriteLine();

// передача переменной по ссылке
// ref надо писать и в ОПРЕДЕЛЕНИИ метода и при ВЫЗОВЕ
void IncrementByRef(ref int num)
{
    num++;
    Console.WriteLine("Переменная внутри метода (передана ПО ЗНАЧЕНИЮ): " + num);
}

num = 5;
Console.WriteLine($"1. Исходное значение переменной num = {num}");
Console.Write("2. Вызов метода IncrementByRef()");
IncrementByRef(ref num);
Console.WriteLine($"3. Значение переменной после метода IncrementByRef (было изменено методом) num = {num}");
Console.WriteLine();

// выходные параметры - модификатор out
// это вместо return
void GetSumResult(int a, int b, out int result)
{
    Console.WriteLine("Внутри метода GetSumResultп ереданы числа a, b: " + a + ", " + b);
    result = a + b;
}
int a = 2;
int b = 3;
int sum;
//int sum = GetSumResult(a, b, out sum); - так нельзя, потому что метод void и не возвращает значения
GetSumResult(a, b, out sum);
Console.WriteLine("Сумма, возвращенная в методе через out: " + sum);
Console.WriteLine();


// через out можно вернуть из метода НЕСКОЛЬКО значений (return возвращает только одно)
// а модификатор in - передает в метод переменную, которую НЕЛЬЗЯ ИЗМЕНИТЬ внутри метода
// метод возвращает ДВА значения (периметр и площадь прямоугольника
void GetRectangleData(in int lenght, in int width, out int rectPerimetr, out int rectArea)
{
    Console.WriteLine($"Внутри метода GetRectangleData. На вход подали длину {lenght} и ширину {width}");
    rectPerimetr = (lenght + width) * 2;
    rectArea = lenght * width;

}

a = 4; b = 5;
Console.WriteLine($"Передаю на вход длину {a} и ширину {b}");

GetRectangleData(4, 5, out int Perimetr, out int Area);
Console.WriteLine("Периметр: " + Perimetr + " Площадь: " + Area);
Console.WriteLine();

// передача НЕОПРЕДЕЛЕННОГО количества параметров с модификатором params
// сначала в метод передаются все известные параметры, потом неопределенное количество
// после params нельзя опять передавать известные параметры
// метод принимающий имя, фамилию и ОПЦИОНАЛЬНО отчество и eMail
void PrintPersData(string name, string lastname, params string[] other)
{
    Console.WriteLine("Внутри метода PrintPersData");
    Console.Write("Имя: " + name + ". Фамилия: " + lastname + ".");
    if (other.Length > 0) Console.Write("  Отчество: " + other[0]);
    if (other.Length > 1) Console.Write("  Email1: " + other[1]);
    if (other.Length > 2) Console.Write("  Email2: " + other[2]);
}

// вызов с отчеством и одним имэйл
PrintPersData("Иван", "Медведев", "Николаевич", "mail1@ya.ru");
// вызовв без доп параметров
PrintPersData("Петя", "Иванов");
// вызовв с пятью
PrintPersData("Гриша", "Дармоедов", "Батькович", "мыло1", "мыло2");

Console.WriteLine();

*/

// локальные функции https://metanit.com/sharp/tutorial/2.20.php
/*
//метод с ЛОКАЛЬНОЙ ФУНКЦИЕЙ внутри, сравнивающей суммы чисел двух массивов
void CompareSums(int[] array1, int[] array2, out int result)
{
    int sum1 = LocalSum(array1);
    int sum2 = LocalSum(array2);
    

    result = sum1 - sum2;

    if (result > 0) Console.WriteLine("Сумма чисел первого массива больше");
    else if (result < 0) Console.WriteLine("Сумма числел второго больше");
    else Console.WriteLine("Суммы равны");


    //собственно локальная функция
    int LocalSum(int[] nums)
    {
        int sum = 0;
        foreach(int num in nums)
        {
            sum += num;
        }
        return sum;
    }
}

int[] arr1 = { 1, 2, 3, 44 };
int[] arr2 = { 1, -2, 3, 4, 5, -1 };

CompareSums(arr1, arr2, out int res);

// то же самое со СТАТИЧЕСКОЙ ЛОКАЛЬНОЙ ФУНКЦИЕЙ внутри метода
//метод находит сумму только положительных элементов массива
//локальная статич.ф-ия проверяет, является ли элемент положительным
void SumOfPositives(int[] array1, int[] array2, out int sum1, out int sum2)
{
    sum1 = 0;
    sum2 = 0;

    //статическая локальная функция определения положительности числа
    static bool IsPositive(int number)
    {
        if (number < 0) return false;
        return true;
    }

    // сумма положительных первого массива
    foreach (int num in array1)
    {
        if(IsPositive(num)) sum1 += num;
    }

    // сумма положительных второго массива
    foreach (int num in array2)
    {
        if (IsPositive(num)) sum2 += num;
    }

    Console.WriteLine("Сумма положительных первого массива: " + sum1);
    Console.WriteLine("Сумма положительных второго массива: " + sum2);

}

int[] array1 = { -2, -3, 0, 0, 2, 5 };
int[] array2 = { -2, -3, -4, 0, 2, -5 };

//вызов метода со статической ф-ией внутри
SumOfPositives(array1, array2, out int sm1, out int sm2);
Console.WriteLine("sm1, sm2 : " + sm1 + " " + sm2);
Console.WriteLine();


*/


/*
// оператор SWITCH https://metanit.com/sharp/tutorial/3.45.php
Console.WriteLine("Введите число, а я определю его знак");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Вы ввели число: " + num);

//int znak = (num >= 0) ? 1 : -1;  

switch (num)
{
    case >= 0 :
        Console.WriteLine("Число положительное");
        break;

    case < 0:
        Console.WriteLine("Число отрицательное");
        break;
}


Console.WriteLine("Введите 2 числа: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Выберите действие: 1 - сложить, 2 - вычесть, 3 - умножить");
int action = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Вы ввели числа {a} и {b}. Действие над числами {action}");

// метод со switch
int DoOperation(int a, int b, int operation)
{
    switch (operation)
    {
        case 1: return a + b;
        case 2: return a - b;
        case 3: return a * b;
            default: return 0;
    }
}

Console.WriteLine("Результат: " + DoOperation(a, b, action));


*/

// перечисления enum https://metanit.com/sharp/tutorial/2.12.php
///*
const DayTime dayTi = DayTime.Morning;


if (dayTi == DayTime.Morning)
{
    Console.WriteLine("Доброе утро");
}
else if (dayTi == DayTime.Evening)
{
    Console.WriteLine("Добрый вечер");
}

DayTime now = DayTime.Afternoon;

PrintMessage(now);
PrintMessage(DayTime.Evening);
PrintMessage(DayTime.Morning);

void PrintMessage(DayTime dayTime)
{
    switch (dayTime)
    {
        case DayTime.Morning:
            Console.WriteLine("Доброе утро!");
            break;

        case DayTime.Evening:
            Console.WriteLine("Добрый вечер");
            break;

        case DayTime.Night:
            Console.WriteLine("Доброй ночи");
            break;

        case DayTime.Afternoon:
            Console.WriteLine("Добрый день");
            break;
    }
}



//пример switch с арефмитическими операциями
//метод выполняющий операцию из перечисления Operation
void DoOperation(int a, int b, Operation op)
{
    //перерменная с результатом
    double result;

    result = op switch
    {
        Operation.Add => a + b,
        Operation.Substract => a - b,
        Operation.Multiply => a * b,
        Operation.Divide => a / b
    };

    //напечатать результат
    Console.WriteLine("Результат равен: " + result);
}

DoOperation(2, 3, Operation.Add);
DoOperation(3, 4, Operation.Substract);
DoOperation(5, 5, Operation.Multiply);
DoOperation(10, 3, Operation.Divide);

enum Operation
{
    Add,
    Substract,
    Multiply,
    Divide
}

enum DayTime
{
    Morning,
    Evening,
    Afternoon,
    Night
}



//*/