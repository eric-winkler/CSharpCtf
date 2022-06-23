namespace CtfChallenge
{
    public interface IChallenge
    {
        string Hint { get; }
        bool TryUnlock(object key, out IChallenge? nextChallenge);
    }
}
