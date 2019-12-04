using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaLujoso
{
    public partial class Form1 : Form
    {
        Semaphore s;
        Mutex m;
        [DllImport("user32")]
        public static extern int RegisterWindowMessage(string mensaje);
        [DllImport("user32")]
        public static extern int PostMessage(IntPtr dest, int IdMensaje, IntPtr wparam, IntPtr lparam);
        int idmensajecoje;
        int idmensajedeja;
        int idmensajeentra;
        int idmensajesale;
        IntPtr hand;
        public Form1()
        {
            InitializeComponent();

            s = new Semaphore(3, 3, "semaforotoallar");
            idmensajecoje = RegisterWindowMessage("WM_COJE");
            idmensajedeja = RegisterWindowMessage("WM_DEJA");
            idmensajeentra = RegisterWindowMessage("WM_ENTRA");
            idmensajesale = RegisterWindowMessage("WM_SALE");


        }

        private void BtnUsuario_Click(object sender, EventArgs e)
        {
            
            Process p = new Process();
            ProcessStartInfo psi = new ProcessStartInfo();
            psi.FileName="..\\..\\..\\Usuario\\bin\\Debug\\Usuario.exe";
            psi.UseShellExecute = true;
            p.StartInfo = psi;
            p.Start();
            txtNumUsu.Text = Cuentaprocesos().ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNumUsu.Text = Cuentaprocesos().ToString();
            InicializarListBox();
            
        }

        private void InicializarListBox()
        {
            for (int i = 0; i < 3; i++)
            {
                ListToallas.Items.Add("Toalla " + (i + 1).ToString());
            }
        }

        private int Cuentaprocesos()
        {            
            Process[] proc = Process.GetProcessesByName("Usuario");
            int num = proc.Length;
            return num;
        }
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == idmensajecoje)
            {
                //Cuando coje toalla
                ListToallas.Items.RemoveAt(ListToallas.Items.Count - 1);

            }
            else if (m.Msg == idmensajedeja)
            {
                //Cuando deja toalla
                ListToallas.Items.Add("Toalla " + (ListToallas.Items.Count + 1));
                Thread.Sleep(100);
                txtNumUsu.Text = Cuentaprocesos().ToString();
            }
            else if (m.Msg == idmensajeentra)
            {
                checkBoxDucha.Checked = true;
            }
            else if (m.Msg == idmensajesale)
            {
                checkBoxDucha.Checked = false;
            }
            else base.WndProc(ref m);
        }
    }
}
