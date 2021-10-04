using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inmobiliaria
{

    public partial class CalcularInmueble : Form
    {
        public CalcularInmueble()
        {
            InitializeComponent();

            label1.Text = " ";
        }

       private GroupBox gpTipoInmueble1;
       private RadioButton selectedrb;
       
       private Button getSelectedRB;

      
        Piso piso1;
        Local local1;
        int NroPiso;
        String direccion;
        Double superficie;
        
        int Opcion;
        bool salir = false;

        
        void getSelectedRB_Click(object sender, EventArgs e)
        {
            MessageBox.Show(selectedrb.Text);
        }
       
        private void CalcularInmueble_Load(object sender, EventArgs e)
        {

        }

        private void gpTipoInmueble_Enter(object sender, EventArgs e)
        {

        }

        private void rdPiso_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void rdLocal_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = sender as RadioButton;

            if (rb == null)
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                selectedrb = rb;
            }
        }

        private void textNroPiso_TextChanged(object sender, EventArgs e)
        {
            if (!(textNroPiso.Text.EsNumero() == true))
                MessageBox.Show("solo numeros en este text");

        }

        public static int NumeroPiso (int NroPiso)
        {
            return NroPiso;
        }

        private void textNroVentanas_TextChanged(object sender, EventArgs e)
        {
            if (!(textNroVentanas.Text.EsNumero() == true))
                MessageBox.Show("solo numeros en este text");

           // local1 = new Local();
           // local1.Local();

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

 
        }

        private void txtSuperficie_TextChanged(object sender, EventArgs e)
        {
            if (!(txtSuperficie.Text.EsNumero() == true))
                MessageBox.Show("solo numeros en este text");

        }

        private void txtAntiguedad_TextChanged(object sender, EventArgs e)
        {
            if (!(txtAntiguedad.Text.EsNumero() == true))
                MessageBox.Show("solo numeros en este text");
        }

        private void txtPrecioBase_TextChanged(object sender, EventArgs e)
        {
            if (!(txtPrecioBase.Text.EsNumero() == true))
                MessageBox.Show("solo numeros en este text");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            Inmueble oInmueble;
            
            int NumeroPiso = 0;
            int CantidadVentanas = 0;
            string Tipo = " "; 

            double Superficie = Convert.ToDouble(txtSuperficie.Text);
            string Direccion=txtDireccion.Text;
            double PrecioBase= Convert.ToDouble(txtPrecioBase.Text);
            int Antiguedad= Convert.ToInt32(txtAntiguedad.Text);


            if (rdPiso.Checked)
            {
                NumeroPiso = Convert.ToInt32(textNroPiso.Text);
                oInmueble = new Piso(NumeroPiso, Superficie, Direccion, PrecioBase, Antiguedad );
                Tipo = "Piso";

            }else
            {
                CantidadVentanas = Convert.ToInt32(textNroVentanas.Text);
                 oInmueble = new Local(CantidadVentanas, Superficie, Direccion, PrecioBase, Antiguedad);
                Tipo = "Local";
            }
           
            double PrecioFinal = oInmueble.CalculoPrecio();
            if (PrecioFinal > 0)
                label1.Text = "El Precio Final del " +Tipo+" es $ " + PrecioFinal;
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

            
        }
    }

    public static class StringHelper
    {
        public static bool EsNumero(this string str)
        {
            double _val;
            bool valor = double.TryParse(str, out _val);
            return valor;
        }
 
    }

}
