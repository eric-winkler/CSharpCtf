namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge9
    {
        internal Challenge9() { }

        public string Hint => $"Only thread {_initialThreadId} is denied access";

        private readonly int _initialThreadId = Environment.CurrentManagedThreadId;

        public bool TryUnlock(out Challenge10? nextChallenge)
        {
            nextChallenge = default;
            if (_initialThreadId != Environment.CurrentManagedThreadId)
            {
                nextChallenge = new Challenge10();
                return true;
            }

            return false;
        }
    }
}

