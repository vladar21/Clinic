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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
            comboBoxChooseStatus.Items.Add("Patient");
            comboBoxChooseStatus.Items.Add("Doc");
            comboBoxChooseStatus.SelectedIndex = 0;
        }

        private void Registration_FormClosed(object sender, FormClosedEventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            ifrm.Show(); // отображаем Form1

        }

        private void btnRegistrationOk_Click(object sender, EventArgs e)
        {            
            switch (comboBoxChooseStatus.SelectedIndex)
            {
                case 0:
                    Form appfrm = new Appointment();
                    appfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    appfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                    appfrm.Show(); // отображаем Form2
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                    break;
                case 1:
                    Form schfrm = new Schedule();
                    schfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    schfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                    schfrm.Show(); // отображаем Form2
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                    break;
            }
        }
    }
}
