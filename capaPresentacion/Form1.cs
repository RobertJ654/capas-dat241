using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using capaEntidad;
using capaFusion;

namespace capaPresentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        E_Estudiante entidad = new E_Estudiante();
        F_Estudiante fusion = new F_Estudiante();

        void listar_estudiantes()
        {
            DataTable dt = fusion.F_listado();
            dataGridView1.DataSource = dt;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listar_estudiantes();
        }
    }
}
