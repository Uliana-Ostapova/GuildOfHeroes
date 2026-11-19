// Probe.Run();
Hero yaroslav = new Hero("Ярослав", 100);
Hero anastasia = new Hero("Анастасия", 90);
Hero artem = new Hero("Артём", 120);
Hero alexander = new Hero("   Александр   ", 150);
Hero sergey = new Hero("Сергей", 110);

alexander.TakeDamage(10);
alexander.Heal(10);

Guild guild = new Guild("Гильдия героев");
guild.AddHero(yaroslav);
guild.AddHero(anastasia);
guild.AddHero(artem);
guild.AddHero(alexander);
guild.AddHero(sergey);

Console.WriteLine($">>> {guild.Name}: участников {guild.MemberCount} <<<");
Console.WriteLine();

QuestBoard board = new QuestBoard(guild);

Quest floatQuest = new Quest(101, "Вернуть поплавок", 100, 30);
Console.WriteLine($"Поручение добавлено: {board.AddQuest(floatQuest)}");
Console.WriteLine($">>> №{floatQuest.Id}: {floatQuest.Title} <<<");

Console.WriteLine($"Назначение Сергея: {board.TryAssign(101, " сЕрГеЙ ")}");
Hero? assigned = floatQuest.AssignedHero;
if (assigned != null) {
    Console.WriteLine($"Исполнитель: {assigned.Name}");
}
Console.WriteLine($"Опыт после назначения: {sergey.Experience}");

Console.WriteLine($"Завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после завершения: {sergey.Experience}");
Console.WriteLine($"Повторное завершение: {board.TryComplete(101)}");
Console.WriteLine($"Опыт после повтора: {sergey.Experience}");

Console.WriteLine();
Console.WriteLine(floatQuest.GetInfo());
Console.WriteLine(sergey.GetInfo());






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

// Console.WriteLine($"Год выхода sky до: {sky.Release_date}");

// sky.ChangeReleaseDate(2005);
// Console.WriteLine($"Год выхода sky после: {sky.Release_date}");

// sky.ChangeReleaseDate(1800);
// Console.WriteLine($"Год выхода sky после недопустимого действия: {sky.Release_date}");

// Game cod = new Game("Call of Duty", "Shooter", 1800);
// Console.WriteLine($"Создание с неверным годом выхода: {cod.Release_date}");
// Console.WriteLine($"Год выхода Detroit: Become Human без изменений: {detroit.Release_date}");

// Game bioshock = new Game("   BioShock   ", "Shooter", 2007);
// Game noName = new Game("   ", "Adventure", 1800);

// Console.WriteLine($"Первая игра: {bioshock.Name}, {bioshock.Release_date}, рейтинг {bioshock.Rating}");
// Console.WriteLine($"Вторая игра: {noName.Name}, {noName.Release_date}, рейтинг {noName.Rating}");

// bioshock.ChangeRating(7);
// Console.WriteLine($"Обычное изменение рейтинга: {bioshock.Rating}");
// bioshock.ChangeRating(1);
// Console.WriteLine($"Граничное изменение рейтинга: {bioshock.Rating}");
// bioshock.ChangeRating(11);
// Console.WriteLine($"Некорректное изменение рейтинга: {bioshock.Rating}");

// bioshock.ChangeReleaseDate(1970);
// Console.WriteLine($"Граничное изменение года: {bioshock.Release_date}");
// bioshock.ChangeReleaseDate(1969);
// Console.WriteLine($"Некорректное изменение года: {bioshock.Release_date}");

// Console.WriteLine();

// Catalog catalog = new Catalog("Каталог игр");
// catalog.AddGame(sky);
// catalog.AddGame(detroit);
// catalog.AddGame(fnaf);

// Game portal = new Game("Portal 2", "Puzzle", 2011);
// catalog.Games.Add(portal);

// Console.WriteLine($">>> {catalog.Name}: список <<<");
// Console.WriteLine($"Игр в каталоге: {catalog.Games.Count}");

// if (catalog.Games.Count > 0)
// {
//     Console.WriteLine($"Первая: {catalog.Games[0].Name}");
//     Console.WriteLine($"Последняя: {catalog.Games[catalog.Games.Count - 1].Name}");
// }

// Console.WriteLine();
// foreach (Game game in catalog.Games)
// {
//     Console.WriteLine(game.GetInfo());
//     Console.WriteLine();
// }

// int modernCount = 0;
// foreach (Game game in catalog.Games)
// {
//     if (game.Release_date >= 2024)
//     {
//         modernCount += 1;
//     }
// }
// Console.WriteLine($"Вышли в 2024 году или позже: {modernCount}");

// fnaf.ChangeRating(6);
// Console.WriteLine($"Рейтинг Five Nights at Freddy`s через переменную: {fnaf.Rating}");
// Console.WriteLine($"Рейтинг Five Nights at Freddy`s через список: {catalog.Games[2].Rating}");

// Catalog catalog = new Catalog("Каталог игр");

// Game firstGame = new Game("FirstGame", "Adventure", 2024);
// Game secondGame = new Game("SecondGame", "Action-adventure", 2019);
// Game notGame = new Game("  NoTgAmE       ", "Survival horror", 2014);

// catalog.AddGame(firstGame);
// catalog.AddGame(secondGame);
// catalog.AddGame(notGame);

// List<Game> games = catalog.GetGames();

// Game? foundGame = catalog.FindGameByName("FirstGame");

// if (foundGame != null)
// {
//     Console.WriteLine($"Найдено по запросу: {foundGame.Name}");
// } else
// {
//     Console.WriteLine("Игра по запросу не найдена.");
// }

// Game? missingGame = catalog.FindGameByName("Несуществующая игра");

// if (missingGame != null)
// {
//     Console.WriteLine($"Найдено по запросу: {missingGame.Name}");
// } else
// {
//     Console.WriteLine("Игра по запросу не найдена.");
// }

// Console.WriteLine($"Количество игр с 2015 года: {catalog.CountGamesFromYear(2015)}");
// Console.WriteLine($"Игр до удаления: {catalog.GameCount}");
// Console.WriteLine($"Удаление игры: {catalog.RemoveGame("SecondGame")}");
// Console.WriteLine($"Игр после удаления: {catalog.GameCount}");