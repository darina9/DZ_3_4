Console.WriteLine("введите число");
int num = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (num > 0)
{
int i = num % 10;
num = num / 10;
sum += i;
 }
Console.WriteLine("сумма всех цифр в числе равна: " + sum);
