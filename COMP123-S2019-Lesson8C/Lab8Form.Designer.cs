namespace COMP123_S2019_Lesson8C
{
    partial class Lab8Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lab8Form));
            this.Lab8Lable = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.AgeTextBox = new System.Windows.Forms.TextBox();
            this.AgeLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.OutputLabel = new System.Windows.Forms.Label();
            this.InfoGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lab8Lable
            // 
            resources.ApplyResources(this.Lab8Lable, "Lab8Lable");
            this.Lab8Lable.Name = "Lab8Lable";
            // 
            // NameLabel
            // 
            resources.ApplyResources(this.NameLabel, "NameLabel");
            this.NameLabel.Name = "NameLabel";
            // 
            // NameTextBox
            // 
            resources.ApplyResources(this.NameTextBox, "NameTextBox");
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // AgeTextBox
            // 
            resources.ApplyResources(this.AgeTextBox, "AgeTextBox");
            this.AgeTextBox.Name = "AgeTextBox";
            this.AgeTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AgeLabel
            // 
            resources.ApplyResources(this.AgeLabel, "AgeLabel");
            this.AgeLabel.Name = "AgeLabel";
            this.AgeLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // InfoGroupBox
            // 
            this.InfoGroupBox.BackColor = System.Drawing.Color.LightGray;
            this.InfoGroupBox.Controls.Add(this.NameLabel);
            this.InfoGroupBox.Controls.Add(this.AgeTextBox);
            this.InfoGroupBox.Controls.Add(this.NameTextBox);
            this.InfoGroupBox.Controls.Add(this.AgeLabel);
            resources.ApplyResources(this.InfoGroupBox, "InfoGroupBox");
            this.InfoGroupBox.Name = "InfoGroupBox";
            this.InfoGroupBox.TabStop = false;
            // 
            // SubmitButton
            // 
            resources.ApplyResources(this.SubmitButton, "SubmitButton");
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // OutputLabel
            // 
            resources.ApplyResources(this.OutputLabel, "OutputLabel");
            this.OutputLabel.Name = "OutputLabel";
            // 
            // Lab8Form
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.Controls.Add(this.OutputLabel);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.InfoGroupBox);
            this.Controls.Add(this.Lab8Lable);
            this.Name = "Lab8Form";
            this.Load += new System.EventHandler(this.Lab8Form_Load);
            this.InfoGroupBox.ResumeLayout(false);
            this.InfoGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lab8Lable;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox AgeTextBox;
        private System.Windows.Forms.Label AgeLabel;
        private System.Windows.Forms.GroupBox InfoGroupBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Label OutputLabel;
    }
}

