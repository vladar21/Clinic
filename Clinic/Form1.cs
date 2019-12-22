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
        Dictionary<Int32, String> listPatients;
        Dictionary<Int32, String> listDocs;

        public Form1()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            comboBoxChooseStatus.Items.Add("Patient");
            comboBoxChooseStatus.Items.Add("Doc");
            comboBoxChooseStatus.SelectedIndex = -1;
            comboBoxChooseIDpatients.SelectedIndex = -1;
            comboBoxChooseIDdocs.SelectedIndex = -1;
            comboBoxChooseIDpatients.Visible = false;
            comboBoxChooseIDdocs.Visible = false;

            listPatients = new Dictionary<int, string>();
            listDocs = new Dictionary<int, string>();

            LoadPatients();
            LoadDocs();
        }
        // задаем ширину выпадающего списка комбобокса
        int setWidth_comboBox(ComboBox cb)
        {
            int maxWidth = 0, temp = 0;
            foreach (var s in cb.Items)
            {
                temp = TextRenderer.MeasureText(s.ToString(), cb.Font).Width;
                if (temp > maxWidth)
                {
                    maxWidth = temp;
                }
            }
            return maxWidth;// + SystemInformation.VerticalScrollBarWidth;
        }
        // функция для загрузки данных из базы в список data
        private void LoadPatients()
        {           
            clinicEntities db = new clinicEntities();
            var pat = db.patients.ToList();
            foreach (var p in pat)
            {                    
                listPatients.Add(Convert.ToInt32(p.id), p.name);
            }          
        }

        // функция для загрузки данных из базы в список data
        private void LoadDocs()
        {  
            clinicEntities db = new clinicEntities();                
            var doc = db.docs.ToList();
            foreach (var d in doc)
            {                    
                listDocs.Add(Convert.ToInt32(d.id), d.name);
            }           
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseIDpatients.Text.Length == 0)
            {
                if (comboBoxChooseStatus.Text == "Patient")
                {
                    Form regfrm = new Registration(comboBoxChooseStatus.SelectedItem.ToString(), listDocs);
                    regfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    regfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                    regfrm.Show(); // отображаем Form2            
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                }
                if (comboBoxChooseStatus.Text == "Doc")
                {
                    Form regfrm = new Registration(comboBoxChooseStatus.SelectedItem.ToString(), listPatients);
                    regfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    regfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                    regfrm.Show(); // отображаем Form2            
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                }                

            }

        }

        private void btnApp_Click(object sender, EventArgs e)
        {
            if (comboBoxChooseStatus.Text.Length > 0 && (comboBoxChooseIDpatients.Text.Length > 0 ||
                comboBoxChooseIDdocs.Text.Length > 0))
            {
                switch (comboBoxChooseStatus.Text)
                {
                    case "Patient":
                        Form appfrm = new Appointment(Convert.ToInt32(comboBoxChooseIDpatients.SelectedValue), listDocs);
                        appfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                        appfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                        appfrm.Show(); // отображаем Form2
                        this.Hide(); // скрываем Form1 (this - текущая форма)
                        break;
                    case "Doc":
                        Form schfrm = new Schedule(Convert.ToInt32(comboBoxChooseIDdocs.SelectedValue), "Doc");
                        schfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                        schfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                        schfrm.Show(); // отображаем Form2
                        this.Hide(); // скрываем Form1 (this - текущая форма)
                        break;
                }
            }
            
        }

        public void fillComboboxID(string status)
        {
            
            switch (status)
            {
                case "Patient":                   
                    
                    comboBoxChooseIDdocs.Visible = false;
                    comboBoxChooseIDpatients.Visible = true;
                    comboBoxChooseIDpatients.DataSource = new BindingSource(listPatients, null);
                    comboBoxChooseIDpatients.DisplayMember = "Value";
                    comboBoxChooseIDpatients.ValueMember = "Key";
                    comboBoxChooseIDpatients.SelectedIndex = -1;
                    comboBoxChooseIDpatients.Width = setWidth_comboBox(comboBoxChooseIDpatients);
                    
                    break;
                case "Doc":
                                        
                    comboBoxChooseIDpatients.Visible = false;
                    comboBoxChooseIDdocs.Visible = true;
                    comboBoxChooseIDdocs.DataSource = new BindingSource(listDocs, null);
                    comboBoxChooseIDdocs.DisplayMember = "Value";
                    comboBoxChooseIDdocs.ValueMember = "Key";
                    comboBoxChooseIDdocs.SelectedIndex = -1;
                    comboBoxChooseIDdocs.Width = setWidth_comboBox(comboBoxChooseIDdocs);

                    break;
            }
        }

        private void comboBoxChooseStatus_SelectedIndexChanged(object sender, EventArgs e)
        {               
            ComboBox comboBox = (ComboBox)sender;
            string id = comboBox.SelectedItem.ToString();
            fillComboboxID(id);           
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form commfrm = new CommonSchedule();            
            commfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            commfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            commfrm.Show(); // отображаем Form2
            this.Hide(); // скрываем Form1 (this - текущая форма)
        }
    }
}
