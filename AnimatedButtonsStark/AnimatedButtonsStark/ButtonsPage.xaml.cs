using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace AnimatedButtonsStark
{
    public partial class ButtonsPage : ContentPage
    {
        public ButtonsPage()
        {
            InitializeComponent();
            SpinMe();
        }
        private Button MakeButton()
        {
            Button button = new Button
            {
                Text = "   St Pete .Net  ",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                Rotation = 0,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };
            return button;
        }


        private void SimpleButton()
        {
            Button button = MakeButton();

            this.Content = button;

        }







        private void SpinMe()
        {
            Button button = MakeButton();
            button.Clicked += async (object sender, EventArgs e) =>
            {
                await button.RotateTo(360, 1000);
                button.Rotation = 0;
            };
            this.Content = button;

        }









        private void RockMe()
        {
            Button button = MakeButton();
            button.Clicked += async (object sender, EventArgs e) =>
            {
                await button.RotateTo(90, 1000);
                await button.RotateTo(-90, 1000);
                await button.RotateTo(0, 1000);
            };
            this.Content = button;

        }










        private void RockMeGently()
        {
            Button button = MakeButton();
            button.Clicked += async (object sender, EventArgs e) =>
            {
                await button.RotateTo(90, 1000, Easing.SinInOut);
                await button.RotateTo(-90, 1000, Easing.SinInOut);
                await button.RotateTo(0, 1000, Easing.BounceIn);
            };
            this.Content = button;

        }











        private void RockMeGentlyWooHoo()
        {
            Button button = MakeButton();
            button.Clicked += async (object sender, EventArgs e) =>
            {
                button.Rotation = 0;
                button.RotateTo(360, 2000);
                await button.ScaleTo(5, 1000);
                await button.ScaleTo(1, 1000);
            };
            this.Content = button;

        }












        private void JiggleTheHandle()
        {
            Button button = MakeButton();
            button.Clicked += async (object sender, EventArgs e) =>
            {
                await button.RotateTo(15, 1000,
                    new Easing(t =>
                        Math.Sin(Math.PI * t) * Math.Sin(Math.PI * 20 * t)));
            };
            this.Content = button;

        }













        private void DieButtonDie()
        {
            Button button = MakeButton();
            button.Clicked += async (object sender, EventArgs e) =>
            {
                button.AnchorX = 0;
                button.AnchorY = 0;
                await button.RotateTo(90, 3000,
                    new Easing(t =>
                        1 - Math.Cos(10 * Math.PI * t) * Math.Exp(-5 * t)));
                await button.TranslateTo(0,
                    (this.Height - button.Height) / 2 - button.Width, 1000, Easing.BounceOut);
                button.AnchorX = 1;
                button.AnchorY = 0;
                button.TranslationX -= button.Width - button.Height;
                button.TranslationY += button.Width + button.Height;
                button.RotateYTo(360, 1000);
                await button.RotateTo(180, 1000, Easing.SpringIn);
                button.FadeTo(0, 4000);
                await button.TranslateTo(200, -Height, 5000, Easing.CubicIn);

            };
            this.Content = button;

        }
    }
}
