using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkingCalc
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

       
        void Handle_Clicked(object sender, System.EventArgs e)
        {
            double calculatedTip = 0;

            //var percentEntry = new Entry { Text = "Percent" };
            var percentVal = Convert.ToDouble(percent.Text);

            //var costEntry = new Entry { Text = "Meal Cost" };
            var costVal = Convert.ToDouble(cost.Text);

            calculatedTip = percentVal * costVal;
           
            ((Button)sender).Text = $"Your Tip Is {calculatedTip}";
        }
    }
}
