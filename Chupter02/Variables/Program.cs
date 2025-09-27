using Variables;

int population = (Convert.ToInt32(Console.ReadLine()));

Console.WriteLine(population);

if (population == (int)Planets.earth) 
{
    Console.Clear();
    Console.WriteLine("Земля"); 
}else if  (population == (int)Planets.mars)
{
    Console.Clear();
    Console.WriteLine("Марс"); 
}
else if (population == (int)Planets.venera)
{
    Console.Clear();
    Console.WriteLine("Венера");
}else 
{
    Console.Clear();
    Console.WriteLine("Error uebok"); 
}