ChatRoom cr = new ChatRoom();

Task user1 = Task.Run(async () =>
{
    Random r = new Random();
    int randomWaitTime = 0;
    for(int i = 0; i < 10; i++){
        r.Next(100, 301);
        cr.AddMessage("user1", $"message:{i+1}");
        Console.WriteLine($"user1 completed writing message: {i+1}!");
        await Task.Delay(randomWaitTime);
    }
});
Task user2 = Task.Run(async () =>
{
    Random r = new Random();
    int randomWaitTime = 0;
    for (int i = 0; i < 10; i++)
    {
        r.Next(100, 301);
        cr.AddMessage("user2", $"message:{i + 1}");
        Console.WriteLine($"user2 completed writing message: {i + 1}!");
        await Task.Delay(randomWaitTime);
    }
});
Task user3 = Task.Run(async () =>
{
    Random r = new Random();
    int randomWaitTime = 0;
    for (int i = 0; i < 10; i++)
    {
        r.Next(100, 301);
        cr.AddMessage("user3", $"message:{i + 1}");
        Console.WriteLine($"user3 completed writing message: {i + 1}!");
        await Task.Delay(randomWaitTime);
    }
});
Task user4 = Task.Run(async () =>
{
    Random r = new Random();
    int randomWaitTime = 0;
    for (int i = 0; i < 10; i++)
    {
        r.Next(100, 301);
        cr.AddMessage("user4", $"message:{i + 1}");
        Console.WriteLine($"user4 completed writing message: {i + 1}!");
        await Task.Delay(randomWaitTime);
    }
});
Task user5 = Task.Run(async () =>
{
    Random r = new Random();
    int randomWaitTime = 0;
    for (int i = 0; i < 10; i++)
    {
        r.Next(100, 301);
        cr.AddMessage("user5", $"message:{i + 1}");
        Console.WriteLine($"user5 completed writing message: {i + 1}!");
        await Task.Delay(randomWaitTime);
    }
});

await Task.WhenAll(user1, user2, user3, user4, user5);
Console.WriteLine();
Console.WriteLine($"pocet vsech poslanych zprav: {cr.GetMessageCount()}");
Console.WriteLine();
Console.WriteLine($"pocet zprav od user1: {cr.GetMessagesFrom("user1").Count}");
Console.WriteLine($"pocet zprav od user2: {cr.GetMessagesFrom("user2").Count}");
Console.WriteLine($"pocet zprav od user3: {cr.GetMessagesFrom("user3").Count}");
Console.WriteLine($"pocet zprav od user4: {cr.GetMessagesFrom("user4").Count}");
Console.WriteLine($"pocet zprav od user5: {cr.GetMessagesFrom("user5").Count}");
Console.WriteLine();

foreach (var message in cr.GetMessagesFrom("user1"))
{
    Console.WriteLine($"zprava od user1: {message.text}");
}
