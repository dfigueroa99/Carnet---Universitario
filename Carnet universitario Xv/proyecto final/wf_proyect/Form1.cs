using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wf_proyect
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            estudiante est1 = new estudiante();
            est1.nombre = "Diego";
            est1.Estado = "Activo";
            est1.blApellidoP = "Figueroa";
            est1.blApellidoM = "Hidalgo";
            est1.blnombre = "Diego Gonzalo";
            est1.blDNI = "73882045";
           



            estudiante est2 = new estudiante();
            est2.nombre = "Camilo";
            est2.Estado = "Inactivo";
            est2.blApellidoP = "Gutièrrez";
            est2.blApellidoM = "Mansilla"; 
            est2.blnombre = "Camilo Alfonso";
            est2.blDNI = "714578820";
            

            estudiante est3 = new estudiante();
            est3.nombre = "Eidson"; 
            est3.Estado = "Activo";
            est3.blApellidoP = "Siguas";
            est3.blApellidoM = "Morales";
            est3.blnombre = "Eidson Pedro";
            est3.blDNI = "79365545";
           

            estudiante est4 = new estudiante();
            est4.nombre = "Mario";
            est4.Estado = "Inactivo";
            est4.blApellidoP = "Alvarez";
            est4.blApellidoM = " Matinez ";
            est4.blnombre = "Mario Alexander";
            est4.blDNI = "72345667";
            

            List<estudiante> list1 = new List<estudiante>();
            list1.Add(est1);
            list1.Add(est2);
            list1.Add(est3);
            list1.Add(est4);

            cbxEstudiante.DataSource = list1;
            cbxEstudiante.DisplayMember = "nombre";


        }

        private void btnEstado_Click(object sender, EventArgs e)
        {

            string estudiante;
            estudiante = (cbxEstudiante.SelectedItem as estudiante).Estado;
            lblResultado.Text = estudiante;

        }

        private void cbxEstudiante_SelectedIndexChanged(object sender, EventArgs e)
        {
            string estu;
            estu = (cbxEstudiante.SelectedItem as estudiante).blApellidoP;
            lbl_ApellidoP.Text = estu;

            string nomb;
            nomb = (cbxEstudiante.SelectedItem as estudiante).blnombre;
            lbl_nombre.Text = nomb;

            string nacim;
            nacim = (cbxEstudiante.SelectedItem as estudiante).blDNI;
            lbl_DNi.Text = nacim;

            string val;
            val = (cbxEstudiante.SelectedItem as estudiante).blApellidoM;
            lbl_ApellidoM.Text = val;

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Estudio_TextChanged(object sender, EventArgs e)
        {

        }

        private void pkfoto_Click(object sender, EventArgs e)
        {

        }
    }
}
