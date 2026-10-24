// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);

// yaroslav.Health = 75;

// Console.WriteLine(">>> Герой 1 <<<");
// Console.WriteLine($"Имя: {yaroslav.Name}");
// Console.WriteLine($"Здоровье: {yaroslav.Health}");
// Console.WriteLine($"Уровень: {yaroslav.Level}");
// Console.WriteLine($"Опыт: {yaroslav.Experience}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 2 <<<");
// Console.WriteLine($"Имя: {anastasia.Name}");
// Console.WriteLine($"Здоровье: {anastasia.Health}");
// Console.WriteLine($"Уровень: {anastasia.Level}");
// Console.WriteLine($"Опыт: {anastasia.Experience}");

// Console.WriteLine();

// Console.WriteLine(">>> Герой 3 <<<");
// Console.WriteLine($"Имя: {artem.Name}");
// Console.WriteLine($"Здоровье: {artem.Health}");
// Console.WriteLine($"Уровень: {artem.Level}");
// Console.WriteLine($"Опыт: {artem.Experience}");

Game sky = new Game("Sky", "Adventure", 2024);
Game detroit = new Game("Detroit: Become Human", "Action-adventure", 2019);
Game fnaf = new Game("Five Nights at Freddy`s", "Survival horror", 2014);

Console.WriteLine(">>> Игра 1 <<<");
Console.WriteLine($"Название: {sky.Name}");
Console.WriteLine($"Жанр: {sky.Genre}");
Console.WriteLine($"Дата выхода: {sky.Release_date}");
Console.WriteLine($"Рейтинг: {sky.Rating}");

Console.WriteLine();

Console.WriteLine(">>> Игра 2 <<<");
Console.WriteLine($"Название: {detroit.Name}");
Console.WriteLine($"Жанр: {detroit.Genre}");
Console.WriteLine($"Дата выхода: {detroit.Release_date}");
Console.WriteLine($"Рейтинг: {detroit.Rating}");

Console.WriteLine();

Console.WriteLine(">>> Игра 3 <<<");
Console.WriteLine($"Название: {fnaf.Name}");
Console.WriteLine($"Жанр: {fnaf.Genre}");
Console.WriteLine($"Дата выхода: {fnaf.Release_date}");
Console.WriteLine($"Рейтинг: {fnaf.Rating}");

Console.WriteLine();