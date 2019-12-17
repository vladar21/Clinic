using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clinic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();            

        }
        
        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            Form authfrm = new Authorization();
            authfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            authfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            authfrm.Show(); // отображаем Form2
            this.Hide(); // скрываем Form1 (this - текущая форма)

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form regfrm = new Authorization();
            regfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            regfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            regfrm.Show(); // отображаем Form2
            this.Hide(); // скрываем Form1 (this - текущая форма)

        }
    }
}
