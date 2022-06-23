namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge7
    {
        internal Challenge7() { }

        public string Hint => "Reference equal, but not equal";

        public bool TryUnlock(object first, object second, out Challenge8? nextChallenge)
        {
            nextChallenge = default;

            if (ReferenceEquals(first, second) && !second.Equals(first))
            {
                nextChallenge = new Challenge8();
                return true;
            }

            return false;
        }
    }
}

