using QuizData;
using QuizData1.Data;
using System;
using System.Collections.Generic;
using System.Linq;

namespace test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<AnswerOption> newAnswerOptions = new List<AnswerOption>();
            List<AnswerOption> answerOptions = Options.Answers;
            Random randomOption = new Random();

            for (int i = 0; newAnswerOptions.Count != 4; i++)
            {
                Int32 newOption = randomOption.Next(1, answerOptions.ToArray().Length);
                if (!newAnswerOptions.Contains(answerOptions[newOption]))
                {
                    newAnswerOptions.Add(answerOptions[newOption]);
                    answerOptions.Remove(answerOptions[newOption]);
                }
            }

            foreach (AnswerOption answerOption in newAnswerOptions)
            {
                Console.WriteLine($"{answerOption.Text}");
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            foreach (AnswerOption answerOption in answerOptions)
            {
                Console.WriteLine($"{answerOption.Text}");
            }
            Console.ReadLine();
        }
    }
}

