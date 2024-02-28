using UnityEngine;

namespace MyOOP
{
    public static class StaticGenericUtils
    {
        public static GameScore UpdateScore<T>(GameScore score, T updateSource) where T : Enemy
        {
            Debug.Log(GameScore.updateMessage);
            return new GameScore(score.Value + updateSource.Health);
        }

    }

    public class GameScore
    {
        public static readonly string updateMessage = "The score is updating!";
        public GameScore(long v)
        {
            Value = v;
        }

        public long Value { get; set; }
    }
}
