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
        RichTextBox txtNome;
        NumericUpDown numDtNascDia;
        NumericUpDown numDtNascMes;
        NumericUpDown numDtNascAno;
        MaskedTextBox txCPF;
        ComboBox cbDiasdev;
        CheckBox chbAtivo;    
        RadioButton rbMasc;
        RadioButton rbFemin;
        RadioButton rbOutro;
        Button btConfirma;
        Button btCancela;
        PictureBox pbImagem;
        LinkLabel linkHelp;
    
        // ListBox listBox;
        ListView listView;

        //CheckedListBox checkedList;
        public Formulario(){

            // Label
            label = new Label();
            label.Text = "Informações";
            label.Location = new Point(20,5);

            lblNome = new Label();
            lblNome.Text = "Insira seu nome";
            lblNome.Location = new Point(20,25);

            // Rich Text Box
            txtNome = new RichTextBox();
            txtNome.SelectionFont = new Font("Arial", 10);
            txtNome.Location = new Point(180, 30);
            txtNome.Size = new Size(100, 20);

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

            // Numeric Up Down 
            numDtNascDia = new NumericUpDown();
            numDtNascDia.Location = new Point(180,60);
            numDtNascDia.Size = new Size (50, 65);
            numDtNascDia.Maximum = 31;
            numDtNascDia.Minimum = 1;
            numDtNascDia.Increment = 1;

            numDtNascMes = new NumericUpDown();
            numDtNascMes.Location = new Point(240,60);
            numDtNascMes.Size = new Size (50, 65);
            numDtNascMes.Maximum = 12;
            numDtNascMes.Minimum = 1;
            numDtNascMes.Increment = 1;

            numDtNascAno = new NumericUpDown();
            numDtNascAno.Location = new Point(300,60);
            numDtNascAno.Size = new Size (50, 75);
            numDtNascAno.Maximum = 2002;
            numDtNascAno.Minimum = 1950;
            numDtNascAno.Increment = 10;

            // Masked
            txCPF = new MaskedTextBox();
            txCPF.Location = new Point(180, 100);
            txCPF.Size = new Size(100, 18);
            txCPF.Mask = "000,000,000-00";

            // Combo Box
            cbDiasdev = new ComboBox();
            cbDiasdev.Items.Add("5");
            cbDiasdev.Items.Add("10");
            cbDiasdev.Items.Add("15");
            cbDiasdev.Items.Add("20");
            cbDiasdev.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbDiasdev.Location = new Point(180, 140);
            cbDiasdev.Size = new Size(100, 18);

            // Check Box
            chbAtivo = new CheckBox();
            chbAtivo.Location = new Point(180, 180);
            chbAtivo.Size = new Size(100, 18);
            chbAtivo.Text = "Ativo?";

            // Radio Button 
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
            btConfirma.Location = new Point(180, 320);
            btConfirma.Click += new EventHandler(this.btConfirmaClick);

            btCancela = new Button();
            btCancela.Text = "Cancelar";
            btCancela.Location = new Point(180, 350);
            btCancela.Click += new EventHandler(this.btCancelaClick);

            // Picture
            pbImagem = new PictureBox();
            pbImagem.Location = new Point (50, 320);    
            pbImagem.Size = new Size(100, 100);
            pbImagem.ClientSize = new Size (100 , 100);
            pbImagem.Load ("image.png");
            pbImagem.SizeMode = PictureBoxSizeMode.Zoom;

            // Link Label            
            linkHelp = new LinkLabel();
            linkHelp.Location = new Point(20, 280);
            linkHelp.Size = new Size (100, 30);
            linkHelp.Text = "Ajuda";
            linkHelp.LinkClicked += new LinkLabelLinkClickedEventHandler(this.helpLink);


            /*List Box
            listBox = new ListBox();
            listBox.Items.Add("Peixe Grande");
            listBox.Items.Add("Coringa");
            listBox.Items.Add("Star Wars");
            listBox.Location = new Point (15, 180);
            listBox.Size = new Size (100, 100);
            
            //listBox.SelectionMode = SelectionMode.MultiExtended;
            //listBox.EndUpdate()
            //lisBox.MultiColumn = true;
            
            */

            //List View
            listView = new ListView();
            listView.Location = new Point (15, 180);
            listView.Size = new Size (150, 100);
            listView.View = View.Details;
            ListViewItem filme1 = new ListViewItem("Peixe Grande");
            filme1.SubItems.Add("3");
            filme1.SubItems.Add("2004");
            ListViewItem filme2 = new ListViewItem("Coringa");
            filme2.SubItems.Add("2");
            filme2.SubItems.Add("2019");
            ListViewItem filme3 = new ListViewItem("Star Wars");
            filme3.SubItems.Add("1");
            filme3.SubItems.Add("1977");
            listView.Items.AddRange(new ListViewItem[]{filme1, filme2, filme3});
            listView.Columns.Add("Nome", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Estoque", -2, HorizontalAlignment.Left);
            listView.Columns.Add("Ano", -2, HorizontalAlignment.Left);
            listView.FullRowSelect = true;
            listView.GridLines = true;
            listView.AllowColumnReorder = true;
            listView.Sorting = SortOrder.Ascending;

            /*Check Box
            checkedList = new CheckedListBox();
            checkedList.Location = new Point(15, 180);
            checkedList.Size = new Size(150, 100);
            string[] filmes = {"Peixe Grande, Coringa, Star Wars"};
            checkedList.Items.AddRange(filmes);
            checkedList.SelectionMode = SelectionMode.One;
            checkedList.CheckOnClick = true;
            */


            this.Controls.Add(label);
            this.Controls.Add(lblNome);
            this.Controls.Add(lb_Dtnasc);
            this.Controls.Add(lb_CPF);
            this.Controls.Add(lb_Diasdev);
            this.Controls.Add(txtNome);
            this.Controls.Add(numDtNascDia);
            this.Controls.Add(numDtNascMes);
            this.Controls.Add(numDtNascAno);
            this.Controls.Add(txCPF);
            this.Controls.Add(cbDiasdev);
            this.Controls.Add(chbAtivo);
            this.Controls.Add(rbMasc);
            this.Controls.Add(rbFemin);
            this.Controls.Add(rbOutro);
            this.Controls.Add(btConfirma);
            this.Controls.Add(btCancela);
            this.Controls.Add(pbImagem);
            this.Controls.Add(linkHelp);
            // this.Controls.Add(listBox);
            this.Controls.Add(listView);
            //this.Controls.Add(checkedList);
            this.Text = "Programa ADS";
            this.Size = new Size (400, 450);
            
        }

        private void helpLink(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try{
                VisitLink();
            }
            catch (Exception err){
                MessageBox.Show(err.Message);
            }
        }
        private void VisitLink()
        {
            this.linkHelp.LinkVisited = true;
            System.Diagnostics.Process.Start("C:\\Program Files (x86)\\Google\\Chrome\\Application\\Chrome.exe","http://google.com");
        }

            private void btConfirmaClick (object sender, EventArgs e){
            MessageBox.Show( 
               $"Nome: {txtNome.Text}\n" +
                $"Data Nascimento: {numDtNascDia.Value + "/" + numDtNascMes.Value + "/" +  numDtNascAno.Value}\n" +
                $"C.P.F: {txCPF.Text}\n" +
                $"Dias Devolução:> {cbDiasdev.Text}\n",
                "Cliente",
                MessageBoxButtons.OK
            );
        }
        private void btCancelaClick(object sender, EventArgs e){
            this.Close();
        }
    }
}