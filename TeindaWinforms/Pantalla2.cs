using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeindaWinforms
{
    public partial class Pantalla2 : Form
    {
        string txt = "";
        public Pantalla2(string nombre)
        {
            InitializeComponent();
            txt = nombre;
        }

        private void Pantalla2_Load(object sender, EventArgs e)
        {
            label1.Text = txt;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.AppendAllText($"{DateTime.Now.ToString("yyyyMMdd")}.txt",
                $"{DateTime.Now.ToString("HH:mm:ss")} | Mensaje de error | otro dato | otro dato"
                +Environment.NewLine);
        }
    }
}
