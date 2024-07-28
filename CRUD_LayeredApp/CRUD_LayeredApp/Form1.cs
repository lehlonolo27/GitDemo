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
using CRUD_LayeredApp.Presentation;

namespace CRUD_LayeredApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataHandler handler = new DataHandler();
        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text, 
                int.Parse(textBox4.Text), textBox5.Text, textBox6.Text);
            handler.register(student);
            MessageBox.Show("Student details inserted and saved to Database");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Student student = new Student(int.Parse(textBox1.Text), textBox2.Text, textBox3.Text,
                int.Parse(textBox4.Text), textBox5.Text, textBox6.Text);
            handler.update(student);
            MessageBox.Show("Student details updated and saved to Database");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DisplayStudents form = new DisplayStudents();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteStudent form = new DeleteStudent();
            form.Show();
        }
    }
}
