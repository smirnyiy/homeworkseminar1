/*
//1.Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("input firest int number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second int number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if(num1 > num2){
    Console.WriteLine($"{num1} это число больше {num2} ");
}
else{
    Console.WriteLine($"{num2} это число больше {num1}");
}
*/

/*
//2. Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;
if(num2 > num1) max = num2;
if(num3 > num2) max = num3;
{
    Console.WriteLine($"{max} это большее число");
}
*/

//3. Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
/*
Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

int current = num;
if(num%2 == 0){
    Console.WriteLine($"{num} четное");
}
else{
    Console.WriteLine($"{num} не четное");
}
*/
/*
//4. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

    int current = 1;
    for (int i = current; i <= num; i++)
        if (i%2 == 0)
        {
            Console.WriteLine(i + " ");}
*/