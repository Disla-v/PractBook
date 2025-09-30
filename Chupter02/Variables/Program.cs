using System.ComponentModel.DataAnnotations;
using System.Xml;
using Variables;
using static System.Console;

//string[] names;
//names = new string[4];
//names[0] = "Iron";
//names[1] = "Koha";
//names[2] = "Leon";
//names[3] = "Kate";

//for (int i = 0; i < names.Length; i++)
//{
//    Console.WriteLine(names[i]);
//}

//int[] ages = new[]
//{
//     1,2,3,4,5,1,2,5,513,13,2,131,3,5,31,13,5,5131,5,1
//};
//Console.WriteLine($"default(int) = {default(int)}");
//Console.WriteLine($"default(bool) = {default(bool)}");
//Console.WriteLine($"default(DateTime) = {default(DateTime)}");
//Console.WriteLine($"default(string) = {default(string)}");
//int number = 13;
//Console.WriteLine($"number has been set to: {number}");
//number = default;
//Console.WriteLine($"number has been reset to its default: {number}");
////int kgPerson = 70;
////int population = (Convert.ToInt32(Console.ReadLine()));

////Console.WriteLine(population);

////if (population == (int)Planets.earth) 
////{
////    Console.Clear();
////    Console.WriteLine("Общая масса людей на планете в среднем " +kgPerson*(int)Planets.earth); 
////}else if  (population == (int)Planets.mars)
////{
////    Console.Clear();
////    Console.WriteLine("Общая масса людей на планете в среднем " + kgPerson * (int)Planets.mars); 
////}
////else if (population == (int)Planets.venera)
////{
////    Console.Clear();
////    Console.WriteLine("Общая масса людей на планете в среднем " + kgPerson * (int)Planets.venera);
////}else 
////{
////    Console.Clear();
////    Console.WriteLine("Error uebok"); 
////}
//var xml1 = new XmlDocument();
//XmlDocument xml2 = new XmlDocument();
//var file1 = File.CreateText("something1.txt");
//StreamWriter file2 = File.CreateText("something2.txt");

//Car policeCar = new();
//policeCar.name = "Bugatti";
//policeCar.description = "Fast";
//policeCar.series = 12;
//policeCar.realize = true;
//policeCar.mass = 920;

//Car homelessCar = new()
//{
//    name = "Sheron",
//    description = "Comfort",
//    series = 0384,
//    realize = true,
//    mass = 1200
//};


//Console.WriteLine(policeCar.name);



Write("Нажмите на сочетание клиавишь: ");
ConsoleKeyInfo key = Console.ReadKey();
Console.WriteLine();
Console.WriteLine("Key {0}, Char {1}, Modifieres {2}", arg0:key.Key, arg1:key.KeyChar, arg2:key.Modifiers);