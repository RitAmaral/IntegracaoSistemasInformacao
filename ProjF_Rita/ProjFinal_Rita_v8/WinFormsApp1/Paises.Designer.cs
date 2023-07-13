namespace WinFormsApp1
{
    partial class Paises
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Paises));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonSair = new Button();
            buttonVoltar = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Ink Free", 21.7499962F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.DodgerBlue;
            label1.Location = new Point(120, 69);
            label1.Name = "label1";
            label1.Size = new Size(545, 36);
            label1.TabIndex = 1;
            label1.Text = "Países Participantes na Eurovisão 2023";
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Fuchsia;
            buttonSair.Cursor = Cursors.Hand;
            buttonSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSair.Location = new Point(689, 403);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(99, 35);
            buttonSair.TabIndex = 2;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.DodgerBlue;
            buttonVoltar.Cursor = Cursors.Hand;
            buttonVoltar.FlatStyle = FlatStyle.Flat;
            buttonVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVoltar.ForeColor = Color.Yellow;
            buttonVoltar.Location = new Point(689, 12);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(99, 33);
            buttonVoltar.TabIndex = 3;
            buttonVoltar.Text = "Página Inicial";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // comboBox1
            // 
            comboBox1.BackColor = SystemColors.Window;
            comboBox1.Cursor = Cursors.Cross;
            comboBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox1.ForeColor = Color.DodgerBlue;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Finlândia", "Suécia", "Israel", "Chéquia", "Moldávia", "Noruega", "Suiça", "Croácia", "Portugal", "Sérvia", "Letónia", "Irlanda", "Países Baixos", "Azerbeijão", "Malta" });
            comboBox1.Location = new Point(0, 0);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 4;
            comboBox1.Text = "1ª Semifinal";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.BackColor = SystemColors.Window;
            comboBox2.Cursor = Cursors.Cross;
            comboBox2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            comboBox2.ForeColor = Color.DodgerBlue;
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Austrália", "Áustria", "Polónia", "Lituânia", "Eslovénia", "Arménia", "Chipre", "Bélgica", "Albânia", "Estónia", "Islândia", "Geórgia", "Grécia", "Dinamarca", "Roménia", "San Marino" });
            comboBox2.Location = new Point(136, 0);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 5;
            comboBox2.Text = "2ª Semifinal";
            // 
            // Paises
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(buttonVoltar);
            Controls.Add(buttonSair);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Paises";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Paises";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonSair;
        private Button buttonVoltar;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
    }
}