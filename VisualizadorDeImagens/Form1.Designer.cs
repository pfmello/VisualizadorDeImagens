
namespace VisualizadorDeImagens
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
            this.imagensListBox = new System.Windows.Forms.ListBox();
            this.favoritosListBox = new System.Windows.Forms.ListBox();
            this.adicionarButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imagensListBox
            // 
            this.imagensListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imagensListBox.FormattingEnabled = true;
            this.imagensListBox.ItemHeight = 20;
            this.imagensListBox.Location = new System.Drawing.Point(46, 34);
            this.imagensListBox.Name = "imagensListBox";
            this.imagensListBox.Size = new System.Drawing.Size(339, 144);
            this.imagensListBox.TabIndex = 0;
            this.imagensListBox.SelectedIndexChanged += new System.EventHandler(this.imagensListBox_SelectedIndexChanged);
            // 
            // favoritosListBox
            // 
            this.favoritosListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoritosListBox.FormattingEnabled = true;
            this.favoritosListBox.ItemHeight = 20;
            this.favoritosListBox.Location = new System.Drawing.Point(46, 219);
            this.favoritosListBox.Name = "favoritosListBox";
            this.favoritosListBox.Size = new System.Drawing.Size(339, 144);
            this.favoritosListBox.TabIndex = 1;
            this.favoritosListBox.SelectedIndexChanged += new System.EventHandler(this.favoritosListBox_SelectedIndexChanged);
            // 
            // adicionarButton
            // 
            this.adicionarButton.Location = new System.Drawing.Point(26, 183);
            this.adicionarButton.Name = "adicionarButton";
            this.adicionarButton.Size = new System.Drawing.Size(194, 29);
            this.adicionarButton.TabIndex = 2;
            this.adicionarButton.Text = "Adicionar aos favoritos";
            this.adicionarButton.UseVisualStyleBackColor = true;
            this.adicionarButton.Click += new System.EventHandler(this.adicionarButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(46, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(339, 139);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(226, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Remover dos favoritos";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 512);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.adicionarButton);
            this.Controls.Add(this.favoritosListBox);
            this.Controls.Add(this.imagensListBox);
            this.Name = "Form1";
            this.Text = "Visualizador de Imagens";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox imagensListBox;
        private System.Windows.Forms.ListBox favoritosListBox;
        private System.Windows.Forms.Button adicionarButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
    }
}

