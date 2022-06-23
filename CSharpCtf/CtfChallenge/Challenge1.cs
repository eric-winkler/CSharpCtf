namespace CtfChallenge
{
    /// <summary>
    /// Check the hint
    /// </summary>
    public sealed class Challenge1 : IChallenge
    {
        public string Hint => "Who was quoted in the 17/06/2022 Friday puzzle?";

        public bool TryUnlock(object key, out IChallenge? nextChallenge)
        {
            nextChallenge = this;
            if (key is string keyString && keyString.ToLower().Replace(" ", "") == "agentsmith")
            {
                nextChallenge = new Challenge2();
                return true;
            }

            return false;
        }
    }

    /// <summary>
    /// Start at Challenge1
    /// </summary>
    public sealed class Challenge2 : IChallenge
    {
        internal Challenge2()
        {
        }

        public string Hint => "Can you reference this .exe as a class library in your own app?";

        public bool TryUnlock(object key, out IChallenge nextChallenge)
        {
            nextChallenge = new Challenge3();
            return true;
        }
    }

    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge3 : IChallenge
    {
        internal Challenge3()
        {
        }

        public bool IsUnlocked { get; set; }

        public string Hint => "Are there other interesting members on this type?";

        public bool TryUnlock(object key, out IChallenge? nextChallenge)
        {
            nextChallenge = this;
            if (IsUnlocked)
            {
                nextChallenge = new Challenge4();
                return true;
            }

            return false;
        }
    }

    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge4 : IChallenge
    {
        public sealed class Challenge4Key
        {
            public bool IsUnlocked { get; set; }
        }

        public string Hint => "Are there other interesting types on this type?";

        public bool TryUnlock(object key, out IChallenge? nextChallenge)
        {
            nextChallenge = this;
            if (key is Challenge4Key c4Key && c4Key.IsUnlocked)
            {
                nextChallenge = new Challenge5();
                return true;
            }

            return false;
        }
    }

    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge5 : IChallenge
    {
        public class Challenge5Key
        {
            public bool IsUnlocked { get; private set; }

            protected void Unlock()
            {
                IsUnlocked = true;
            }
        }

        public string Hint => "Polymorphic key injection";

        public bool TryUnlock(object key, out IChallenge? nextChallenge)
        {
            nextChallenge = this;
            if (key is Challenge5Key c5Key && c5Key.IsUnlocked)
            {
                nextChallenge = new Challenge6();
                return true;
            }

            return false;
        }
    }

    public sealed class Challenge6 : IChallenge
    {
        public string Hint => throw new NotImplementedException();

        public bool TryUnlock(object key, out IChallenge? nextChallenge)
        {
            throw new NotImplementedException();
        }
    }
}

