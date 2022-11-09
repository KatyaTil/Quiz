using System;

namespace QuizData
{
    public class AnswerOption
    {
        public Int32 Id { get; set; }

        public String Text { get; set; }

        public AnswerOption (Int32 id, Int32 imageId, String text)
        {
            Id = id;
            Text = text;
        }
    }
}