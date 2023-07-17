namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            buttonSobre = new Button();
            buttonSair = new Button();
            buttonPaises = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(799, 449);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // buttonSobre
            // 
            buttonSobre.BackColor = Color.FromArgb(255, 255, 128);
            buttonSobre.Cursor = Cursors.Hand;
            buttonSobre.FlatStyle = FlatStyle.Flat;
            buttonSobre.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSobre.ForeColor = Color.DodgerBlue;
            buttonSobre.Location = new Point(12, 12);
            buttonSobre.Name = "buttonSobre";
            buttonSobre.Size = new Size(120, 31);
            buttonSobre.TabIndex = 1;
            buttonSobre.Text = "Sobre Eurovisão";
            buttonSobre.UseVisualStyleBackColor = false;
            buttonSobre.Click += buttonSobre_Click;
            // 
            // buttonSair
            // 
            buttonSair.BackColor = Color.Fuchsia;
            buttonSair.Cursor = Cursors.Hand;
            buttonSair.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonSair.Location = new Point(668, 407);
            buttonSair.Name = "buttonSair";
            buttonSair.Size = new Size(120, 31);
            buttonSair.TabIndex = 2;
            buttonSair.Text = "Sair";
            buttonSair.UseVisualStyleBackColor = false;
            buttonSair.Click += buttonSair_Click;
            // 
            // buttonPaises
            // 
            buttonPaises.BackColor = Color.DodgerBlue;
            buttonPaises.Cursor = Cursors.Hand;
            buttonPaises.FlatStyle = FlatStyle.Flat;
            buttonPaises.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            buttonPaises.ForeColor = Color.Yellow;
            buttonPaises.Location = new Point(153, 12);
            buttonPaises.Name = "buttonPaises";
            buttonPaises.Size = new Size(120, 31);
            buttonPaises.TabIndex = 3;
            buttonPaises.Text = "Países";
            buttonPaises.UseVisualStyleBackColor = false;
            buttonPaises.Click += buttonPaises_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonPaises);
            Controls.Add(buttonSair);
            Controls.Add(buttonSobre);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button buttonSobre;
        private Button buttonSair;
        private Button buttonPaises;
    }
}