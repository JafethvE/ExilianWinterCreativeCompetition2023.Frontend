using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;

namespace ExilianWinterCreativeCompetition2023.Frontend
{
    public partial class ExilianWinterCreativeCompetition2023Form : Form
    {
        private readonly RestController restController;

        private Animal selectedAnimal;

        public ExilianWinterCreativeCompetition2023Form()
        {
            InitializeComponent();
            restController = new RestController();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            RefreshList();
        }

        private void RefreshList()
        {
            AnimalListBox.Items.Clear();
            AnimalListBox.ClearSelected();
            selectedAnimal = null;
            List<Animal> animals = restController.GetAllAnimals().Result;
            AnimalListBox.Items.AddRange(animals.ToArray());
            EmptyTextBoxes();
        }

        private void AnimalListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            selectedAnimal = (Animal)AnimalListBox.SelectedItem;
            if(selectedAnimal != null)
            {
                NameTextBox.Text = selectedAnimal.Name;
                DescriptionTextBox.Text = selectedAnimal.Description;
            }
            else
            {
                EmptyTextBoxes();
            }
           
        }

        private void DeleteButton_Click(object sender, System.EventArgs e)
        {
            if(selectedAnimal != null)
            {
                HttpResponseMessage message = restController.DeleteAnimal(selectedAnimal).Result;
                MessageBox.Show(message.Content.ReadAsStringAsync().Result, message.StatusCode.ToString());
                RefreshList();
            }
        }

        private void SaveAsNewButton_Click(object sender, System.EventArgs e)
        {
            Animal animal = new Animal() {
                Id = null,
                Name = NameTextBox.Text,
                Description = DescriptionTextBox.Text
            };
            HttpResponseMessage message = restController.SaveNewAnimal(animal).Result;
            MessageBox.Show(message.Content.ReadAsStringAsync().Result, message.StatusCode.ToString());
            RefreshList();
        }

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            if(selectedAnimal != null)
            {
                selectedAnimal.Name = NameTextBox.Text;
                selectedAnimal.Description = DescriptionTextBox.Text;
                HttpResponseMessage message = restController.UpdateAnimal(selectedAnimal).Result;
                MessageBox.Show(message.Content.ReadAsStringAsync().Result, message.StatusCode.ToString());
                RefreshList();
            }
            
        }

        private void EmptyTextBoxes()
        {
            NameTextBox.Text = string.Empty;
            DescriptionTextBox.Text = string.Empty;
        }
    }
}
