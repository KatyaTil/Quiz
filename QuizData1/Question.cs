using QuizData;
using System;

namespace QuizData1
{
    public class Question
    {
        public static Image Image { get; set; }

        public static AnswerOption[] Options { get; set; }

        public static Int32 AnswersCount { get; set; }

        public Question(Image image, AnswerOption[] answerOptions, Int32 answersCount)
        {
            Image = image;
            Options = answerOptions;
            AnswersCount = answersCount;
        }
    }
}
