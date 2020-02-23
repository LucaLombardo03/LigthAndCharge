using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LigthAndCharge
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            InitSwitch();
        }
        
        void InitSwitch()
        {
            SwitchT.Toggled += SwitchT_Toggled;
        }
        
        private void SwitchT_Toggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert("Lampada", "Luce accesa: " + e.Value, "Ok");
        }
    }
}
