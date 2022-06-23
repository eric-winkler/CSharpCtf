namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge13
    {
        internal Challenge13() { }

        public sealed class Key
        {
            public bool IsUnlocked { get; private set; }

            private void Unlock()
            {
                IsUnlocked = true;
            }
        }

        public string Hint => "Reflect on your work";

        public bool TryUnlock(Key key)
        {
            if (key.IsUnlocked)
            {
                Console.WriteLine("Winner winner chicken dinner");
                return true;
            }
            return false;
        }
    }
}

