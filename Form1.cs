using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr5_sveta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
                manufacturerBindingSource.DataSource = Program.db.Manufacturer.ToList();
                productBindingSource.DataSource = Program.db.Product.ToList();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
                if (dataGridView1[5, e.RowIndex].Value == null) return;
             
                bool isactive = (bool)dataGridView1[5, e.RowIndex].Value;
                if (isactive == false)
                { 
                    e.CellStyle.BackColor = Color.LightGray;
                }
        }

    }
}


