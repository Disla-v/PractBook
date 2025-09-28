using Variables;

int kgPerson = 70;
int population = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine(population);

if (population == (int)Planets.earth) 
{
    Console.Clear();
    Console.WriteLine("Общая масса людей на планете в среднем " +kgPerson*(int)Planets.earth); 
}else if  (population == (int)Planets.mars)
{
    Console.Clear();
    Console.WriteLine("Общая масса людей на планете в среднем " + kgPerson * (int)Planets.mars); 
}
else if (population == (int)Planets.venera)
{
    Console.Clear();
    Console.WriteLine("Общая масса людей на планете в среднем " + kgPerson * (int)Planets.venera);
}else 
{
    Console.Clear();
    Console.WriteLine("Error uebok"); 
}
