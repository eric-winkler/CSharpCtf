using CtfChallenge;
using System.Collections.Concurrent;

var challenge = new Challenge1();
challenge.TryUnlock("agentsmith", out var challenge2);

Console.WriteLine(challenge2.Hint);
challenge2.TryUnlock(out var challenge3);

Console.WriteLine(challenge3.Hint);
challenge3.IsUnlocked = true;
challenge3.TryUnlock(out var challenge4);

Console.WriteLine(challenge4.Hint);
var key = new Challenge4.Key() { IsUnlocked = true };
challenge4.TryUnlock(key, out var challenge5);

Console.WriteLine(challenge5.Hint);
var c5Key = new C5Key();
challenge5.TryUnlock(c5Key, out var challenge6);

Console.WriteLine(challenge6.Hint);
challenge6.TryUnlock(k => k.Response = k.Secret, out var challenge7);

Console.WriteLine(challenge7.Hint);
var unequal = new Unequal();
challenge7.TryUnlock(unequal, unequal, out var challenge8);

Console.WriteLine(challenge8.Hint);
Challenge9 challenge9;
lock (challenge8.SyncRoot)
{
    var sum = challenge8.ABunchOfNumbers.Select(i => (long)i).Sum();
    challenge8.TryUnlock(sum, out challenge9);
}

Console.WriteLine(challenge9.Hint);
var challenge10 = await Task.Run(() =>
{
    challenge9.TryUnlock(out var nextChallenge);
    return nextChallenge;
});

Console.WriteLine(challenge10.Hint);
var threadSet = new ConcurrentDictionary<int,int>();
var unlockTasks = Enumerable.Range(0, 3).Select(i =>
    Task.Run(() =>
    {
        threadSet[Environment.CurrentManagedThreadId] = Environment.CurrentManagedThreadId;
        Thread.Sleep(500);  // almost certainly a better way with actual synchronisation constructs
        while (Environment.CurrentManagedThreadId != threadSet.Keys.Min())
        {
            Thread.Sleep(500);
        }
        Console.WriteLine("unlocking with " + Environment.CurrentManagedThreadId);
        challenge10.TryUnlock(out var nextChallenge);
        threadSet.TryRemove(Environment.CurrentManagedThreadId, out _);
        return nextChallenge;
    }))
    .ToArray();

var results = await Task.WhenAll(unlockTasks);
var challenge11 = results.Single(r => r != null);

Console.WriteLine(challenge11.Hint);
challenge11.TryUnlock("$TuG3R&VN5Kjw2%kZ4ALdkcJs", out var challenge12);

Console.WriteLine(challenge12.Hint);
Console.WriteLine("Enter key:");
var dumpedKey = Console.ReadLine();
challenge12.TryUnlock(dumpedKey, out var challenge13);

Console.WriteLine(challenge13.Hint);
var c13Key = new Challenge13.Key();
var unlock = c13Key.GetType().GetMethods(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance)
    .Single(m => m.Name == "Unlock");
unlock.Invoke(c13Key, new object[0]);

challenge13.TryUnlock(c13Key);
