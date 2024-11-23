using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PuntuApp
{
    public partial class MainPage : Form
    {
        private bool isClosing = false;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            if (isClosing) return;

            isClosing = true;

            switch (MessageBox.Show(this, "¿Seguro que quieres salir?", "Cerrando...", MessageBoxButtons.YesNo))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    e.Cancel = true;
                    isClosing = false;
                    break;
                default:
                    break;
            }
        }
    }
}
