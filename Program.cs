Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("Александр", 150);

Console.WriteLine(yaroslav.GetInfo());
Console.WriteLine();
Console.WriteLine(anastasia.GetInfo());
Console.WriteLine();
Console.WriteLine(artem.GetInfo());
Console.WriteLine();
Console.WriteLine(alexander.GetInfo());









// Game sky = new Game("Sky", "Adventure", 2024);
// Game detroit = new Game("Detroit: Become Human", "Action-adventure", 2019);
// Game fnaf = new Game("Five Nights at Freddy`s", "Survival horror", 2014);

// Console.WriteLine(">>> Игра 1 <<<");
// Console.WriteLine($"Название: {sky.Name}");
// Console.WriteLine($"Жанр: {sky.Genre}");
// Console.WriteLine($"Дата выхода: {sky.Release_date}");
// Console.WriteLine($"Рейтинг: {sky.Rating}");

// Console.WriteLine();

// Console.WriteLine(">>> Игра 2 <<<");
// Console.WriteLine($"Название: {detroit.Name}");
// Console.WriteLine($"Жанр: {detroit.Genre}");
// Console.WriteLine($"Дата выхода: {detroit.Release_date}");
// Console.WriteLine($"Рейтинг: {detroit.Rating}");

// Console.WriteLine();

// Console.WriteLine(">>> Игра 3 <<<");
// Console.WriteLine($"Название: {fnaf.Name}");
// Console.WriteLine($"Жанр: {fnaf.Genre}");
// Console.WriteLine($"Дата выхода: {fnaf.Release_date}");
// Console.WriteLine($"Рейтинг: {fnaf.Rating}");

// Console.WriteLine();

// Console.WriteLine($"Рейтинг Sky до вызова: {sky.Rating}");

// sky.ChangeRating(8);
// Console.WriteLine($"Рейтинг Sky после вызова: {sky.Rating}");

// sky.ChangeRating(15);
// Console.WriteLine($"Рейтинг Sky после недопустимого вызова: {sky.Rating}");