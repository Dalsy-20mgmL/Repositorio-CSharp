int a = 3;
int b;
int c;

b = ++a;
c = a++;
b = b * 3;
a = a * 2;

Console.WriteLine("a = " + a);
Console.WriteLine("b = " + b);
Console.WriteLine("c = " + c);