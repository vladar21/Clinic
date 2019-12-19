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
        // список для хранения данных из базы
        List<string[]> listPatients;
        List<string[]> listDocs;

        public Form1()
        {
            InitializeComponent();
            comboBoxChooseStatus.Items.Add("Patient");
            comboBoxChooseStatus.Items.Add("Doc");
            comboBoxChooseStatus.SelectedIndex = -1;
            comboBoxChooseID.SelectedIndex = -1;

            listPatients = new List<string[]>();
            listDocs = new List<string[]>();
        }

        // асинхронная функция для загрузки данных из базы в список data
        private async Task LoadPatients()
        {            
            await Task.Run(() =>
            {
                clinicEntities db = new clinicEntities();
                var pat = db.patients.ToList();
                foreach (var p in pat)
                {
                    listPatients.Add(new string[2]);
                    listPatients[listPatients.Count - 1][0] = p.id.ToString();
                    listPatients[listPatients.Count - 1][1] = p.name.ToString();
                }
            });
        }

        // асинхронная функция для загрузки данных из базы в список data
        private async Task LoadDocs()
        {            
            await Task.Run(() =>
            {
                clinicEntities db = new clinicEntities();
                
                var doc = db.docs.ToList();
                foreach (var d in doc)
                {
                    listDocs.Add(new string[2]);
                    listDocs[listDocs.Count - 1][0] = d.id.ToString();
                    listDocs[listDocs.Count - 1][1] = d.name.ToString();
                }
            });
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseStatus.SelectedText.Length > 0 || comboBoxChooseID.SelectedText.Length == 0)
            {
                Form regfrm = new Registration(comboBoxChooseStatus.SelectedItem.ToString());
                regfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                regfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                regfrm.Show(); // отображаем Form2            
                this.Hide(); // скрываем Form1 (this - текущая форма)

            }

        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseStatus.SelectedText.Length > 0 && comboBoxChooseID.SelectedText.Length == 0)
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

        public async void fillComboboxID(string status)
        {
            comboBoxChooseID.Items.Clear();
            switch (status)
            {
                case "Patient":
                    listPatients.Clear();
                    await LoadPatients();                    
                    foreach(var l in listPatients)
                    {
                        comboBoxChooseID.Items.Add(l[1].ToString());
                    }
                    break;
                case "Doc":
                    listDocs.Clear();
                    await LoadDocs();                    
                    foreach (var l in listDocs)
                    {
                        comboBoxChooseID.Items.Add(l[1].ToString());
                    }
                    break;
            }
        }

        private void comboBoxChooseStatus_SelectedIndexChanged(object sender, EventArgs e)
        {               
            ComboBox comboBox = (ComboBox)sender;
            string id = comboBox.SelectedItem.ToString();
            fillComboboxID(id);           
            
        }

        private void comboBoxChooseStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
