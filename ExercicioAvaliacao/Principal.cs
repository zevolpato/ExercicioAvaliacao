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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Agenda agenda = new Agenda();
            //agenda.MdiParent = this;
            //agenda.Show();
            
          Contatos contato = new Contatos();
            contato.MdiParent = this;
            contato.Show();

        }

      

        private void telefoneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Telefones telefones = new Telefones(); 
            telefones.MdiParent = this; 
            telefones.Show();
        }

        private void telefoneToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            PesquisaTelefones pesquisaTelefone = new PesquisaTelefones();
            pesquisaTelefone.MdiParent = this;
            pesquisaTelefone.Show();
        }

       
    }
}
