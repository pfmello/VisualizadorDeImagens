using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VisualizadorDeImagens
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] arquivos = Directory.GetFiles(@"c:\Windows\Web\Wallpaper", "*.jpg", SearchOption.AllDirectories);
            imagensListBox.Items.AddRange(arquivos);

            // Ler do arquivo favoritos ! (imagensConfig.txt)
            string caminho = ObterNomeArquivoConfiguracao();

            if (File.Exists(caminho))
            {
                var leitor = new StreamReader(caminho);

                while (!leitor.EndOfStream)
                {
                    string arquivo = leitor.ReadLine();
                    favoritosListBox.Items.Add(arquivo);
                }

                leitor.Close();
            }
        }

        private void imagensListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = imagensListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private string ObterNomeArquivoConfiguracao()
        {
            string pasta = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string arquivo = "imagensConfig.txt";
            string path = Path.Combine(pasta, arquivo);
            return path;
        }
        private void adicionarButton_Click(object sender, EventArgs e)
        {
            favoritosListBox.Items.Add(imagensListBox.Text);
            GravarConfiguracao();


        }
        private void GravarConfiguracao()
        {
            string caminho = ObterNomeArquivoConfiguracao();
            var escritor = new StreamWriter(caminho);
            foreach (string arquivo in favoritosListBox.Items)
            {
                escritor.WriteLine(arquivo);
            }

            escritor.Close();
        }

        private void favoritosListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = favoritosListBox.Text;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (favoritosListBox.SelectedItem != null)
            {
                string itemSelecionado = favoritosListBox.SelectedItem.ToString();
                favoritosListBox.Items.Remove(itemSelecionado);
                GravarConfiguracao();
            }
        }
    }
}
