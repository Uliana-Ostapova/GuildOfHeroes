// Hero yaroslav = new Hero("Ярослав", 100);
// Hero anastasia = new Hero("Анастасия", 90);
// Hero artem = new Hero("Артём", 120);

// Console.WriteLine($"До вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(25);
// anastasia.TakeDamage(30);

// Console.WriteLine($"После вызовов: {yaroslav.Health}, {anastasia.Health}, {artem.Health}");

// yaroslav.TakeDamage(-20);
// Console.WriteLine($"После неверного урона: {yaroslav.Health}");

// artem.TakeDamage(200);
// Console.WriteLine($"После сильного урона, Артём: {artem.Health}");

// yaroslav.Heal(10);
// yaroslav.GainExperience(40);
// yaroslav.GainExperience(25);

// Console.WriteLine($"После лечения, Ярослав: {yaroslav.Health}");
// Console.WriteLine($"Опыт Ярослава: {yaroslav.Experience}");

// bool yaroslavAlive = yaroslav.IsAlive();
// Console.WriteLine($"Ярослав жив: {yaroslavAlive}");
// Console.WriteLine($"Артём жив: {artem.IsAlive()}");

// if (yaroslavAlive) {
//     Console.WriteLine("Ярослав может продолжать приключение.");
// } else {
//     Console.WriteLine("Ярослав больше не может сражаться.");
// }

// string info = yaroslav.GetInfo();
// Console.WriteLine("Строка получена. Сейчас выведем её:");
// Console.WriteLine(info);

// Console.WriteLine();
// Console.WriteLine(anastasia.GetInfo());
// Console.WriteLine();
// Console.WriteLine(artem.GetInfo());











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