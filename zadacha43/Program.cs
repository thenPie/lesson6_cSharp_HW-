// double k1 = 5, b1 = 2, k2 = 9, b2 = 4;

Console.WriteLine("k1, b1 - первая, k2, b2 - вторая, в такой очереди через пробел");
var input = Console.ReadLine();
var space = input.Split(" ");
double k1 = int.Parse(space[0]);
double b1 = int.Parse(space[1]);
double k2 = int.Parse(space[2]);
double b2 = int.Parse(space[3]);

double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;

Console.Write($"({x}; {y})");