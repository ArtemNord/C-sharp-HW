Console.WriteLine ("Для того чтобы узнать какое из трех чисел максимальное, введите их. ");
Console.Write ("Введите первое число: ");
double A = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите второе число: ");
double B = Convert.ToDouble(Console.ReadLine());
Console.Write ("Введите третье число: ");
double C = Convert.ToDouble(Console.ReadLine());

double max = A;

if (B > max) max = B;
if (C > max) max = C;

Console.Write("max = ");
Console.WriteLine(max);