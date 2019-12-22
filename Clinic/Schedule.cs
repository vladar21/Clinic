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
    public partial class Schedule : Form
    {
        public int Id { set; get; }
        string Status { set; get; }

        public Schedule(int id, string status)
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.Manual;

            listView1.View = View.Details;

            Status = status;
            Id = id;
            textBoxID.Text = Id.ToString();
            textBoxID.Enabled = false;
            LoadData();
        }

        private void Schedule_FormClosed(object sender, FormClosedEventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form ifrm = Application.OpenForms[0];
            ifrm.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            ifrm.Show(); // отображаем Form1

        }

        private void LoadData()
        {
            using (clinicEntities db = new clinicEntities())
            {
                listView1.Clear();
                listView1.Columns.Add("YourName");
                ListViewItem lvi = new ListViewItem();

                if (Status == "Patient")
                {
                    label3.Text = "Your appointment list:";
                    var apptable = db.appointments.Where(x => x.patient_id == Id).ToList();               
               
                    lvi.Text = db.patients.Where(x => x.id == Id).FirstOrDefault().name;
                    foreach (var t in apptable)
                    {
                        DateTime dt = (DateTime)t.appday;
                        listView1.Columns.Add(dt.ToString("d"));
                        lvi.SubItems.Add(t.docs.name.ToString());
                    }
                }
                else if (Status == "Doc")
                {
                    label3.Text = "Your patient's list:";
                    var apptable = db.appointments.Where(x => x.doc_id == Id).ToList();

                    try
                    {
                        lvi.Text = db.docs.Where(x => x.id == Id).FirstOrDefault().name;

                        foreach (var t in apptable)
                        {
                            DateTime dt = (DateTime)t.appday;
                            listView1.Columns.Add(dt.ToString("d"));
                            lvi.SubItems.Add(t.patients.name.ToString());
                        }
                    }
                    catch { }                    
                }
                else
                {
                    // ошибка, запись в лог
                }    

                listView1.Items.Add(lvi);
            }
        }

        private void btnScheduleOk_Click(object sender, EventArgs e)
        {
            Form commschfrm = new CommonSchedule();
            commschfrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            commschfrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            commschfrm.Show(); // отображаем Form2
            this.Hide(); // скрываем Form1 (this - текущая форма)
        }
    }
}
