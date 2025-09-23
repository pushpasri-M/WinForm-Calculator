using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Control : Form
    {
        public Control()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                MessageBox.Show("Are you sure to Close?");
                Application.Exit();
            }

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBox2.Checked)
            {
                this.BackColor = Color.LightGray;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult = colorDialog.ShowDialog();
            if (DialogResult == DialogResult.OK)
            {
                BackColor = colorDialog.Color;
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            progressBar1.Value += 10;
        }

        private void Control_Load(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            dataGridView1.Rows.Add("1", "Pushpasri", "220000");
            dataGridView1.Rows.Add("2", "Anusha", "250000");
            dataGridView1.Rows.Add("3", "Sowmya", "300000");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 0)
            {

                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(textBox1, "Please Enter Text");
                label1.Text = "Hello";
            }
        }

        

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
