using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Excel_test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.dataGridView1.ColumnCount = 4;
            int index = this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows[index].Cells[0].Value = "编号";
            this.dataGridView1.Rows[index].Cells[1].Value = "姓名";
            this.dataGridView1.Rows[index].Cells[2].Value = "性别";
            this.dataGridView1.Rows[index].Cells[3].Value = "年龄";
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
            this.dataGridView1.Rows.Add();
        }
    }
}
