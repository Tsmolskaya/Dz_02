//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

Console.Write("Введите цифру дня недели от 1 до 7: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(IsThatWeekends(num));

    string IsThatWeekends(int number)
    {
        if ((number < 6) & (number > 0)) return "нет";
        else return "да"; 
    }
