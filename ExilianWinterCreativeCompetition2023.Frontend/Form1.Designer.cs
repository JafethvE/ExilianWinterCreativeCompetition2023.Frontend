
namespace ExilianWinterCreativeCompetition2023.Frontend
{
    partial class Form1
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
            this.animalListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // animalListBox
            // 
            this.animalListBox.FormattingEnabled = true;
            this.animalListBox.HorizontalScrollbar = true;
            this.animalListBox.Location = new System.Drawing.Point(12, 12);
            this.animalListBox.Name = "animalListBox";
            this.animalListBox.Size = new System.Drawing.Size(136, 680);
            this.animalListBox.TabIndex = 0;
            this.animalListBox.SelectedIndexChanged += new System.EventHandler(this.animalListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 702);
            this.Controls.Add(this.animalListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox animalListBox;
    }
}

