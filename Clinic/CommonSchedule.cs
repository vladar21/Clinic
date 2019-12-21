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
    public partial class CommonSchedule : Form
    {
        public CommonSchedule()
        {
            InitializeComponent();

            listView1.View = View.Details;

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

                var appdocs = db.docs.OrderBy(x => x.name).ToList();
                var apptable = db.appointments.OrderBy(x => x.appday).ToList();                

                listView1.Columns.Add("DocName");
                foreach (var t in apptable)
                {
                    DateTime dt = (DateTime)t.appday;
                    listView1.Columns.Add(dt.ToString("d"));
                }

                foreach (var d in appdocs)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = d.name;
                    var temp = db.appointments.Where(x => x.doc_id == d.id).ToList();
                    foreach(var t in temp)
                    {
                        lvi.SubItems.Add(t.patients.name.ToString());
                    }
                   
                    listView1.Items.Add(lvi);                    
                }
          

            }
        }
    }
}
