Console.Write("Введите пароль: ");
string password = Console.ReadLine();
Console.Write("Подтвердите пароль: ");
string result = Console.ReadLine() == password ? "Пароль принят" : "Пароль не принят";
Console.WriteLine(result);
Console.WriteLine();

Console.Write("Введите ваш возраст: ");
int age = int.Parse(Console.ReadLine());
string access = age >= 18 ? (age < 120 ? "Доступ разрешён" : "Неверный возраст") : "Доступ запрещён";
Console.WriteLine(access);
Console.WriteLine();

Console.Write("Введите первое число: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int y = int.Parse(Console.ReadLine());
Console.Write("Введите операцию (+, -, *, /): ");
string op = Console.ReadLine();

switch (op)
{
    case "+":
        Console.WriteLine($"{x} + {y} = {x + y}");
        break;
    case "-":
        Console.WriteLine($"{x} - {y} = {x - y}");
        break;
    case "*":
        Console.WriteLine($"{x} * {y} = {x * y}");
        break;
    case "/":
        string resultOp = y != 0 ? $"{x} / {y} = {x / y}" : "Деление на ноль запрещено!";
        Console.WriteLine(resultOp);
        break;
    default:
        Console.WriteLine("Введена некорректная операция.");
        break;
}
Console.WriteLine();

Console.Write("Введите три числа (Через Enter): ");
int sum = 0;
List<int> nums = [int.Parse(Console.ReadLine()),
                  int.Parse(Console.ReadLine()),
                  int.Parse(Console.ReadLine())];

foreach (int num in nums)
{
    sum += num > 0 ? num : 0;
}

Console.WriteLine(sum);
Console.WriteLine();

Console.WriteLine("=== ДОБРО ПОЖАЛОВАТЬ В ТЁМНЫЙ ЛАБИРИНТ ===");
Console.WriteLine("Вы — отважный искатель приключений, отправившийся в Темный Лабиринт, чтобы найти легендарного Dungeon Master’а. Вам предстоит пройти через несколько комнат, каждая из которых может иметь свои опасности и сокровища.");
Console.WriteLine("1. Вы стоите перед первой дверью. Перед вами два пути.");
Console.Write("Ваш выбор (1, 2): ");
int choice = int.Parse(Console.ReadLine());
if (choice == 1)
{
    Console.WriteLine("Путь А: Войти в комнату с огромным драконом.");
    Console.WriteLine("Вам нужно будет ответить на загадку дракона:");
    Console.WriteLine("Дракон говорит: \"Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.\"");
    Console.Write("Введите ответ: ");
    string answer = Console.ReadLine().ToLower();
    string right = answer == "рыба" ? "Проходите дальше" : $"ПОРАЖЕНИЕ! Дракон съел вас! (правильный ответ \"рыба\" вы ввели \"{answer}\")";
    Console.WriteLine(right);
}
else if (choice == 2)
{
    Console.WriteLine("Путь B: Пойти по тёмному коридору");
    Console.WriteLine("Вас ждёт тёмная комната с двумя дверями:");


    Console.Write("Ваш выбор (1, 2): ");
    int secondChoice = int.Parse(Console.ReadLine());
    switch (secondChoice)
    {
        case 1:
            Console.WriteLine("Дверь 1: За ней скрыты сокровища Dungeon Master’а.");
            Console.WriteLine("ПОБЕДА! Вы нашли сокровища Dungeon Master'а.");
            break;
        case 2:
            Console.WriteLine("Дверь 2: За ней — ловушка с ядовитыми шипами.");
            Console.WriteLine("ПОРАЖЕНИЕ! Вы попали в ловушку!");
            break;
        default:
            Console.WriteLine("ПОРАЖЕНИЕ! Некорректный ввод!");
            break;
    }
}
else
{
    Console.WriteLine("ПОРАЖЕНИЕ! Некорректный ввод!");
}