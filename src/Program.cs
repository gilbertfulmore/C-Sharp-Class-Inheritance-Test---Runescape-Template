// See https://aka.ms/new-console-template for more information
using Runecape.NPC;
using Runecape.Items;
using Runecape.Objects;
using Runecape.Player;
using Runecape.Skills;

Player[] players = createPlayers();
Mob[] mobs = createMobs();
Food[] foods = createFoods();

Console.WriteLine("-Players-");
foreach (Player player in players)
{
    Console.WriteLine(player.id + ": " + player.name + " - " + player.combatLevel);
}

Console.WriteLine("\n-Mobs-");
foreach (Mob mob in mobs)
{
    Console.WriteLine(mob.id + ": " + mob.name + " - (Lvl: " + mob.combatLevel + ") - \"" + mob.desc + "\"");
}

Console.WriteLine("\n-Foods-");
foreach (Food food in foods)
{
    Console.WriteLine(food.id + ": " + food.name + " - " + food.healAmount + " - " + "\"" + food.desc + "\"");
}


static Food[] createFoods()
{
    int iD = 0;

    Food[] foods = new Food[]
    {
        new Food(iD++, "Cooked Lobster", "This looks tricky to eat.", 12 ,28, 42)
    };

    return foods;
}

static Mob[] createMobs()
{
    int iD = 0;

    Mob[] mobs = new Mob[]
    {
        new Mob(iD++, "Duck", "A Rubber Ducky", false, 3, new int[] { 10, 1, 1, 1, 1, 1, 1 }),
        new Mob(iD++, "TZ-TokJad", "This is going to hurt...", false, 702, new int[] { 250, 640, 960, 480, 480, 960, 0 }),
        new Mob(iD++, "Kalphite Queen", "I don't think insect repellent will work...", false, 333, new int[] { 255, 300, 300, 300, 150, 1, 0 }),
        new Mob(iD++, "King Black Dragon", "One of the biggest, meanest dragons around.", false, 276, new int[] { 240, 240, 240, 240, 240, 1, 0 })
    };

    return mobs;
}

static Player[] createPlayers()
{
    int iD = 0;

    Player[] players = new Player[]
    {
        new Player(iD++, "Noober123", new int[] { 10,  1,  1,  1,  1,  1,  1 }),
        new Player(iD++, "Pkaer",     new int[] { 99, 99, 99, 99,  1,  1, 82 }),
        new Player(iD++, "Lobster",   new int[] { 93, 92, 95, 90, 72, 75, 71 }),
        new Player(iD++, "Zezima",    new int[] { 99, 99, 99, 99, 99, 99, 99 })
    };

    return players;
}