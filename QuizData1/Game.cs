using System;

namespace QuizData1
{
    public class Game
    {
        public static String Nickname { get; set; }

        public static Int32 Score { get; set; }

        public static DifficultyLevelType DifficultyLevel { get; set; }

        public Game(String nickname, Int32 score, DifficultyLevelType difficultyLevel)
        {
            Nickname = nickname;
            Score = score;
            DifficultyLevel = difficultyLevel;
        }
    }
}
