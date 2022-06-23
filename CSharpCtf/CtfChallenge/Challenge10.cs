namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge10
    {
        internal Challenge10() { }

        public string Hint => "3 different threadIds, in ascending order";

        private int _lastThreadId = int.MaxValue;
        private int _counter;

        public bool TryUnlock(out Challenge11 nextChallenge)
        {
            if(Environment.CurrentManagedThreadId > _lastThreadId)
            {
                _counter++;
            }
            else
            {
                _counter = 1;
            }
            _lastThreadId = Environment.CurrentManagedThreadId;

            nextChallenge = default;
            if (_counter >= 3)
            {
                nextChallenge = new Challenge11();
                return true;
            }

            return false;
        }
    }
}

