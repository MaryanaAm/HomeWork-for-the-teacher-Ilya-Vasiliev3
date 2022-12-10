// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.WriteLine("Для проверки введите пятизначное число:");
string nums = Console.ReadLine() ?? "";

bool result = int.TryParse(nums, out int n);
if(result)
{
    nums = Math.Abs(n).ToString(); 

    if(nums.Length != 5)
    {
        Console.WriteLine("Вы ввели некорректное число! Введите пятизначное число");
        return;
    }
    else
    {
        if(nums[0] == nums[4] && nums[1] == nums[3])
        {
            Console.WriteLine("Данное число является палиндромом");  
        }
        else
        {
            Console.WriteLine("Данное число не является палиндромом"); 
        }
    }
}
else
{
    Console.WriteLine("Вы ввели не число! Введите пятизначное число: ");
}
