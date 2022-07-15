// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, 
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3



int sumplus = 0;
//int summinus = 0;
int i = 0;
while (i < 5)
{
    Console.WriteLine("введи значение a:");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a > 0)
    {
        sumplus = sumplus + 1; 
    }
    //if (a <= 0)
    //{
    //    summinus = summinus + 1;         
    //}
    i++;
}
Console.WriteLine($"{sumplus} - положительных чисел");
//Console.WriteLine($"{summinus} - отрицательных чисел");


