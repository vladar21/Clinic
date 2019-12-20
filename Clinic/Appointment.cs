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
        int patientid { set; get; }
        int docid { set; get; }

        public Appointment(int id, Dictionary<Int32, String> listDocs)
        {
            InitializeComponent();

            patientid = id;
 
            textBoxYourID.Enabled = false;
            textBoxYourID.Text = id.ToString();

            comboBoxChooseDoc.DataSource = new BindingSource(listDocs, null);
            comboBoxChooseDoc.DisplayMember = "Value";
            comboBoxChooseDoc.ValueMember = "Key";
            comboBoxChooseDoc.SelectedIndex = -1;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            
            dateTimePicker1.MinDate = DateTime.Today;
            dateTimePicker1.MaxDate = dateTimePicker1.Value.AddMonths(1);
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

        private void btnAppointmentOk_Click(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value != null && comboBoxChooseDoc.Text.Length > 0)
            {
                using (clinicEntities db = new clinicEntities())
                {
                    //var dataset = entities.processlists
                    //.Where(x => x.environmentID == environmentid && x.ProcessName == processname && x.RemoteIP == remoteip && x.CommandLine == commandlinepart)
                    //.Select(x => new { x.ServerName, x.ProcessID, x.Username }).ToList();
                    dateTimePicker1.CustomFormat = "yyyy-mm-dd";
                    DateTime Date = dateTimePicker1.Value.Date;
                    var existdoc = db.appointments.Where(x => x.doc_id == docid && x.patient_id == patientid && x.appday == Date).FirstOrDefault();
                    //var existpat = db.existdoc.Where((x) => x.patient_id == patientid).FirstOrDefault();
                    //var extistdate = db.appointments.Where((x) => x.appday == dateTimePicker1.Value).FirstOrDefault();
                    if (existdoc == null)
                    {
                        appointments appo = new appointments();
                        appo.appday = dateTimePicker1.Value;
                        appo.doc_id = docid;
                        appo.patient_id = patientid;
                        db.appointments.Add(appo);
                        db.SaveChanges();
                    }
                    else { MessageBox.Show("You already made this entry."); }                    
                }
            }            
        }

        private void comboBoxChooseDoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox.SelectedItem.GetType().GetProperty("Value").GetValue(comboBox.SelectedItem,1)
            if (comboBoxChooseDoc.SelectedIndex == -1) docid = 0;
            else docid = ((KeyValuePair<int, string>)comboBoxChooseDoc.SelectedItem).Key;
        }
    }
}
