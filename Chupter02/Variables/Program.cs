object height = 1.88;
object name = "jhon";
Console.WriteLine($"{height},{name} {nameof(name)}");

dynamic something = "Ahmed";
something = 12;
something = new[] {3,5,6};
Console.WriteLine($"Length is {something.Length}");