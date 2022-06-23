namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge6
    {
        internal Challenge6() { }

        public sealed class Key
        {
            internal Key() { }

            public Guid Secret { get; } = Guid.NewGuid();
            public Guid Response { get; set; }

            public bool IsUnlocked => Secret == Response;
        }

        public string Hint => "Action strategy injection";

        public bool TryUnlock(Action<Key> actionStrategy, out Challenge7? nextChallenge)
        {
            nextChallenge = default;
            var key = new Key();
            if (actionStrategy != null)
                actionStrategy(key);

            if (key.IsUnlocked)
            {
                nextChallenge = new Challenge7();
                return true;
            }

            return false;
        }
    }
}

