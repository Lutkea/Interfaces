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
        Label lb_Dtnasc;
        Label lb_CPF;
        Label lb_Diasdev;
        TextBox txtNome;
        TextBox txDtnasc;
        TextBox txCPF;
        ComboBox cbDiasdev;
        CheckBox chbAtivo;    
        RadioButton rbMasc;
        RadioButton rbFemin;
        RadioButton rbOutro;
        Button btConfirma;
        Button btCancela;
        public Formulario(){
            label = new Label();
            label.Text = "Informações";
            label.Location = new Point(20,5);

            lblNome = new Label();
            lblNome.Text = "Insira seu nome";
            lblNome.Location = new Point(20,25);

            txtNome = new TextBox();
            txtNome.Text = "nome sobrenome";
            txtNome.Location = new Point(20,45);

            lb_Dtnasc = new Label();
            lb_Dtnasc.Text = "Data de Nascimento: ";
            lb_Dtnasc.AutoSize = true;
            lb_Dtnasc.Location = new Point(20, 65);

            lb_CPF = new Label();
            lb_CPF.Text = "CPF: ";
            lb_CPF.Location = new Point(20, 105);

            lb_Diasdev = new Label();
            lb_Diasdev.Text = "Dias de Devolução: ";
            lb_Diasdev.AutoSize = true;
            lb_Diasdev.Location = new Point(20, 145);

            txtNome = new TextBox();
            txtNome.Location = new Point(180, 20);
            txtNome.Size = new Size(100, 18);

            txDtnasc = new TextBox();
            txDtnasc.Location = new Point(180, 60);
            txDtnasc.Size = new Size(100, 18);

            txCPF = new TextBox();
            txCPF.Location = new Point(180, 100);
            txCPF.Size = new Size(100, 18);

            cbDiasdev = new ComboBox();
            cbDiasdev.Items.Add("5");
            cbDiasdev.Items.Add("10");
            cbDiasdev.Items.Add("15");
            cbDiasdev.Items.Add("20");
            cbDiasdev.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbDiasdev.Location = new Point(180, 140);
            cbDiasdev.Size = new Size(100, 18);

            chbAtivo = new CheckBox();
            chbAtivo.Location = new Point(180, 180);
            chbAtivo.Size = new Size(100, 18);
            chbAtivo.Text = "Ativo?";

            rbMasc = new RadioButton();
            rbMasc.Location = new Point(180, 220);
            rbMasc.Size = new Size(100,18);
            rbMasc.Text = "Masculino";

            rbFemin = new RadioButton();
            rbFemin.Location = new Point(180, 240);
            rbFemin.Size = new Size(100,18);
            rbFemin.Text = "Feminino";

            rbOutro = new RadioButton();
            rbOutro.Location = new Point(180, 260);
            rbOutro.Size = new Size(100,18);
            rbOutro.Text = "Outro";

            btConfirma = new Button();
            btConfirma.Text = "OK";
            btConfirma.Location = new Point(180, 290);
            btConfirma.Click += new EventHandler(this.btConfirmaClick);

            btCancela = new Button();
            btCancela.Text = "Cancelar";
            btCancela.Location = new Point(180, 320);
            btCancela.Click += new EventHandler(this.btCancelaClick);  

            this.Controls.Add(label);
            this.Controls.Add(lblNome);
            this.Controls.Add(lb_Dtnasc);
            this.Controls.Add(lb_CPF);
            this.Controls.Add(lb_Diasdev);
            this.Controls.Add(txtNome);
            this.Controls.Add(txDtnasc);
            this.Controls.Add(txCPF);
            this.Controls.Add(cbDiasdev);
            this.Controls.Add(chbAtivo);
            this.Controls.Add(rbMasc);
            this.Controls.Add(rbFemin);
            this.Controls.Add(rbOutro);
            this.Controls.Add(btConfirma);
            this.Controls.Add(btCancela);
            this.Text = "Programa ADS";
            this.Size = new Size (400, 400);
            
        }

        private void btConfirmaClick (object sender, EventArgs e){
            MessageBox.Show( 
               $"Nome: {txtNome.Text}\n" +
                $"Data Nasci: {txDtnasc.Text}\n" +
                $"C.P.F: {txCPF.Text}\n",
                "Cliente",
                MessageBoxButtons.OK
            );
        }
        private void btCancelaClick(object sender, EventArgs e){
            this.Close();
        }
    }
}