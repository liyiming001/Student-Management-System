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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 登录状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form5_Load(object sender, EventArgs e)
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

        //存放查到的学生序号
        List<int> list_search = new List<int>();

        /// <summary>
        /// 查询功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_search_Click(object sender, EventArgs e)
        {
            //存放父窗体对象
            Form1 fm1 = (Form1)this.Owner;
            //查询前将之前的查询记录清除
            list_search.Clear();
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

        /// <summary>
        /// 将当前修改信息进行保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_xiugai_Click(object sender, EventArgs e)
        {
            if (list_search.Count == 0)
            {
                MessageBox.Show("当前无修改内容");
                return;
            }
            //判断修改内容是否有错
            for (int i = 0; i < list_search.Count; i++)
            {
                //判断性别是否出错
                if ((string)dataGridView1.Rows[i + 1].Cells[2].Value != "男" && (string)dataGridView1.Rows[i + 1].Cells[2].Value != "女")
                {
                    MessageBox.Show("第" + (i+1).ToString() + "个学生性别输入有误！修改失败");
                    return;
                }
                //判断年龄是否输入有误
                try
                {
                    int age = Convert.ToInt32(dataGridView1.Rows[i + 1].Cells[3].Value);
                    if (age < 0 || age > 150)
                    {
                        MessageBox.Show("第" + (i + 1).ToString() + "个学生年龄输入有误！修改失败");
                        return;
                    }
                }
                catch
                {
                    MessageBox.Show("第" + (i + 1).ToString() + "个学生年龄输入有误！修改失败");
                    return;
                }
            }
            //将修改内容进行保存
            Form1 fm1 = (Form1)this.Owner;
            //判断学号是否重复
            for (int i = 0; i < list_search.Count; i++)
            {
                for (int j = i + 1; j < list_search.Count; j++)
                {
                    if (dataGridView1.Rows[i + 1].Cells[4].Value == dataGridView1.Rows[j + 1].Cells[4].Value)
                    {
                        MessageBox.Show("第" + (i + 1).ToString() + "个学生学号输入有误！修改失败");
                        return;
                    }
                }
            }
            //保存
            for (int i = 0; i < list_search.Count; i++)
            {
                fm1.list_studeng[list_search[i]].Name = (string)dataGridView1.Rows[i + 1].Cells[1].Value;
                fm1.list_studeng[list_search[i]].Gender = (string)dataGridView1.Rows[i + 1].Cells[2].Value;
                fm1.list_studeng[list_search[i]].Age = Convert.ToInt32(dataGridView1.Rows[i + 1].Cells[3].Value);
                fm1.list_studeng[list_search[i]].ID = (string)dataGridView1.Rows[i + 1].Cells[4].Value;
                fm1.list_studeng[list_search[i]].Class = (string)dataGridView1.Rows[i + 1].Cells[5].Value;
            }
            MessageBox.Show("修改成功");
            //重新显示
            for (int i = 0; i < list_search.Count; i++)
            {
                dataGridView1.Rows[i + 1].Cells[0].Value = (i + 1).ToString();
                dataGridView1.Rows[i + 1].Cells[1].Value = fm1.list_studeng[list_search[i]].Name;
                dataGridView1.Rows[i + 1].Cells[2].Value = fm1.list_studeng[list_search[i]].Gender;
                dataGridView1.Rows[i + 1].Cells[3].Value = fm1.list_studeng[list_search[i]].Age.ToString();
                dataGridView1.Rows[i + 1].Cells[4].Value = fm1.list_studeng[list_search[i]].ID;
                dataGridView1.Rows[i + 1].Cells[5].Value = fm1.list_studeng[list_search[i]].Class;
            }//END FOR
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }
    }
}
