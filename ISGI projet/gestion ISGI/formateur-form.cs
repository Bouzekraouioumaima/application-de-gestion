using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestion_ISGI
{
    public partial class formateur_form : Form
    {
        public formateur_form()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formateur form = new formateur(txtnom.Text, txtprenom.Text, comboBox1.Text, int.Parse(txtabs.Text), int.Parse(txtanc.Text), double.Parse(txtsalaire.Text));
            dataGridView1.Rows.Add(form);
            txtabs.Clear();
            txtanc.Clear();
            txtnom.Clear();
            txtprenom.Clear();
            comboBox1.Items.Clear();
        }
        private void btnmod_Click(object sender, EventArgs e)
        {
            dataGridView1.CurrentRow.Cells[0].Value = txtnom.Text;
            dataGridView1.CurrentRow.Cells[1].Value = txtprenom.Text;
            dataGridView1.CurrentRow.Cells[2].Value = comboBox1.Text;
            dataGridView1.CurrentRow.Cells[3].Value = txtabs.Text;
            dataGridView1.CurrentRow.Cells[4].Value = txtanc.Text;
        }

        private void btnsup_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }
        }

        private void btntrier_Click(object sender, EventArgs e)
        {
            dataGridView1.Sort(Column5, ListSortDirection.Ascending);
        }

        private void btnvider_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void btnquit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
