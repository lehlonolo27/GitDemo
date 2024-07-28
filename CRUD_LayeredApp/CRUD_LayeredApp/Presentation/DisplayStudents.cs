using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CRUD_LayeredApp.DataLayer;
using CRUD_LayeredApp.LogicLayer;


namespace CRUD_LayeredApp.Presentation
{
    public partial class DisplayStudents : Form
    {
        public DisplayStudents()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();
        private void DisplayStudents_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.getStudent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataHandler handler = new DataHandler();
            Student student = new Student();
            student.StudentNumber = int.Parse(textBox1.Text);
            this.dataGridView1.DataSource = null;
            this.dataGridView1.Rows.Clear();
            dataGridView1.DataSource = handler.search(student.StudentNumber);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            Form1 form = new Form1();
            form.Show();
        }
    }
}
