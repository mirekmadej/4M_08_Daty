

namespace _4M_08_Daty
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            var dzis = DateTime.Today;
            dateStart.MinimumDate = dzis;
            dateKoniec.MinimumDate = dzis.AddDays(1);
        }
        private void datePoczatekSelected(object sender, EventArgs e)
        {
            var dStart = dateStart.Date;
            dStart  = dStart.AddDays(1);
            dateKoniec.MinimumDate = dStart;
        }
        private void btnObliczClicked(object sender, EventArgs e)
        {
            var ile = (dateKoniec.Date - dateStart.Date);
            lblLiczbaDni.Text = ile.Days.ToString();
        }
    }
}