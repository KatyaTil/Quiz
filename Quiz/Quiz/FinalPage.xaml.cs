using QuizData1;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FinalPage : ContentPage
    {
        public FinalPage()
        {
            InitializeComponent();

            Points.Text += Game.Score.ToString() + " очков";
            Nickname.Text += Game.Nickname;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Process.GetCurrentProcess().CloseMainWindow();
        }
    }
}