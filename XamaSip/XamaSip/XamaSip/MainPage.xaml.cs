using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;


namespace XamaSip
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            HttpClient apiRequest = new HttpClient();
            apiRequest.BaseAddress = new Uri("http://sippay-api.netzkern.de/Products/");
            apiRequest.DefaultRequestHeaders.Clear();


            HttpResponseMessage responseMessage = apiRequest.GetAsync("GetAll").Result;



            string result = responseMessage.Content.ReadAsStringAsync().Result;

            List<Position> allPositions = JsonConvert.DeserializeObject<List<Position>>(result);



            label0.Text = allPositions[0].Name;
            label1.Text = allPositions[1].Name;
            label2.Text = allPositions[2].Name;
            label3.Text = allPositions[3].Name;

            //label0.Margin = new Thickness(50, 100, 0, 0);
            //label1.Margin = new Thickness(50, 80, 0, 0);
            //label2.Margin = new Thickness(0, 100, 50, 0);
            //label3.Margin = new Thickness(0, 80, 50, 0);
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            


        }
    }
}
