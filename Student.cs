// ГОТОВЫЙ КЛАСС из лекции «Классы и объекты». Этот файл НЕ МЕНЯТЬ.
// Его нужно правильно использовать в Program.cs.

public class Student
{
    public const int MaxScores = 10;                // больше 10 оценок не принимается

    private readonly int[] _scores = new int[MaxScores];

    public string Name { get; }                     // только чтение
    public string Group { get; }
    public int Count { get; private set; }          // сколько оценок добавлено

    public Student(string name, string group)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Имя не может быть пустым", nameof(name));
        Name = name.Trim();
        Group = group;
    }

    // Добавляет оценку 0–100. Если оценка неверная или места нет — false.
    public bool AddScore(int score)
    {
        if (score < 0 || score > 100 || Count == MaxScores) return false;
        _scores[Count] = score;
        Count++;
        return true;
    }

    // Средний балл; 0, если оценок нет. Вычисляется при каждом обращении.
    public double Average
    {
        get
        {
            if (Count == 0) return 0;
            int sum = 0;
            for (int i = 0; i < Count; i++) sum += _scores[i];
            return (double)sum / Count;
        }
    }

    public bool HasScores => Count > 0;             // есть ли хотя бы одна оценка

    public override string ToString() =>
        $"{Name} ({Group}): оценок {Count}, средний {Math.Round(Average, 1)}";
}
