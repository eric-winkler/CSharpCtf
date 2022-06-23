namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge12
    {
        internal Challenge12() { }

        private readonly string _key = Convert.ToBase64String(System.Security.Cryptography.RandomNumberGenerator.GetBytes(16));

        public string Hint => "Time for a memory dump";

        public bool TryUnlock(string key, out Challenge13? nextChallenge)
        {
            nextChallenge = default;
            if (_key == key)
            {
                nextChallenge = new Challenge13();
                return true;
            }
            return false;
        }
    }
}

