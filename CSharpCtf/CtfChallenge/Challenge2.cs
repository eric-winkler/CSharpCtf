namespace CtfChallenge
{
    /// <summary>
    /// Start at Challenge1
    /// </summary>
    public sealed class Challenge2
    {
        internal Challenge2() { }

        public string Hint => "Can you reference this .exe as a class library in your own app?";

        public bool TryUnlock(out Challenge3 nextChallenge)
        {
            nextChallenge = new Challenge3();
            return true;
        }
    }
}

