using CtfChallenge;


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
IChallenge challenge7;
lock (challenge6.SyncRoot)
{
    var sum = challenge6.ABunchOfNumbers.Select(i => (long) i).Sum();
    challenge6.TryUnlock(sum, out challenge7);
}

Console.WriteLine(challenge7.Hint);
var challenge8 = await Task.Run(() =>
{
    challenge7.TryUnlock(out var nextChallenge);
    return nextChallenge;
});

Console.WriteLine(challenge8.Hint);

Console.ReadLine();


//var unlockedKey = new UnlockedKey()
