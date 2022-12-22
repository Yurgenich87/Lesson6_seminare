
/*
bool doCalculation(int a, int b, int c);
{
	return (a < b + c && b < args + c && c < a + b);
}

int a = 8;
int b = 10;
int c = 15;

Console.WriteLine($"Стороны {a} {b} {c}");


if (doCalculation(a, b, c))
	Console.WriteLine("Треугольник может существовать!");
else
	Console.WriteLine("Треугольник не может существовать!");
*/
/*
string GetBinaryFromDecimal(int decimalNumber)
{
	int number = decimalNumber;
	int ostatok = 0;
	string result = string.Empty;

	while (number > 0)
	{
		ostatok = number %= 2;
		number /= 2;
		if (ostatok == 1)
		{
			result += "1";
		}
		else
		{
			result += "0";
		}

	}
	return new string(result.Reverse().ToArray());
}
Console.WriteLine(GetBinaryFromDecimal(11));
Console.WriteLine(GetBinaryFromDecimal(158));

*/
/*
int N = 100;
int fib1 = 0;
int fib2 = 1;
int res = 0;
string str = "0 1 ";

for (int i = 2; i <= N; i++)
{
	res = fib1 + fib2;
	fib1 = fib2;
	fib2 = res;
	str = str += res.ToString() + " ";
}
Console.WriteLine(str);
*/
int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
int[] array2 = new int[array2.Length];

for (int i = 0; i < array2.Length; i++)
	array1[i] = i;
