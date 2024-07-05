using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PILAS_COLAS
{
    public partial class Form1 : Form
    {
        Stack<int> pila = new Stack<int>();
        Queue<string> pacientes = new Queue<string>();
        string concatenar = string.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lresultado.Text = string.Empty;
        }

        private void bagregar_Click(object sender, EventArgs e)
        {
            pila.Push(int.Parse(tnumeros.Text));
            lresultado.Text = tnumeros.Text + " - " + lresultado.Text;
        }

        private void beliminar_Click(object sender, EventArgs e)
        {

            if (pila.Count > 0)
            {
                pila.Pop();  // elminio un elemento de la pila

                concatenar = string.Empty;
                foreach (var numero in pila)  // recorro la pila
                {
                    concatenar = concatenar + " - " + numero.ToString();
                }

                lresultado.Text = concatenar;
            }
            else
            {
                MessageBox.Show("La pila esta vacia");
            }

        }

        private void bagregarcola_Click(object sender, EventArgs e)
        {
            pacientes.Enqueue(tcolas.Text);

            lcolas.Text = lcolas.Text + " - " + tcolas.Text;
            tcolas.Text = string.Empty;
        }

        private void beiminarcola_Click(object sender, EventArgs e)
        {
           

            if (pacientes.Count > 0)
            {
                pacientes.Dequeue();
                concatenar = string.Empty;
                foreach (var persona in pacientes)
                {
                    concatenar = concatenar + " - " + persona;
                }
                lcolas.Text = concatenar;
            } else {
                MessageBox.Show("La Cola esta vacia");
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show(pacientes.ElementAt(int.Parse(tcolas.Text)));

            //if (pacientes.Contains(tcolas.Text))
            //    MessageBox.Show("El paciente existe");
            // else
            //    MessageBox.Show("No existe");


           
        }
    }
}
