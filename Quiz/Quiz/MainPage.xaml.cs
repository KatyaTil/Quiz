using QuizData1;
using Xamarin.Forms;

namespace Quiz
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_start_Clicked(object sender, System.EventArgs e)
        {
            if (Game.Nickname == null)
                DisplayAlert("Ошибка", "Вы не ввели имя!", "ОК");

            else
            {
                Navigation.PushAsync(new GamePage());
                Game.Nickname = edtr_nickname.Text;
            }
        }

        private void edtr_nickname_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(edtr_nickname.Text))
                Game.Nickname = edtr_nickname.Text;
        }

        private void rbtn_difficultyLevel_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            switch (radioButton.Content)
            {
                case "Легкая":
                    Game.DifficultyLevel = DifficultyLevelType.Easy;
                    Question.AnswersCount = 2;
                    break;
                case "Средняя":
                    Game.DifficultyLevel = DifficultyLevelType.Normal;
                    Question.AnswersCount = 3;
                    break;
                case "Сложная":
                    Game.DifficultyLevel = DifficultyLevelType.Hard;
                    Question.AnswersCount = 4;
                    break;
            }
        }
    }
}
