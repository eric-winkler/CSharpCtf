using CtfChallenge;

Console.WriteLine(@"
   ___  _  _       ___  _____  ___  ___ _           _ _                      
  / __\| || |_    / __\/__   \/ __\/ __\ |__   __ _| | | ___ _ __   __ _  ___
 / / |_  ..  _|  / /     / /\/ _\ / /  | '_ \ / _` | | |/ _ \ '_ \ / _` |/ _ \
/ /__|_      _| / /___  / / / /  / /___| | | | (_| | | |  __/ | | | (_| |  __/
\____/ |_||_|   \____/  \/  \/   \____/|_| |_|\__,_|_|_|\___|_| |_|\__, |\___|
                                                                   |___/          
Welcome, and enjoy! Your first challenge awaits below...
");

var challenge = new Challenge1();

do
{
    Console.WriteLine();
    Console.WriteLine(challenge.Hint);
    var input = Console.ReadLine();
    Thread.Sleep(1000);

    if (challenge.TryUnlock(input, out var nextChallenge))
    {
        Console.WriteLine("That worked!");
        Console.WriteLine("Your next hint: " + nextChallenge.Hint);
        Console.WriteLine("Press any key to exit...");
        break;
    }

    Console.WriteLine("Hmm, that didn't work, try again?");
} while (true);

