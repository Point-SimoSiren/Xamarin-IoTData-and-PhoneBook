using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using OmaXamarin2021.Models;

namespace OmaXamarin2021
{
    public partial class IoTPage : ContentPage
    {
        public IoTPage()
        {
            InitializeComponent();
            LoadDataFromRestAPI();


            async void LoadDataFromRestAPI()
            {
                dataLista.ItemsSource = new List<string> { "Ladataan", "IoT dataa", "palvelimelta..." };
                HttpClient client = new HttpClient();
                client.BaseAddress = new Uri("https://timesheetrest.azurewebsites.net/");
                string json = await client.GetStringAsync("/api/measurements/");
                IEnumerable<RaakaData> raakaLista = JsonConvert.DeserializeObject<RaakaData[]>(json);

                List<String> stringList = new List<string>();

                foreach (var item in raakaLista)
                {
                    string merkkijono = item.time.ToString() + ": Temp: " + item.temperature.ToString() +
                  "C, Hum: " + item.humidity.ToString() + "%";
                  stringList.Add(merkkijono);
                }

                dataLista.ItemsSource = stringList;

            }
        }

        private async void latausNappi_Clicked(object sender, EventArgs e)
        {
            dataLista.ItemsSource = new List<string> { "Ladataan", "IoT dataa", "palvelimelta..." };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://timesheetrest.azurewebsites.net/");
            string json = await client.GetStringAsync("/api/measurements/");
            IEnumerable<RaakaData> raakaLista = JsonConvert.DeserializeObject<RaakaData[]>(json);


            List<String> stringList = new List<string>();

            foreach (var item in raakaLista)
            {
                string merkkijono = item.time.ToString() + ": Temp: " + item.temperature.ToString() +
                    "C, Hum: " + item.humidity.ToString() + "%";
                stringList.Add(merkkijono);
            }

            dataLista.ItemsSource = stringList;

        }

        private async void naviNappi_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MemoPage()); // Navigoidaan uudelle sivulle
        }
    }
}
