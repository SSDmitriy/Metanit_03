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
double z = 10 / 3;

//или дробным (если указал вещественные литералы
double zz = 10.0 / 3.0;
Console.WriteLine("z = " + z + ";  zz " + zz);


Console.WriteLine("остаток от деления 10/3 = " + 10 % 3);


//логическое умножение & : 1011 & 1110 = 1010 = "10"
Console.WriteLine("11 & 14 = " + (11 & 14));

//логическое сложение | : 1010 & 1100 = 1110 = "10"
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







