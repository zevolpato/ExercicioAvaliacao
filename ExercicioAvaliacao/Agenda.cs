using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExercicioAvaliacao
{
    public partial class Agenda : Form
    {
        public Agenda()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {

            pegaData();

           

        }

        void pegaData()
        {
            DateTime data = dtpData.Value;
            string dataCurta = data.ToShortDateString();
            string[] vetData = dataCurta.Split('/');
            string dataNova = vetData[2] + "-" + vetData[1] + "-" + vetData[0];    
            
            MessageBox.Show(dataNova);
        }
    }
}
