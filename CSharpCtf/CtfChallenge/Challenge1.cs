namespace CtfChallenge
{
    /// <summary>
    /// Check the hint
    /// </summary>
    public sealed class Challenge1
    {
        public string Hint => "Who was quoted in the 17/06/2022 Friday puzzle?";

        public bool TryUnlock(string key, out Challenge2? nextChallenge)
        {
            nextChallenge = default;
            if (key.ToLower().Replace(" ", "") == "agentsmith")
            {
                nextChallenge = new Challenge2();
                return true;
            }

            return false;
        }
    }
}

