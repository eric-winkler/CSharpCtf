using CtfChallenge;


var challenge = new Challenge1();
challenge.TryUnlock("agentsmith", out var challenge2);

Console.Write(challenge2.Hint);