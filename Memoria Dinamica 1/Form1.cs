using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Memoria_Dinamica_1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        Queue<string> cola = new Queue<string>();
        Stack<string> pila = new Stack<string>();
        ArrayList Lista = new ArrayList();
        int indexList = -1;
        private void btn_Click(object sender, EventArgs e)
        {
            if (txt.Text.Length>0)
            {
                cola.Enqueue(txt.Text);
                txt.Text = "";
            }
            else
            {
                txtMostrar.Text = "";
                while (cola.Count>0)
                {
                    txtMostrar.Text += cola.Dequeue();
                }
            }
        }
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Llama a tu función aquí
                btn_Click(sender, e);

                // Evita que se genere el carácter "Enter" en el TextBox
                e.SuppressKeyPress = true;
            }
        }

        private void btnPila_Click(object sender, EventArgs e)
        {
            if (txtPila.Text.Length > 0)
            {
                pila.Push(txtPila.Text);
                txtPila.Text = "";
            }
            else
            {
                txtMostrar.Text = "";
                while (pila.Count > 0)
                {
                    txtMostrar.Text += pila.Pop();
                }
            }
        }

        private void txtPila_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                    // Llama a tu función aquí
                    btnPila_Click(sender, e);

                    // Evita que se genere el carácter "Enter" en el TextBox
                    e.SuppressKeyPress = true;
                }
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            if (txtArray.Text.Length > 0)
            {

                Lista.Add(txtArray.Text);
                indexList += 1;
                txtArray.Text = "";
                txtConsult.Enabled = false;
            }
            else
            {
                txtMostrar.Text = "";
                MessageBox.Show("modo consulta, coloque la posicion en el textbox de abajo");
                txtConsult.Enabled = true;
            }
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = "";
            if (txtConsult.Text.Length < 1) { 
                MessageBox.Show("introduzca una posicion");
            }
            else
            {
                if (int.Parse(txtConsult.Text) > indexList) { MessageBox.Show("introdujo un valor mayor al numero de valores en la Lista");
                    txtMostrar.Text = "";
                }
                else
                {
                    txtMostrar.Text = Lista[int.Parse(txtConsult.Text)].ToString();
                }
            }
        }

        private void txtArray_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Enter)
                {
                // Llama a tu función aquí
                    btnArray_Click(sender, e);

                    // Evita que se genere el carácter "Enter" en el TextBox
                    e.SuppressKeyPress = true;
                }
        }
    }
}
