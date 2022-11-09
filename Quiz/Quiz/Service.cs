using QuizData;
using QuizData1;
using QuizData1.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Quiz
{
    public static class Service
    {
        public static List<AnswerOption> RandomGenerate(Int32 countAnswers, String country)
        {
            List<AnswerOption> newAnswerOptions = new List<AnswerOption>();
            List<AnswerOption> answerOptions = Options.Answers;
            Random randomOption = new Random();

            for (Int32 i = 0; newAnswerOptions.Count != countAnswers; i++)
            {
                Int32 newOption = randomOption.Next(1, answerOptions.ToArray().Length);
                if (!newAnswerOptions.Contains(answerOptions[newOption]))
                {
                    newAnswerOptions.Add(answerOptions[newOption]);
                }
            }

            for (Int32 i = 0; newAnswerOptions.Count != countAnswers + 1; i++)
            {
                if (newAnswerOptions[i].Text != country)
                {
                    newAnswerOptions.Add(answerOptions.ToArray().Where(o => o.Text == country).First());
                }
                else
                {
                    if (!newAnswerOptions.Contains(answerOptions[i]))
                    {
                        newAnswerOptions.Add(answerOptions[i]);
                    }
                }
            }

             List<AnswerOption> shuffleOptions = newAnswerOptions.OrderBy(x => randomOption.Next()).ToList();

            return shuffleOptions;
        }

        public static Image RandomFlag()
        { 
            Random randomOption = new Random();
            List<Image> images = ImageOptions.Images;

            int option = randomOption.Next(1, images.ToArray().Length);

            return images[option];
        }
    }
}
