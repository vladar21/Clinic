using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Clinic
{
    public partial class CommonSchedule : Form
    {
        public CommonSchedule()
        {
            InitializeComponent();
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
                treeView1.Nodes.Clear();

                var appdocs = db.docs.OrderBy(x => x.name).ToList();
                var apptable = db.appointments.OrderBy(x => x.appday).ToList();
                var appdays = db.appointments.Select(x => x.appday).Distinct().ToList();
                appdays = appdays.OrderBy(y => y.Value).ToList();

                TreeNode root = new TreeNode("Schedule");
                root.Expand();
                TreeNode rootdocs = new TreeNode("By Docs");
                rootdocs.ExpandAll();
                root.Nodes.Add(rootdocs);                
                TreeNode rootdays = new TreeNode("By Days");
                rootdays.ExpandAll();
                root.Nodes.Add(rootdays);
                foreach (var doc in appdocs)
                {
                    TreeNode treedoc = new TreeNode(doc.name);
                    var tempdays = db.appointments.Where(x => x.doc_id == doc.id).Select(x => x.appday).Distinct().ToList();
                    tempdays = tempdays.OrderBy(x => x.Value).ToList();

                    foreach(var day in tempdays)
                    {
                        DateTime dt = (DateTime)day;
                        TreeNode treeday = new TreeNode(dt.ToString("d"));
                        treedoc.Nodes.Add(treeday);
                        var temppatients = db.appointments.Where(y => y.appday == day && y.doc_id == doc.id);
                        foreach(var patient in temppatients)
                        {
                            treeday.Nodes.Add(new TreeNode(patient.patients.name));
                        }
                    }
                    rootdocs.Nodes.Add(treedoc);
                }

                foreach (var day in appdays)
                {
                    DateTime dt = (DateTime)day;
                    TreeNode treeday = new TreeNode(dt.ToString("d"));   
                    
                    var tempdocs = db.appointments.Where(x => x.appday == day).Select(x => x.docs.name).Distinct().ToList();
                    tempdocs = tempdocs.OrderBy(x => x).ToList();

                    foreach (var doc in tempdocs)
                    {
                        TreeNode treedoc = new TreeNode(doc);
                        treeday.Nodes.Add(treedoc);
                        var temppatients = db.appointments.Where(y => y.appday == day && y.docs.name == doc);
                        foreach (var patient in temppatients)
                        {
                            treedoc.Nodes.Add(new TreeNode(patient.patients.name));
                        }
                    }
                    rootdays.Nodes.Add(treeday);
                }

                treeView1.Nodes.Add(root);
               
               
            }
        }
    }
}
