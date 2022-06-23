namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge12
    {
        internal Challenge12() { }

        private readonly byte[] _key = System.Security.Cryptography.RandomNumberGenerator.GetBytes(16);

        public string Hint => "Time for a memory dump";

        public bool TryUnlock(byte[] key, Challenge13? nextChallenge)
        {
            nextChallenge = default;
            if (_key.SequenceEqual(key))
            {
                nextChallenge = new Challenge13();
                return true;
            }
            return false;
        }
    }
}

