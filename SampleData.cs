// ГОТОВЫЕ ДАННЫЕ: группа из 8 студентов с оценками. Этот файл НЕ МЕНЯТЬ.

public static class SampleData
{
    public const string GroupName = "Ис-25-26б";

    // Каждый вызов создаёт новую группу (новые объекты Student).
    public static Student[] Group()
    {
        return new[]
        {
            Make("Сериков Дамир", 72, 65, 80),
            Make("Ахметова Айгерим", 95, 88, 92),
            Make("Ким Анна", 100, 90),
            Make("Петровых Александр", 60, 55, 70, 59),
            Make("Бекова Мадина", 85, 90, 78),
            Make("Ли Виктор"),                       // оценок пока нет
            Make("Жумабаев Нурлан", 88, 92),
            Make("Денисова Ольга", 85, 85),
        };
    }

    public static Student Make(string name, params int[] scores)
    {
        var s = new Student(name, GroupName);
        foreach (int x in scores) s.AddScore(x);
        return s;
    }
}
