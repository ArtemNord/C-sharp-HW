Console.WriteLine("Для того чтобы узнать все четные числа до вашего Числа. Введите его: ");
double A = Convert.ToDouble(Console.ReadLine());

double index = 1;

while (index <= A)
{
    if (index % 2 == 0)
        Console.WriteLine(index);
    index++;    
}