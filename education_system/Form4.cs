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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 界面初始化
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form4_Load(object sender, EventArgs e)
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
        /// 查询操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_search_Click(object sender, EventArgs e)
        {
            //创建父窗体对象
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
        /// 删除选定行的学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_del_Click(object sender, EventArgs e)
        {
            //创建父窗体对象
            Form1 fm1 = (Form1)this.Owner;
            //获取当前选定的行
            int count = dataGridView1.CurrentRow.Index;
            if (count < 1 || count > list_search.Count)
            {
                MessageBox.Show("请选中需要删除的学生信息");
            }
            else//删除指定学生信息并重新显示在表格中
            {
                fm1.list_studeng.RemoveAt(list_search[count - 1]);
                MessageBox.Show("删除成功");
                //将之前的查询记录清除
                list_search.Clear();
                //重新获取当前的清除列表
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
                //重新显示在表格中
                dataGridView1.RowCount = list_search.Count + 1;
                //显示
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
        }

        /// <summary>
        /// 删除当前所有行学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_del_all_Click(object sender, EventArgs e)
        {
            //创建父窗体对象
            Form1 fm1 = (Form1)this.Owner;
            //删除操作
            if (dataGridView1.RowCount < 2)
            {
                MessageBox.Show("当前没有需要删除的信息");
            }
            else //删除当前信息所有行
            {
                //列表删除后，后面的序号会自动减1，此时查询列表的信息不会改变，故可以将循环顺序反过来
                //先从最后一个删除，不会影响前面列表的排序
                for (int i = list_search.Count - 1; i >= 0; i--)
                {
                    fm1.list_studeng.RemoveAt(list_search[i]);
                }
                //将查询名单列表情况
                list_search.Clear();
                //重新显示列表
                MessageBox.Show("删除成功");
                dataGridView1.RowCount = 1;
            }
        }

        /// <summary>
        /// 返回上一级菜单
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }


    }
}
