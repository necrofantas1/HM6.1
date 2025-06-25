#region Обчислення середнього заробітку:
using System.Runtime.ConstrainedExecution;

bool isValidInput = true;

const char cancelChar = 'x';
decimal totalSalary = 0;
int workers = 0;
decimal averageSalary; 

Console.WriteLine("Введіть заробітки працівників (введіть 'x' для виходу):");

while (isValidInput)
{
    string input = Console.ReadLine();

    if (input.ToLower() == cancelChar.ToString())
    {
        isValidInput = false;
        continue;
    }

    if (int.TryParse(input, out int salary) && salary >= 0)
    {
        totalSalary += salary;
        workers++;
    }
    else
    {
        Console.WriteLine("Невірний ввід. Будь ласка, введіть невід'ємне число або 'x' для виходу.");
    }

    // вивід середнього заробітку після кожного введення
    if (workers > 0)
    {
       averageSalary = totalSalary / workers;
       
        Console.WriteLine($"Поточний середній заробіток: {averageSalary:C3}");
        Console.WriteLine($"Працівників: {workers}");
    }
    
}
#endregion

