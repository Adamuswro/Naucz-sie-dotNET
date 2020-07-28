using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace _13_QUIZ
{
    //All classes should be placed in seperated files, but beacouse code is very simple it was decided to keep it in one file.
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                var gm = new QuizManager();
                gm.InitializeQuiz();

                Console.WriteLine("Press 'y' for repeat.");
            } while (Console.ReadLine() == "y");
        }
    }

    class DataSource
    {
        private string fileName = "dbQuestions.json";

        public List<Question> LoadQuestions()
        {
            var result = new List<Question>();
            using (StreamReader r = new StreamReader(fileName))
            {
                string json = r.ReadToEnd();
                result = JsonConvert.DeserializeObject<List<Question>>(json);
            }
            return result;
        }

        public void AddQuestion(Question question)
        {
            var initialJson = LoadQuestions();

            initialJson.Add(question);

            using (StreamWriter file = File.CreateText(fileName))
            {
                JsonSerializer serializer = new JsonSerializer();
                //serialize object directly into file stream
                serializer.Serialize(file, initialJson);
            }
        }
    }

    class Question
    {
        public string QuestionText { get; set; }
        public string FirstAnswer { get; set; }
        public string SecondAnswer { get; set; }
        public string ThirdAnswer { get; set; }
        public string FourthAnswer { get; set; }

        public int CorrectAnswer { get; set; }

        public override string ToString()
        {
            return $"{QuestionText}{Environment.NewLine}" +
                $"1. {FirstAnswer}{Environment.NewLine}" +
                $"2. {SecondAnswer}{Environment.NewLine}" +
                $"3. {ThirdAnswer}{Environment.NewLine}" +
                $"4. {FourthAnswer}";
        }
    }

    class QuizManager
    {
        private int roundsLeft = 4;
        private int goodAnswers = 0;
        private int wrongAnswers = 0;
        private Queue<Question> allQuestions;

        internal void InitializeQuiz()
        {
            LoadQuestionsFromDB();

            while (roundsLeft > 0)
            {
                if (AskQuestion() == true)
                {
                    goodAnswers++;
                }
                else
                {
                    wrongAnswers++;
                }

                roundsLeft--;
            }

            ShowScore();
        }

        private void LoadQuestionsFromDB()
        {
            var questionsDB = new DataSource().LoadQuestions();
            //Randomize order of the questions
            questionsDB.Shuffle();

            allQuestions = new Queue<Question>(questionsDB);
        }

        private bool AskQuestion()
        {
            var currentQuestion = allQuestions.Dequeue();
            Console.WriteLine($"{Environment.NewLine}{currentQuestion}");

            if (Console.ReadLine() == currentQuestion.CorrectAnswer.ToString())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void ShowScore()
        {
            Console.WriteLine($"Score: {goodAnswers}/{goodAnswers + wrongAnswers}");
        }

    }

    public static class HelperFunctions
    {
        private static Random rng = new Random();

        public static void Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }
    }
}
