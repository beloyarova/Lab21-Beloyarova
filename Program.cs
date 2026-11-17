// Метод безопасной вставки

bool InsertTaskSafe(List<string> tasks, int index, string title)
{
    if (index < 0 || index > tasks.Count)
    {
        return false;
    }

    tasks.Insert(index, title);
    return true;
}


// Перебор списка

void PrintTasks(List<string> tasks)
{
    if (tasks.Count == 0)
    {
        Console.WriteLine("Список пуст");
        return;
    }
    for (int i = 0; i < tasks.Count; i++)
    {
        Console.WriteLine($"{i}: {tasks[i]}");
    }
}


// Шаг 5

bool RemoveTaskAtSafe(List<string> tasks, int index)
{
    if (index < 0 || index >= tasks.Count)
    {
        return false;
    }
    tasks.RemoveAt(index);
    return true;
}

// Шаг 8

Console.Write("Сколько задач добавить сначала: ");
int count = Convert.ToInt32(Console.ReadLine());

List<string> tasks = new List<string>();

for (int i = 0; i < count; i++)
{
    Console.Write($"Задача {i + 1}: ");
    string title = Console.ReadLine() ?? "";
    tasks.Add(title);
}

// 1
PrintTasks(tasks);

// 2
Console.Write("Название новой задачи для добавления: ");
string text = Console.ReadLine();
tasks.Add(text);
Console.WriteLine("Задача добавлена");

// 3
Console.Write("Задача для вставки: ");
string text1 = Console.ReadLine();
Console.Write("Индекс для вставки: ");
int number = int.Parse(Console.ReadLine());

if (InsertTaskSafe(tasks, number, text1))
{
    Console.WriteLine("Задача вставлена");
}
else
{
    Console.WriteLine("Недопустимый индекс вставки");
}

// 4
Console.Write("Название для удаления: ");
string text2 = Console.ReadLine();
if (tasks.Remove(text2))
{
    Console.WriteLine("Первое совпадение удалено");
}
else
{
    Console.WriteLine("Задача не найдена");
}

// 5
Console.Write("Индекс для удаления: ");
int number2 = int.Parse(Console.ReadLine());

if (RemoveTaskAtSafe(tasks, number2))
{
    Console.WriteLine("Задача по индексу удалена");
}
else
{
    Console.WriteLine("Недопустимый индекс удаления");
}

// 6
Console.Write("Название для поиска: ");
string text3 = Console.ReadLine();
int found = tasks.IndexOf(text3);

if (found >= 0)
{
    Console.WriteLine($"Первый индекс: {found}");
}
else
{
    Console.WriteLine("Задача не найдена");
}

// 7
Console.WriteLine(">>> Итоговый список дел <<< ");
Console.WriteLine($"Количество задач: {tasks.Count}");
PrintTasks(tasks);
