namespace HerenciasEjercicios
{
    partial class MainForm
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
            DogNameLabel = new Label();
            DogNameTextBox = new TextBox();
            DogAgeTextBox = new TextBox();
            dogAgeLabel = new Label();
            DogEatingButton = new Button();
            BarkButton = new Button();
            CreateDogButton = new Button();
            labelResultado = new Label();
            SuspendLayout();
            // 
            // DogNameLabel
            // 
            DogNameLabel.AutoSize = true;
            DogNameLabel.Location = new Point(67, 22);
            DogNameLabel.Name = "DogNameLabel";
            DogNameLabel.Size = new Size(101, 15);
            DogNameLabel.TabIndex = 0;
            DogNameLabel.Text = "Nombre del Perro";
            // 
            // DogNameTextBox
            // 
            DogNameTextBox.Location = new Point(68, 40);
            DogNameTextBox.Multiline = true;
            DogNameTextBox.Name = "DogNameTextBox";
            DogNameTextBox.Size = new Size(193, 40);
            DogNameTextBox.TabIndex = 1;
            // 
            // DogAgeTextBox
            // 
            DogAgeTextBox.Location = new Point(69, 137);
            DogAgeTextBox.Multiline = true;
            DogAgeTextBox.Name = "DogAgeTextBox";
            DogAgeTextBox.Size = new Size(193, 40);
            DogAgeTextBox.TabIndex = 3;
            // 
            // dogAgeLabel
            // 
            dogAgeLabel.AutoSize = true;
            dogAgeLabel.Location = new Point(68, 119);
            dogAgeLabel.Name = "dogAgeLabel";
            dogAgeLabel.Size = new Size(83, 15);
            dogAgeLabel.TabIndex = 2;
            dogAgeLabel.Text = "Edad del Perro";
            // 
            // DogEatingButton
            // 
            DogEatingButton.Location = new Point(12, 193);
            DogEatingButton.Name = "DogEatingButton";
            DogEatingButton.Size = new Size(105, 44);
            DogEatingButton.TabIndex = 4;
            DogEatingButton.Text = "Comer";
            DogEatingButton.UseVisualStyleBackColor = true;
            DogEatingButton.Click += DogEatingButton_Click;
            // 
            // BarkButton
            // 
            BarkButton.Location = new Point(251, 193);
            BarkButton.Name = "BarkButton";
            BarkButton.Size = new Size(111, 44);
            BarkButton.TabIndex = 5;
            BarkButton.Text = "Ladrar";
            BarkButton.UseVisualStyleBackColor = true;
            BarkButton.Click += BarkButton_Click;
            // 
            // CreateDogButton
            // 
            CreateDogButton.Location = new Point(132, 193);
            CreateDogButton.Name = "CreateDogButton";
            CreateDogButton.Size = new Size(89, 44);
            CreateDogButton.TabIndex = 6;
            CreateDogButton.Text = "Crear Perro";
            CreateDogButton.UseVisualStyleBackColor = true;
            CreateDogButton.Click += CreateDogButton_Click;
            // 
            // labelResultado
            // 
            labelResultado.AutoSize = true;
            labelResultado.Location = new Point(12, 252);
            labelResultado.Name = "labelResultado";
            labelResultado.Size = new Size(0, 15);
            labelResultado.TabIndex = 7;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(labelResultado);
            Controls.Add(CreateDogButton);
            Controls.Add(BarkButton);
            Controls.Add(DogEatingButton);
            Controls.Add(DogAgeTextBox);
            Controls.Add(dogAgeLabel);
            Controls.Add(DogNameTextBox);
            Controls.Add(DogNameLabel);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DogNameLabel;
        private TextBox DogNameTextBox;
        private TextBox DogAgeTextBox;
        private Label dogAgeLabel;
        private Button DogEatingButton;
        private Button BarkButton;
        private Button CreateDogButton;
        private Label labelResultado;
    }
}