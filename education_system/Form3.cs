using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace education_system
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form3_Load(object sender, EventArgs e)
        {
            tip_txt.Items.Add("学生姓名");
            tip_txt.Items.Add("学生学号");
            tip_txt.Items.Add("学生班级");
            //设置列数为六列
            dataGridView1.ColumnCount = 6;
            dataGridView1.Rows.Add();
            dataGridView1.Rows[0].Cells[0].Value = "序号";
            dataGridView1.Rows[0].Cells[1].Value = "姓名";
            dataGridView1.Rows[0].Cells[2].Value = "性别";
            dataGridView1.Rows[0].Cells[3].Value = "年龄";
            dataGridView1.Rows[0].Cells[4].Value = "学号";
            dataGridView1.Rows[0].Cells[5].Value = "班级";
        }

        /// <summary>
        /// 查询操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_search_Click(object sender, EventArgs e)
        {
            //创建父窗体对象
            Form1 fm1 = (Form1)this.Owner;
            //存放查到的学生序号
            List<int> list_search = new List<int>();
            //查询操作
            for (int i = 0; i < fm1.list_studeng.Count; i++)
            {
                if (tip_txt.Text == "学生姓名" && input_txt.Text == fm1.list_studeng[i].Name)
                {
                    list_search.Add(i);
                    continue;
                }
                if (tip_txt.Text == "学生学号" && input_txt.Text == fm1.list_studeng[i].ID)
                {
                    list_search.Add(i);
                    continue;
                }
                if (tip_txt.Text == "学生班级" && input_txt.Text == fm1.list_studeng[i].Class)
                {
                    list_search.Add(i);
                    continue;
                }
            }
            //初始化表格
            dataGridView1.Rows[0].Cells[0].Value = "序号";
            dataGridView1.Rows[0].Cells[1].Value = "姓名";
            dataGridView1.Rows[0].Cells[2].Value = "性别";
            dataGridView1.Rows[0].Cells[3].Value = "年龄";
            dataGridView1.Rows[0].Cells[4].Value = "学号";
            dataGridView1.Rows[0].Cells[5].Value = "班级";
            //处理查询结果
            if (list_search.Count == 0)
            {
                MessageBox.Show("查无此人");
                input_txt.Clear();
                input_txt.Focus();
                dataGridView1.RowCount = 1;
            }
            else//将查询信息进行展示
            {
                dataGridView1.RowCount = list_search.Count + 1;
                for (int i = 0; i < list_search.Count; i++)
                {
                    dataGridView1.Rows[i + 1].Cells[0].Value = (i + 1).ToString();
                    dataGridView1.Rows[i + 1].Cells[1].Value = fm1.list_studeng[list_search[i]].Name;
                    dataGridView1.Rows[i + 1].Cells[2].Value = fm1.list_studeng[list_search[i]].Gender;
                    dataGridView1.Rows[i + 1].Cells[3].Value = fm1.list_studeng[list_search[i]].Age.ToString();
                    dataGridView1.Rows[i + 1].Cells[4].Value = fm1.list_studeng[list_search[i]].ID;
                    dataGridView1.Rows[i + 1].Cells[5].Value = fm1.list_studeng[list_search[i]].Class;
                }//END FOR
            }//END ELSE
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
