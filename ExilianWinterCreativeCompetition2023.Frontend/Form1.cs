using System.Collections.Generic;
using System.Windows.Forms;

namespace ExilianWinterCreativeCompetition2023.Frontend
{
    public partial class Form1 : Form
    {
        RestController restController;

        public Form1()
        {
            InitializeComponent();
            restController = new RestController();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
            List<Animal> animals = restController.GetAllAnimals().Result;
            animalListBox.Items.AddRange(animals.ToArray());
        }

        private void animalListBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            
        }
    }
}
