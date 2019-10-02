using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MH_TINHTONG
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public void cmdtinhtong_Clicked(object sender, EventArgs e)
        {
            double so1, so2, tong;
            so1 = double.Parse(txtsoa.Text);
            so2 = double.Parse(txtsob.Text);
            tong = so1 + so2;
            txttong.Text = tong.ToString();
        }

        private void cmdvetrangchu_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
