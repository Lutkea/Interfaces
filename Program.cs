using System;
using System.Windows.Forms;
using System.Drawing;

namespace aula
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Formulario());
        }
    }
    public class Formulario : Form {

        Label label;
        Label lblNome;
        Label lblEmail;
        Label lblSenha;
        Label lblConfSenha;
        TextBox txtNome;
        TextBox txtEmail;
        TextBox txtSenha;
        TextBox txtConfSenha;

        Button btConfirma;
        Button btCancela;
        public Formulario(){
            label = new Label();
            label.Text = "Crie sua conta";
            label.Location = new Point(100,5);

            lblNome = new Label();
            lblNome.Text = "Insira seu nome";
            lblNome.Location = new Point(20,22);

            txtNome = new TextBox();
            txtNome.Text = "nome sobrenome";
            txtNome.Location = new Point(20,47);

            lblEmail = new Label();
            lblEmail.Text = "Insira seu e-mail";
            lblEmail.Location = new Point(20,70);

            txtEmail = new TextBox();
            txtEmail.Text = "exemplo@dominio.com";
            txtEmail.Location = new Point(20,95);

            lblSenha = new Label();
            lblSenha.Text = "Crie uma senha";
            lblSenha.Location = new Point(20,120);

            txtSenha = new TextBox();
            txtSenha.Text = "******";
            txtSenha.Location = new Point(20,143);

            lblConfSenha = new Label();
            lblConfSenha.Text = "Confirme sua senha";
            lblConfSenha.Location = new Point(20,167);

            txtConfSenha = new TextBox();
            txtConfSenha.Text = "******";
            txtConfSenha.Location = new Point(20,190);

            btConfirma = new Button();
            btConfirma.Text = "OK";
            btConfirma.Location = new Point(75,250);
            btConfirma.Click += new EventHandler(this.btConfirmaClick);

            btCancela = new Button();
            btCancela.Text = "Cancelar";
            btCancela.Location = new Point(175,250);
            btCancela.Click += new EventHandler(this.btCancelaClick);  

            this.Controls.Add(label);
            this.Controls.Add(lblNome);
            this.Controls.Add(lblEmail);
            this.Controls.Add(lblSenha);
            this.Controls.Add(lblConfSenha);
            this.Controls.Add(txtNome);
            this.Controls.Add(txtEmail);
            this.Controls.Add(txtSenha);
            this.Controls.Add(txtConfSenha);
            this.Controls.Add(btConfirma);
            this.Controls.Add(btCancela);
            this.Text = "Programa ADS";
            
        }

        private void btConfirmaClick (object sender, EventArgs e){
            MessageBox.Show( 
                $"Nome.: {txtNome.Text}\n" +
                $"Email.: {txtEmail.Text}\n" +
                $"Senha.: {txtSenha.Text}\n" +
                $"Confirma Senha.: {txtConfSenha.Text}",
                "Cliente",
                MessageBoxButtons.OK
            );
        }
        private void btCancelaClick(object sender, EventArgs e){
            this.Close();
        }
    }
}