using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using Telzir.DTO;
using Telzir_App;
using Telzir_crud.BLL;

namespace Telzir_Tel
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void textSenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void textEmail_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bntEntrar_Click_Click(object sender, EventArgs e)
        {
            // Instanciando obj DTO
            LoginDTO loginDTO = new LoginDTO();


            // Receber Dados do Formulario 
            loginDTO.Email = textEmail.Text;
            loginDTO.Senha = textSenha.Text;

            // Encaminhar Dados 
            LoginBLL loginBLL = new LoginBLL();

            var login = loginBLL.Login(loginDTO);

            if (!login)
            {
                Aplicacao App = new Aplicacao();
                this.Hide();
                App.ShowDialog();
                
            } 
            else
            {
                MessageBox.Show("Senha e/ou Login Incorretos");
            }

        }   
    }
}
