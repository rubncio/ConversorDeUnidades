using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace CanoRuben_PR1x6
{
    public partial class Form1 : Form
    {
        public Boolean unidadesMedida = false;
        TextBox t1;
        KeyEventArgs a;
        

        public Form1()
        {
            InitializeComponent();
            PesoButton.BackColor = System.Drawing.Color.FromArgb(164, 237, 173);
            t1 = valorIzq;
            Desplegable_PesoIzq.SelectedIndex = 0;
            Desplegable_PesoDer.SelectedIndex = 1;
            Desplegable_MedidaIzq.SelectedIndex = 0;
            Desplegable_MedidaDer.SelectedIndex = 1;
            //TOOLTIPS
            //valores

            infoValores.ToolTipTitle = "Valor a convertir";
            infoValores.SetToolTip(valorIzq, "Introduzca el valor que desea convertir o que sea convertido");
            infoValores.SetToolTip(valorDer, "Introduzca el valor que desea convertir o que sea convertido");

            //Desplegables
            infoDesplegablesMedida.ToolTipTitle = "Unidad de Medida";
            infoDesplegablesMedida.SetToolTip(Desplegable_PesoIzq, "Seleccione una unidad de peso");
            infoDesplegablesMedida.SetToolTip(Desplegable_PesoDer, "Seleccione una unidad de peso");

            infoDesplegablesPeso.ToolTipTitle = "Unidad de Peso";
            infoDesplegablesPeso.SetToolTip(Desplegable_MedidaIzq, "Seleccione una unidad de Medida");
            infoDesplegablesPeso.SetToolTip(Desplegable_MedidaDer, "Seleccione una unidad de Medida");

            //botones
            infoBotones.ToolTipTitle = "Seleccion de Unidad";
            infoBotones.SetToolTip(PesoButton, "Haga clic para convertir unidades de Peso");
            infoBotones.SetToolTip(MedidaButton, "Haga clic para convertir unidades de Medida");
        }
        private void ConvertirMedidas(object sender, KeyEventArgs e)
        {
            double[] valoresAMultiplicarMetrico = { 0.001, 0.01, 0.1, 1, 10, 100, 1000, 0.0254, 0.3048, 0.9144, 1.83, 1609.344, 4828.03 };
            double[] valoresAMultiplicar;
            double[] valoresAMultiplicarPeso = { 0.001, 0.01, 0.1, 1, 10, 100, 1000, 100000, 1000000, 11339.80925, 0.0647989, 453.592, 28.3495, 11339.81, 6350.29 };
            t1 = (TextBox)sender;
            
            TextBox textBoxInsertar;
            double Unidad_Base;
            int indiceDesplegable;
            double convertido;
            int opcion;
            double valor;



            double.TryParse(t1.Text.ToString().Replace('.', ','), out valor);
            
                
            
            
            if (unidadesMedida)///////////Medidas//////////////
            {
                valoresAMultiplicar = valoresAMultiplicarMetrico;
                if (t1.Name.ToString().Equals("valorIzq"))//izquierda
                {
                    textBoxInsertar = valorDer;
                    indiceDesplegable = Desplegable_MedidaDer.SelectedIndex;
                    opcion = Desplegable_MedidaIzq.SelectedIndex;
                }
                else//derecha
                {
                    textBoxInsertar = valorIzq;
                    indiceDesplegable = Desplegable_MedidaIzq.SelectedIndex;
                    opcion = Desplegable_MedidaDer.SelectedIndex;
                }
            }
            else///////////////////Peso//////////////
            {
                valoresAMultiplicar = valoresAMultiplicarPeso;
                if (t1.Name.ToString().Equals("valorIzq"))//izquierda
                {
                    textBoxInsertar = valorDer;
                    indiceDesplegable = Desplegable_PesoDer.SelectedIndex;
                    opcion = Desplegable_PesoIzq.SelectedIndex;
                }
                else//derecha
                {
                    textBoxInsertar = valorIzq;
                    indiceDesplegable = Desplegable_PesoIzq.SelectedIndex;
                    opcion = Desplegable_PesoDer.SelectedIndex;
                }
            }
            if (indiceDesplegable != -1&& opcion != -1)
            {
                Unidad_Base = valor * valoresAMultiplicar[opcion];
                convertido = Unidad_Base / valoresAMultiplicar[indiceDesplegable];
                textBoxInsertar.Text = convertido.ToString();
            }
        }
        private void PesoButton_Click(object sender, EventArgs e)
        {
            PesoButton.BackColor = System.Drawing.Color.FromArgb(164, 237, 173);
            MedidaButton.BackColor = System.Drawing.Color.Transparent;
            unidadesMedida = false;
            Desplegable_MedidaIzq.Hide();
            Desplegable_MedidaDer.Hide();
            Desplegable_PesoIzq.Show();
            Desplegable_PesoDer.Show();
        }

        private void MedidaButton_Click(object sender, EventArgs e)
        {
            MedidaButton.BackColor = System.Drawing.Color.FromArgb(164, 237, 173);
            PesoButton.BackColor = System.Drawing.Color.Transparent;
            unidadesMedida = true;
            Desplegable_PesoIzq.Hide();
            Desplegable_PesoDer.Hide();
            Desplegable_MedidaIzq.Show();
            Desplegable_MedidaDer.Show();
        }

        //////////////////////FUNCION PARA ARRASTRAR////////////////
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Desplegable_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ConvertirMedidas(t1, a);

        }
        ///////////////////TOOLTIPS/////////////////////////////
        ///
        

        private void valorDer_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!valorDer.Text.ToString().Equals(""))
            {
                if (!double.TryParse(valorDer.Text.ToString(), out a))
                {
                    MessageBox.Show("Caracter Incorrecto, introduzca valores numericos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void valorIzq_TextChanged(object sender, EventArgs e)
        {
            double a;
            if (!valorIzq.Text.ToString().Equals(""))
            {
                if (!double.TryParse(valorIzq.Text.ToString(), out a))
                {
                    MessageBox.Show("Caracter Incorrecto, introduzca valores numericos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            
        }
    }
}
