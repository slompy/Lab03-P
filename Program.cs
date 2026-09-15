Console.WriteLine("Банковский счёт");

double balance = 1000;
Console.WriteLine($"Начальный баланс: {balance}");

balance += 500; // Пополнение баланс
Console.WriteLine($"После пополнения на 500: {balance}");

balance -= 200; // Покупка
Console.WriteLine($"После покупки на 200: {balance}");

balance *= 1.05; // Начисление 5% 
Console.WriteLine($"После начисления 5%: {balance}");

balance /= 2; // Разделение счёта пополам с партнёром
Console.WriteLine($"После деления пополам: {balance}");


