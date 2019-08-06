using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CalcSample
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // コードでボタンを作ってみる
            Button b4 = new Button
            {
                Text = "4",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Button b5 = new Button
            {
                Text = "5",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            Button b6 = new Button
            {
                Text = "6",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            // レイアウトに配置
            middleLayout.Children.Add(b4);
            middleLayout.Children.Add(b5);
            middleLayout.Children.Add(b6);

            // イベントをつける
            b6.Clicked += async (sender, args) => await Navigation.PushAsync(new SecondPage());

        }

        async void OnButtonOneClicked(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new SecondPage());
        }
    }
}
