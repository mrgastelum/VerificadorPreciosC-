using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace codigo_de_barras
{
    public partial class Form1 : Form
    {
        string Codigo = "";
        string Ruta = "C:\\Users\\PC.PC\\source\\repos\\codigo de barras\\image";
        string[,] Productos =
        {
            {"1", "Dulces Zanditas", "10 pesos", "1.png"},
            {"2", "Soda de toronja", "11 pesos", "2.png" },
            {"3", "Pan de Dulce", "12 pesos", "3.png"},
            {"4", "Sabritas blancas", "13 pesos", "4.png"},
            {"5", "Agua Epura", "14 pesos", "5.png"},
            {"6", "Dulces Gummy Pop", "15 pesos", "6.png"},
            {"7", "Soda de naranja", "16 pesos", "7.png"},
            {"8", "Pan dulce rojo", "17 pesos", "8.png"},
            {"9", "Sabritas rojas", "18 pesos", "9.png"},
            {"10", "Agua Bonafont", "19 pesos", "10.png"}
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Location = new Point(this.Width / 2 - label1.Width /2, 30);
            pictureBox1.Location = new Point(this.Width /2 - pictureBox1.Width /2, this.Height /2 - pictureBox1.Height /2);
            //label2.Location = new Point(this.Width /2 - label2.Width /2, this.Height - label2.Height);
            //label3.Location = new Point(this.Width /2 - label3.Width /2, this.Height - label3.Height);
            //label4.Location = new Point(this.Width / 2 - label4.Width / 2, this.Height - label4.Height);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 13)
            {
                Codigo += e.KeyChar;
            }
            else
            {
                MessageBox.Show("Codigo" + Codigo);
                
                for (int i = 0; i < 10; i++)
                {
                    if (Codigo == Productos [i, 0])
                    {
                        //MessageBox.Show("" + Productos[i, 1] + Productos[i, 2] + Productos[i, 3]);
                        label3.Text = "Nombre: " + Productos [i, 1];
                        label3.Visible = true;

                        label4.Text = "Precio: " + Productos[i, 2];
                        label4.Visible = true;

                        pictureBox1.Image = Image.FromFile(Ruta + @"\" + Productos[i, 3]);

                    }

                }
                Codigo = "";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
