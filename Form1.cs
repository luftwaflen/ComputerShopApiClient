using System.IO;
using System.Net.Http.Headers;
using WinFormsApiClient.Models;

namespace WinFormsApiClient
{
    public partial class Form1 : Form
    {
        static HttpClient client = new HttpClient();
        private string _path = "http://localhost:5041/api/Components";
        private List<ComponentModel> _components = new List<ComponentModel>();
        private List<OrderModel> _orders = new List<OrderModel>();
        public Form1()
        {
            client.BaseAddress = new Uri("http://localhost:5041/api/Components");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void ViewData()
        {
            HttpResponseMessage response = await client.GetAsync("");
            if (response.IsSuccessStatusCode)
            {
                _components = await response.Content.ReadAsAsync<List<ComponentModel>>();
            }

            dataGridView1.DataSource = _components;
        }

        private async void button_GetAllComp_Click(object sender, EventArgs e)
        {
            ViewData();
        }

        private async void button_AddComp_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textBox1.Text);
            var name = textBox2.Text;
            var description = textBox3.Text;
            var coats = decimal.Parse(textBox5.Text);
            var imageUrl = textBox4.Text;
            var component = new ComponentModel
            {
                Id = id,
                Name = name,
                Description = description,
                Coast = coats,
                ImageUrl = imageUrl
            };

            HttpResponseMessage response = await client.PostAsJsonAsync(
        "", component);
            response.EnsureSuccessStatusCode();
            ViewData();
        }

        private async void button_UpdateComp_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textBox1.Text);
            var name = textBox2.Text;
            var description = textBox3.Text;
            var coats = decimal.Parse(textBox5.Text);
            var imageUrl = textBox4.Text;
            var component = new ComponentModel
            {
                Id = id,
                Name = name,
                Description = description,
                Coast = coats,
                ImageUrl = imageUrl
            };

            HttpResponseMessage response = await client.PutAsJsonAsync("", component);
            response.EnsureSuccessStatusCode();
            ViewData();
        }

        private async void button_DeleteComp_Click(object sender, EventArgs e)
        {
            var id = int.Parse(textBox1.Text);
            HttpResponseMessage response = await client.DeleteAsync($"/api/Components/{id}");
            response.EnsureSuccessStatusCode();
            ViewData();
        }
    }
}