
using Notifications.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Notifications
{
    public partial class MainPage : ContentPage
    {
        public Clock clock { get; set; }

        public MainPage()
        {
            InitializeComponent();
            btnNotification.Clicked += BtnNotification_Clicked;
        }
        void BtnNotification_Clicked(object sender, EventArgs e)
        {
            int tiempo = int.Parse(entry.Text);
            clock = new Clock(tiempo);
            BindingContext = clock;
        }
    }
}
