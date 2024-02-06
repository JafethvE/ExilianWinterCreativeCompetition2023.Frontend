using System.Collections.Generic;
using System.Net.Http;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ExilianWinterCreativeCompetition2023.Frontend
{
    public partial class ExilianWinterCreativeCompetition2023Form : Form
    {
        private readonly RestController restController;

        private Animal selectedAnimal;

        private readonly Regex nameRegex;
        private readonly Regex descriptionRegex;

        public ExilianWinterCreativeCompetition2023Form()
        {
            InitializeComponent();
            restController = new RestController();
            nameRegex = new Regex("^[a-zA-Z0-9\\s]{1,255}$");
            descriptionRegex = new Regex("^[a-zA-Z0-9\\s.,:;']{1,255}$");
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
            if(selectedAnimal != null && InputIsValid())
            {
                HttpResponseMessage message = restController.DeleteAnimal(selectedAnimal).Result;
                MessageBox.Show(message.Content.ReadAsStringAsync().Result, message.StatusCode.ToString());
                RefreshList();
            }
        }

        private void SaveAsNewButton_Click(object sender, System.EventArgs e)
        {
            if (InputIsValid())
            {
                Animal animal = new Animal()
                {
                    Id = null,
                    Name = NameTextBox.Text,
                    Description = DescriptionTextBox.Text
                };
                HttpResponseMessage message = restController.SaveNewAnimal(animal).Result;
                MessageBox.Show(message.Content.ReadAsStringAsync().Result, message.StatusCode.ToString());
                RefreshList();
            }
        }

        private void UpdateButton_Click(object sender, System.EventArgs e)
        {
            if(selectedAnimal != null && InputIsValid())
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

        private void NameTextBox_Validating(object sender, System.EventArgs e)
        {
            if (NameIsValid())
            {
                errorProvider.SetError(NameTextBox, "");
            }
            else
            {
                if (NameTextBox.TextLength > 0)
                {
                    if (NameTextBox.TextLength <= 255)
                    {
                        errorProvider.SetError(NameTextBox, "Illegal characters in name");
                    }
                    else
                    {
                        errorProvider.SetError(NameTextBox, "Name cannot be longer than 255 characters");
                    }
                }
                else
                {
                    errorProvider.SetError(NameTextBox, "Name cannot be blank");
                }
            }
        }

        private void DescriptionTextBox_Validating(object sender, System.EventArgs e)
        {
            if(DescriptionIsValid())
            {
                errorProvider.SetError(DescriptionTextBox, "");
            }
            else
            {
                if (DescriptionTextBox.TextLength > 0)
                {
                    if (DescriptionTextBox.TextLength <= 255)
                    {
                        errorProvider.SetError(DescriptionTextBox, "Illegal characters in description");
                    }
                    else
                    {
                        errorProvider.SetError(DescriptionTextBox, "Description cannot be longer than 255 characters");
                    }
                }
                else
                {
                    errorProvider.SetError(DescriptionTextBox, "Description cannot be blank");
                }
            }
            
        }

        private bool InputIsValid()
        {
            return NameIsValid() && DescriptionIsValid();
        }

        private bool NameIsValid()
        {
            return nameRegex.IsMatch(NameTextBox.Text);
        }

        private bool DescriptionIsValid()
        {
            return descriptionRegex.IsMatch(DescriptionTextBox.Text);
        }
    }
}
