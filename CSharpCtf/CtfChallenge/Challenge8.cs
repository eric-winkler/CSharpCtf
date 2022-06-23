namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge8
    {
        private bool _isUnlocked = false;
        private readonly Random _random = new();

        public string Hint => "Just gotta synchronise that other thread somehow...";
        public List<int> ABunchOfNumbers { get; } = new List<int>();
        public readonly object SyncRoot = new();

        internal Challenge8()
        {
            for(var i=0; i < 10_000_000; i++)
            {
                ABunchOfNumbers.Add(_random.Next(0, 10_000));
            }
            _ = Task.Run(() => ChaosAgent());
        }

        private void ChaosAgent()
        {
            while(!_isUnlocked)
            {
                lock (SyncRoot)
                {
                    ABunchOfNumbers.Add(_random.Next(0, 10_000));
                    ABunchOfNumbers.RemoveAt(0);
                }
            }
        }

        public bool TryUnlock(long numberSum, out Challenge9? nextChallenge)
        {
            nextChallenge = default;
            if (ABunchOfNumbers.Select(i => (long) i).Sum() == numberSum)
            {
                nextChallenge = new Challenge9();
                _isUnlocked = true;
                return true;
            }

            return false;
        }
    }
}

