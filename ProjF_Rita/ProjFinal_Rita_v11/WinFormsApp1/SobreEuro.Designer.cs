namespace WinFormsApp1
{
    partial class SobreEuro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SobreEuro));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            buttonVoltar = new Button();
            buttonSair = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(802, 451);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.DeepSkyBlue;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(22, 30);
            label1.Name = "label1";
            label1.Size = new Size(363, 140);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            // 
            // buttonVoltar
            // 
            buttonVoltar.BackColor = Color.FromArgb(255, 255, 128);
            buttonVoltar.Cursor = Cursors.Hand;
            buttonVoltar.FlatStyle = FlatStyle.Flat;
            buttonVoltar.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonVoltar.ForeColor = Color.DodgerBlue;
            buttonVoltar.Location = new Point(677, 12);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(111, 31);
            buttonVoltar.TabIndex = 2;
            buttonVoltar.Text = "Página Inicial";
            buttonVoltar.UseVisualStyleBackColor = false;
            buttonVoltar.Click += buttonVoltar_Click;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Fuchsia;
            buttonSair.Cursor = Cursors.Hand;
            buttonSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSair.Location = new Point(677, 407);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(111, 31);
            buttonSair.TabIndex = 3;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // SobreEuro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonSair);
            Controls.Add(buttonVoltar);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "SobreEuro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SobreEuro";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button buttonVoltar;
        private Button buttonSair;
    }
}