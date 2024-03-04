using System.Globalization;
using System.Windows.Forms;

namespace DemoTranslate
{
    public partial class Form1 : Form
    {
        //***
        public Form1()
        {
            InitializeComponent();
            //triar idioma manualment
            //bool no_verificar = true;
            //combobox3.selectedindex=1;
            //no_verificar = false;
        }
        // 

        // if no_verificar == true; exit;
        private void catal�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ca-ES");
            // demo recurs addicional
            string prova = "missatge de prova";

            //Recarregar el formulari

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void angl�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            //Recarregar el formulari
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void japon�sToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ja");
            //Recarregar el formulari
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void originalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.CurrentCulture;
            //Recarregar el formulari
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void tibet�ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("bo");
            //Recarregar el formulari
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void ajudaToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}