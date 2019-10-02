using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MH_Chao
{
    
    public partial class MainPage : ContentPage
    {
              
            public MainPage()
            {
                InitializeComponent();
            }
            private void cmdchao_Clicked(object sender, EventArgs e)
            {
                string Hoten = txthoten.Text;
                DisplayAlert("Chào", "Chào bạn : " + Hoten, "Thoát");
            }

        }

}
