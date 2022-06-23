namespace CtfChallenge
{
    /// <summary>
    /// Make sure you've completed the earlier challenges first!
    /// </summary>
    public sealed class Challenge11
    {
        internal Challenge11() { }

        private readonly string _secret = "$TuG3R&VN5Kjw2%kZ4ALdkcJs";

        public string Hint => "Decompile to reveal the secrets";

        public bool TryUnlock(string key, out Challenge12? nextChallenge)
        {
            nextChallenge = default;
            if (key == _secret)
            {
                nextChallenge = new Challenge12();
                return true;
            }
            return false;
        }
    }
}

