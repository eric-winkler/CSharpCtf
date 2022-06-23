namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge3
    {
        internal Challenge3() { }

        public bool IsUnlocked { get; set; }

        public string Hint => "Are there other interesting members on this type?";

        public bool TryUnlock(out Challenge4? nextChallenge)
        {
            nextChallenge = default;
            if (IsUnlocked)
            {
                nextChallenge = new Challenge4();
                return true;
            }

            return false;
        }
    }
}

