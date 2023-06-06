// See https://aka.ms/new-console-template for more information

int val = 34786;

int v1 = val / 10000;
Console.WriteLine(v1);
int v2 = (val - v1 * 10000) / 1000;
Console.WriteLine(v2);
int v3 = (val - (v1 * 10000) - (v2 * 1000)) / 100;
Console.WriteLine(v3);
int v4 = (val - (v1 * 10000) - (v2 * 1000) - (v3 * 100)) / 10;
Console.WriteLine(v4);
int v5 = val - (v1 * 10000) - (v2 * 1000) - (v3 * 100) - (v4 * 10);
Console.WriteLine(v5);

