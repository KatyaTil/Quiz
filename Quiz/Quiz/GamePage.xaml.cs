using QuizData1;
using QuizData1.Data;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GamePage : ContentPage
    {
        private String reply;
        private QuizData1.Image country;
        int countQuestions = 0;
        int points = 0;

        public GamePage()
        {
            InitializeComponent();
            GenerateAnswers(Question.AnswersCount);
        }

        private void GenerateAnswers(int count)
        {
            country = Service.RandomFlag();
            QuizData1.Image image = country;
            img_Flag.Source = image.Path;
            var answers = Service.RandomGenerate(count, image.Name);

            List<QuizData1.Image> images = ImageOptions.Images;
            images.Remove(country);
            
            foreach (var answ in answers)
            {
                Button countryButton = new Button { Text = answ.Text};
                countryButton.Background = Brush.Chocolate;
                countryButton.TextColor = Color.Beige;
                countryButton.Clicked += OnLanguageCheckedChanged;
                layout_countries.Children.Add(countryButton);
            }
            score.Text = $"Очки: {points}/{countQuestions}";
        }

        private void OnLanguageCheckedChanged(object sender, EventArgs e)
        {
            Button selectedButton = ((Button)sender);
            reply = selectedButton.Text;
            layout_countries.IsEnabled = false;

            if (reply == country.Name)
            {
                selectedButton.Background = Brush.Green;
                points++;
            }
            else
            {

             selectedButton.Background = Brush.Red;
            }
               
            next.IsEnabled = true;
            countQuestions++;
        }

        private void next_Clicked(object sender, EventArgs e)
        {
            if (countQuestions < 10)
            {
                reply = null;
                next.IsEnabled = false;
                layout_countries.IsEnabled = true;
                layout_countries.Children.Clear();
                GenerateAnswers(Question.AnswersCount);
            }
            else
            {
                Game.Score = points;
                Navigation.PushAsync(new FinalPage());
            }
        }
    }
}