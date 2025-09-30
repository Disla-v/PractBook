
using static System.Console;
//int numberOfApples = 12;
//decimal pricePerApple = 0.35M;

//Console.WriteLine(format: "{0} apples cost {1:C}", arg0:numberOfApples, arg1:pricePerApple*numberOfApples);

//Console.WriteLine($"{numberOfApples} apples costs {pricePerApple * numberOfApples:C}");

//string applesText = "12312";
//int applesCount = 123;

//string bananasText = "41i3f";
//int bananasCount = 213;

//Console.WriteLine(format: "{0,-10} {1,6}", arg0: "appleText", arg1: "Count");
//Console.WriteLine(format: "{0,-10} {1,6:N0}",arg0: applesText,arg1: applesCount);
//Console.WriteLine(format: "{0,-10} {1,6:N0}",arg0: bananasText,arg1: bananasCount);

//Console.WriteLine($"{"appleText",-10} {"Count",6}");
//Console.WriteLine($"{applesText,-10} {applesCount}");
//Console.WriteLine($"{bananasText,-10} {bananasCount}");

Write("Введите своё имя и нажмите ENTER: ");
string? firstName = Console.ReadLine();
Console.Write("Введите свой возвраст и нажмите ENTER");
string? age = Console.ReadLine();

Console.WriteLine($"Здарова {firstName}, слышал тебе уже {age} годиков");
