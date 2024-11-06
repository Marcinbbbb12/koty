namespace koty
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            string link = "https://cataas.com/cat/says/" + input.Text;
           
            kot.Source = link;
        }

        private void OnCounterClicked2(object sender, EventArgs e)
        {
            string link = "https://cataas.com/cat/gif";

            kot.Source = link;
        }
        private void OnCounterClicked3(object sender, EventArgs e)
        {
            string link = "https://cataas.com/cat/says/hello?fontSize=50&fontColor=red";

            kot.Source = link;
        }
        private void OnCounterClicked4(object sender, EventArgs e)
        {
            string link = "https://cataas.com/cat/gif/says/" + input.Text;

            kot.Source = link;
        }
    }

}
