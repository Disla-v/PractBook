object height = 1.88;
object name = "jhon";
Console.WriteLine($"{height},{name} {nameof(name)}");

dynamic something = "Ahmed";
something = 12;
something = new[] {3,5,6};
Console.WriteLine($"Length is {something.Length}");

int population = 66_000_000; // 66 миллионов человек в Великобритании
double weight = 1.88; // в килограммах
decimal price = 4.99M; // в фунтах стерлингов
string fruit = "Apples"; // строки в двойных кавычках
char letter = 'Z'; // символы в одиночных кавычках
bool happy = true; // логическое значение — true или false

