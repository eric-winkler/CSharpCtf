namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge5
    {
        internal Challenge5() { }

        public class Key
        {
            public bool IsUnlocked { get; private set; }

            protected void Unlock()
            {
                IsUnlocked = true;
            }
        }

        public string Hint => "Polymorphic key injection";

        public bool TryUnlock(Key key, out Challenge6? nextChallenge)
        {
            nextChallenge = default;
            if (key.IsUnlocked)
            {
                nextChallenge = new Challenge6();
                return true;
            }

            return false;
        }
    }
}

