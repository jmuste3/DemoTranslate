using System.Globalization;
using System.Windows.Forms;
using System.Resources;

namespace DemoTranslate
{
    public partial class Form1 : Form
    {

        //preparar recursos
        ResourceManager rm = new ResourceManager("DemoTranslate.Form1", typeof(Program).Assembly);
        

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
        private void catalàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("ca-ES");
            // demo recurs addicional
            string prova = "missatge de prova";

            //Recarregar el formulari

            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();

        }

        private void anglèsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("en-US");
            //Recarregar el formulari
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void japonèsToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void tibetàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("bo");
            //Recarregar el formulari
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //no utilitzar string si volem traduïr
            //MessageBox.Show("MISSATGE D'ERROR");

            //recuperar string traduit dels recursos
            string txtmsgbox = rm.GetString("titol_msgbox");
            MessageBox.Show(txtmsgbox);
        }
    }
}