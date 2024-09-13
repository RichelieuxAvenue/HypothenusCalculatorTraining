// See https://aka.ms/new-console-template for more information

Console.WriteLine("Veuillez saisir coté 1: ");
double a = double.Parse(Console.ReadLine());

Console.WriteLine("Veuillez saisir coté 2: ");
double b = double.Parse(Console.ReadLine());

double hypothenus = Math.Sqrt((Math.Pow(a, 2) + Math.Pow(b, 2)));

Console.WriteLine($"Si le coté 1 est {a}cm et le coté 2 est {b}cm alors l'hypothénus est {hypothenus:F2}cm");
