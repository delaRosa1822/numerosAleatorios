using numerosAleatorios.dato;
using numerosAleatorios.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace numerosAleatorios
{
    public partial class Aleatorio : Form
    {
        private admnEmple adm = new admnEmple();    
        public Aleatorio()
        {
            InitializeComponent();

        }


        private void button1_Click(object sender, EventArgs e)
        {
            adm.addEmpleado();  
            List<empleado> mostrar = adm.showEmpleado();
            empleado emp= mostrar[0];    
            tb_Num.Text = emp.Numero.ToString();
            tb_Nombre.Text = emp.Nombre;
            dtp_Fecha.Value = emp.FechaN;
            if (emp.Sexo)
            {
                rb_hombre.Checked = true;  
            }
            else
            {
                rb_mujer.Checked = true;
            }
            cb_grupo.SelectedIndex = cb_grupo.Items.IndexOf(emp.Grupo.ToString()); 
            tb_sueldo.Text = emp.Salario.ToString();
            cb_seguro.Checked = emp.Seguro;




        }

        private void Aleatorio_Load(object sender, EventArgs e)
        {

        }
    }
}
