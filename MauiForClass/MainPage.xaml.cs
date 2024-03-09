using System.Xml.Schema;

namespace MauiForClass
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void Add_Button_Clicked(object sender, EventArgs e)
        {
           double X, Y, Z;

            double.TryParse(XX.Text, out X);
            double.TryParse(XX.Text, out Y);

            Z = X + Y;
            ZZ.Text = Z.ToString();


        }
    }

}
