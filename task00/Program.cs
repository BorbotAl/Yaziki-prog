//Напишите программу, которая 
// на вход принимает число 
// и выдаёт его квадрат

// Например:
// 4 -> 16
// 3 -> 9
// -7 -> 49

int number = Convert.ToInt32(Console.ReadLine());

int square = number * number;

Console.WriteLine ($"квадрта числа {number} = {square}");