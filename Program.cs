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
List<string> searchableTasks = new List<string> { "Код", "Тест", "Код" }; 
Console.WriteLine(searchableTasks.Contains("Код")); 
Console.WriteLine(searchableTasks.Contains("План")); 
Console.WriteLine(searchableTasks.IndexOf("Код"));
Console.WriteLine(searchableTasks.IndexOf("План"));

int index = searchableTasks.IndexOf("Код"); 
if (index >= 0) 
{ 
    Console.WriteLine($"Первый индекс: {index}"); 
} 
else 
{ 
    Console.WriteLine("Задача не найдена"); 
}  