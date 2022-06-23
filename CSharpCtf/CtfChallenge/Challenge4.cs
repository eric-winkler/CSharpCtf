namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge4
    {
        internal Challenge4() { }

        public sealed class Key
        {
            public bool IsUnlocked { get; set; }
        }

        public string Hint => "Are there other interesting types on this type?";

        public bool TryUnlock(Key key, out Challenge5? nextChallenge)
        {
            nextChallenge = default;
            if (key.IsUnlocked)
            {
                nextChallenge = new Challenge5();
                return true;
            }

            return false;
        }
    }
}

