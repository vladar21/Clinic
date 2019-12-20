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
        int Patient_id { set; get; }
        int Doc_id { set; get; }
        Dictionary<Int32, String> temp;

        public Registration(string Status, Dictionary<Int32, String> t)
        {
            InitializeComponent();

            temp = t;
            textBoxID.ReadOnly = true;
            textBoxID.Enabled = false;
            textBoxStatus.ReadOnly = true;
            textBoxStatus.Text = Status;

            btnRegistrationOk.Visible = false;
            label2.Visible = false;
            textBoxID.Visible = false;

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
            switch (textBoxStatus.Text)
            {
                case "Patient":
                    Form appfrm = new Appointment(Patient_id, temp);
                    appfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    appfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                    appfrm.Show(); // отображаем Form2
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                    break;
                case "Doc":
                    Form schfrm = new Schedule(Doc_id);
                    schfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    schfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                    schfrm.Show(); // отображаем Form2
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                    break;
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (textBoxName.Text.Length > 0)
            {
                using (clinicEntities db = new clinicEntities())
                {                    
                    switch (textBoxStatus.Text){

                        case "Patient":
                            var exist = db.patients.Where((x) => x.name == textBoxName.Text).FirstOrDefault();
                            if (exist == null)
                            {
                                patients p = new patients();
                                p.name = textBoxName.Text;
                                Patient_id = p.id;

                                if (AddPatient(p))
                                {
                                    textBoxID.Text = p.id.ToString();
                                    btnRegister.Visible = false;
                                    textBoxName.Enabled = false;
                                    textBoxID.Enabled = false;
                                    btnRegistrationOk.Visible = true;
                                    label2.Visible = true;
                                    textBoxID.Visible = true;
                                    label1.Text = "Registration success.";
                                    label1.BackColor = Color.GreenYellow;
                                    label4.Text = "Current status";
                                    label3.Text = "Your name";
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is already such a name in the database.");
                            }
                            break;

                        case "Doc":
                            var exist1 = db.docs.Where((x) => x.name == textBoxName.Text).FirstOrDefault();
                            if (exist1 == null)
                            {                            
                                docs d = new docs();
                                d.name = textBoxName.Text;
                                Doc_id = d.id;

                                if (AddDoc(d))
                                {
                                    textBoxID.Text = d.id.ToString();
                                    btnRegister.Visible = false;
                                    textBoxName.Enabled = false;
                                    textBoxID.Enabled = false;
                                    btnRegistrationOk.Visible = true;
                                    label2.Visible = true;
                                    textBoxID.Visible = true;
                                    label1.Text = "Registration success.";
                                    label1.BackColor = Color.GreenYellow;
                                    label4.Text = "Current status";
                                    label3.Text = "Your name";
                                }
                            }
                            else
                            {
                                MessageBox.Show("There is already such a name in the database.");
                            }
                            break;
                    }                    
                    
                }
            }
        }

        static bool AddPatient(patients p)
        {
            try
            {
                using (clinicEntities db = new clinicEntities())
                {                    
                    db.patients.Add(p);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                // логгируем ошибку, выдаем сообещине о неудачной попытке
                return false;
            }
        }

        static bool AddDoc(docs d)
        {
            try
            {
                using (clinicEntities db = new clinicEntities())
                {
                    db.docs.Add(d);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            {
                // логгируем ошибку, выдаем сообещине о неудачной попытке
                return false;
            }
        }
    }
}
