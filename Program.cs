// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);
// Hero alexander = new Hero("   Александр   ", 150);

// alexander.TakeDamage(10);
// alexander.Heal(10);

// Console.WriteLine(">>> Участники готовы <<<");
// Console.WriteLine();
// Console.WriteLine(yaroslav.GetInfo());
// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());
// Console.WriteLine();
// Console.WriteLine(alexander.GetInfo());
// Console.WriteLine($"Предел здоровья Александра: {alexander.MaxHealth}");







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

Console.WriteLine($"Рейтинг Sky до вызова: {sky.Rating}");

sky.ChangeRating(8);
Console.WriteLine($"Рейтинг Sky после вызова: {sky.Rating}");

sky.ChangeRating(15);
Console.WriteLine($"Рейтинг Sky после недопустимого вызова: {sky.Rating}");

Console.WriteLine($"Год выхода sky до: {sky.Release_date}");

sky.ChangeReleaseDate(2005);
Console.WriteLine($"Год выхода sky после: {sky.Release_date}");

sky.ChangeReleaseDate(1800);
Console.WriteLine($"Год выхода sky после недопустимого действия: {sky.Release_date}");

Game cod = new Game("Call of Duty", "Shooter", 1800);
Console.WriteLine($"Создание с неверным годом выхода: {cod.Release_date}");
Console.WriteLine($"Год выхода Detroit: Become Human без изменений: {detroit.Release_date}");