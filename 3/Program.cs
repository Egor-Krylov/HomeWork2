
Console.Write("Номер дня недели (1-7): ");
int number = Convert.ToInt32(Console.ReadLine());

if (number == 6 || number == 7) Console.WriteLine("Выходной день");
else if (number > 0 && number < 6) Console.WriteLine("Будний день");
else Console.WriteLine("Число не от 1 до 7");