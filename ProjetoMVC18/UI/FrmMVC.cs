using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoMVC.BLL;
using ProjetoMVC.DAL;
using ProjetoMVC.DTO;



namespace ProjetoMVC18.UI
{
    public partial class FrmMVC : Form
    {
        public FrmMVC()
        {
            InitializeComponent();
        }

        private void btn_enviar_Click(object sender, EventArgs e)
        {

            try
            {
                // Instanciando o DTO do cliente para armazenar os dados da tela
                tblClienteDTO cliente = new tblClienteDTO();
                cliente.Cpf_cliente = txt_cpf.Text.Trim();
                cliente.Nome_cliente = txt_nome.Text.Trim();
                cliente.Nome_mae = txt_mae.Text.Trim();
                // Instanciando a BLL para pesquisa do email e senha do cliente no banco
                tblClienteBLL bllCliente = new tblClienteBLL();
                if (bllCliente.Autenticar(cliente.Cpf_cliente, cliente.Nome_cliente, cliente.Nome_mae))
                {
                    MessageBox.Show("Seja bemvindo ", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Cliente não Localizado", "Falhou!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message, "Erro!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }


    }
}
