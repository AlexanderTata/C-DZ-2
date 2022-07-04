{ /*Задача №1: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.*/

Console.WriteLine("Введите число ");
string number = Console.ReadLine();
if (number.Length > 2) Console.WriteLine(number[2]);
else Console.WriteLine("Длина массива менее трёх элементов");

/*int number = 123456789; // математический способ решения задачи
int digital = 0;
while (number/100 > 0) 
{
    digital = number % 10;
    number/=10;
}
Console.WriteLine(digital);*/   
}

{ /*Задача №2: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.*/

Console.WriteLine("Введите число недели от 1-7 ");
int number = Convert.ToInt32(Console.ReadLine());
if (number == 6 || number == 7)
{
    Console.WriteLine("Это выходной день");
}
else if (number > 7 || number < 1)
{
    Console.WriteLine("Значение неверное");  
}
else Console.WriteLine("Это будний день");  
}







