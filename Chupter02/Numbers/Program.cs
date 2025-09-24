using System;

uint baturalNumber = 32;
int inegerNumber = -32;
float realNumber = 2.5f;
double anotherRealNumber = 2.3;


int decimalNotation = 2_000_000;
int binaryNotation = 0b_0001_1110_1000_0100_1000_0000;
int hexadecimalNotation = 0x_001E_8480;

Console.WriteLine($"{decimalNotation == binaryNotation}");
Console.WriteLine($"{decimalNotation == hexadecimalNotation}");

Console.WriteLine($"int uses {sizeof(int)} bytes and can store numbers inthe range { int.MinValue:N0}to {int.MaxValue:N0}.");
Console.WriteLine($"double uses {sizeof(double)} bytes and can storenumbers in the range { double.MinValue:N0}to {double.MaxValue:N0}.");
Console.WriteLine($"decimal uses {sizeof(decimal)} bytes and can storenumbers in the range { decimal.MinValue:N0}to {decimal.MaxValue:N0}.");

Console.WriteLine("Using decimals:");
decimal c = 0.1M; // суффикс M обозначает десятичное литеральное значение
decimal d = 0.2M;
if (c + d == 0.3M)
{
    Console.WriteLine($"{c} + {d} equals {0.3M}");
}
else
{
    Console.WriteLine($"{c} + {d} does NOT equal {0.3M}");
}