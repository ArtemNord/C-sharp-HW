Console.WriteLine ("Для того чтобы узнать какое число больше, необходимо ввести их в порядке очереди.");
Console.Write ("Введите первое число: ");
double A = Convert.ToDouble (Console.ReadLine ());
Console.Write ("Введите второе число: ");
double B = Convert.ToDouble (Console.ReadLine ());

double max = A;
double min = B;

if (max > min)
{
    Console.Write ("Число ");
    Console.Write (A);
    Console.Write (" больще, а число ");
    Console.Write (B);
    Console.Write (" меньше");
}
    else if (max < min)
    {
       Console.Write ("Число ");
       Console.Write (B);
       Console.Write (" больще, а число ");
       Console.Write (A);
       Console.Write (" меньше");
    }

        else
        Console.Write ("Они равны");