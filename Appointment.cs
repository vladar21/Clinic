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
    public partial class Appointment : Form
    {
        public Appointment(int id, Dictionary<Int32, String> listDocs)
        {
            InitializeComponent();
            
            //monthCalendar1.ShowTodayCircle = true;
            monthCalendar1.Enabled = false;

            textBoxYourID.Enabled = false;
            textBoxYourID.Text = id.ToString();

            comboBoxChooseDoc.DataSource = new BindingSource(listDocs, null);
            comboBoxChooseDoc.DisplayMember = "Value";
            comboBoxChooseDoc.ValueMember = "Key";
            comboBoxChooseDoc.SelectedIndex = -1;
        }

        private void Appointment_FormClosed(object sender, FormClosedEventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            ifrm.Show(); // отображаем Form1

        }

        private void comboBoxChooseDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            monthCalendar1.Enabled = true;

        }
    }
}
