using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCodeFirst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SchoolEntities db = new SchoolEntities();
            var student = new Student { StudentName = "Ahmet taş" };
            db.Students.Add(student);
            db.SaveChanges();
            MessageBox.Show("olduda bitti maşallah");
        }
    }
}
