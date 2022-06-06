﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adressBook
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void peopleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.peopleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.database1DataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet.People' table. You can move, or remove it, as needed.
            this.peopleTableAdapter.Fill(this.database1DataSet.People);

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("addressBook v1.0\nAuthor: <Buzatu Elena-Luiza>", "About");
        }
    }
}
