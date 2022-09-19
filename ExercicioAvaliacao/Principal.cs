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

        private void tarefasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Agenda agenda = new Agenda();
            agenda.MdiParent = this;
            agenda.Show();
        }

        private void contasAPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContasPagar contasPagar = new ContasPagar();
            contasPagar.MdiParent = this;
            contasPagar.Show();
        }

        private void contasAReceberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ContasReceber contasReceber = new ContasReceber();  
            contasReceber.MdiParent = this;    
            contasReceber.Show();
        }

        private void contasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ControleContas controleContas = new ControleContas();
            controleContas.MdiParent = this;
            controleContas.Show();
        }

        private void contatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Contatos contato = new Contatos();
            contato.MdiParent = this;
            contato.Show();
        }
    }
}
