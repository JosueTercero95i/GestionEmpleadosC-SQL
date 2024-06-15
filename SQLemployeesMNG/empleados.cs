using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQLemployeesMNG
{
    public partial class empleados : Form
    {
        public empleados()
        {
            InitializeComponent();
        }

        emp empl = new emp();
        cargos cargos = new cargos();
        genero gen = new genero();
        public void empleados_Load(object sender, EventArgs e)
        {
            dgvempleados.DataSource = empl.MostrarEmpleados();
            cbocategorias.DataSource = cargos.CargarCombo();
            cbocategorias.DisplayMember = "nombre_cargo";
          //cbocategorias.ValueMember = "id_cargo";
            cbogenero.DataSource = gen.Generos();
            cbogenero.DisplayMember = "gen";
        }

        private void cbocategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocategorias.SelectedIndex = -1;
        }

        private void cbogenero_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbocategorias.SelectedIndex = -1;
        }

        private void buttonINSERT_Click(object sender, EventArgs e)
        {
         
        }

    }
}
