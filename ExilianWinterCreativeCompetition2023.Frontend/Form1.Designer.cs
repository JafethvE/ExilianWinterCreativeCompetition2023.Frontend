
namespace ExilianWinterCreativeCompetition2023.Frontend
{
    partial class ExilianWinterCreativeCompetition2023Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AnimalListBox = new System.Windows.Forms.ListBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SaveAsNewButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AnimalListBox
            // 
            this.AnimalListBox.FormattingEnabled = true;
            this.AnimalListBox.HorizontalScrollbar = true;
            this.AnimalListBox.Location = new System.Drawing.Point(12, 12);
            this.AnimalListBox.Name = "AnimalListBox";
            this.AnimalListBox.Size = new System.Drawing.Size(136, 160);
            this.AnimalListBox.TabIndex = 0;
            this.AnimalListBox.SelectedIndexChanged += new System.EventHandler(this.AnimalListBox_SelectedIndexChanged);
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(157, 12);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(258, 20);
            this.NameTextBox.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.Location = new System.Drawing.Point(157, 38);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.Size = new System.Drawing.Size(258, 105);
            this.DescriptionTextBox.TabIndex = 2;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(157, 149);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(82, 23);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // SaveAsNewButton
            // 
            this.SaveAsNewButton.Location = new System.Drawing.Point(245, 149);
            this.SaveAsNewButton.Name = "SaveAsNewButton";
            this.SaveAsNewButton.Size = new System.Drawing.Size(82, 23);
            this.SaveAsNewButton.TabIndex = 4;
            this.SaveAsNewButton.Text = "Save as new";
            this.SaveAsNewButton.UseVisualStyleBackColor = true;
            this.SaveAsNewButton.Click += new System.EventHandler(this.SaveAsNewButton_Click);
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(333, 149);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(82, 23);
            this.UpdateButton.TabIndex = 5;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // ExilianWinterCreativeCompetition2023Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 187);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.SaveAsNewButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DescriptionTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.AnimalListBox);
            this.Name = "ExilianWinterCreativeCompetition2023Form";
            this.Text = "Exilian Winter Creative Competition 2023";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox AnimalListBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button SaveAsNewButton;
        private System.Windows.Forms.Button UpdateButton;
    }
}

