using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace education_system
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 加载进来显示所有学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form6_Load(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            comboBox1.Items.Add("所有");
            comboBox1.Items.Add("学生班级");
            //初始化显示
            comboBox1.Text = "所有";
            //ShowMessage();
        }

        /// <summary>
        /// 显示所有学生信息
        /// </summary>
        private void ShowMessage()
        {
            Form1 fm1 = (Form1)this.Owner;
            dataGridView1.ColumnCount = 6;
            if (comboBox1.Text == "所有")
            {
                dataGridView1.RowCount = fm1.list_studeng.Count + 1;
                dataGridView1.Rows[0].Cells[0].Value = "序号";
                dataGridView1.Rows[0].Cells[1].Value = "姓名";
                dataGridView1.Rows[0].Cells[2].Value = "性别";
                dataGridView1.Rows[0].Cells[3].Value = "年龄";
                dataGridView1.Rows[0].Cells[4].Value = "学号";
                dataGridView1.Rows[0].Cells[5].Value = "班级";
                //加载当前所有学生信息
                for (int i = 0; i < fm1.list_studeng.Count; i++)
                {
                    dataGridView1.Rows[i + 1].Cells[0].Value = (i + 1).ToString();
                    dataGridView1.Rows[i + 1].Cells[1].Value = fm1.list_studeng[i].Name;
                    dataGridView1.Rows[i + 1].Cells[2].Value = fm1.list_studeng[i].Gender;
                    dataGridView1.Rows[i + 1].Cells[3].Value = fm1.list_studeng[i].Age.ToString();
                    dataGridView1.Rows[i + 1].Cells[4].Value = fm1.list_studeng[i].ID;
                    dataGridView1.Rows[i + 1].Cells[5].Value = fm1.list_studeng[i].Class;
                }
            }
            else if (comboBox1.Text == "学生班级" && comboBox2.Text != "")
            {
                dataGridView1.RowCount = 1;
                dataGridView1.Rows[0].Cells[0].Value = "序号";
                dataGridView1.Rows[0].Cells[1].Value = "姓名";
                dataGridView1.Rows[0].Cells[2].Value = "性别";
                dataGridView1.Rows[0].Cells[3].Value = "年龄";
                dataGridView1.Rows[0].Cells[4].Value = "学号";
                dataGridView1.Rows[0].Cells[5].Value = "班级";
                int j = 0; //存放表格索引
                for (int i = 0; i < fm1.list_studeng.Count; i++)
                {
                    //判断是否是该班级的学生
                    if (fm1.list_studeng[i].Class == comboBox2.Text)
                    {
                        dataGridView1.Rows.Add();
                        ++j;
                        dataGridView1.Rows[j].Cells[0].Value = (j).ToString();
                        dataGridView1.Rows[j].Cells[1].Value = fm1.list_studeng[i].Name;
                        dataGridView1.Rows[j].Cells[2].Value = fm1.list_studeng[i].Gender;
                        dataGridView1.Rows[j].Cells[3].Value = fm1.list_studeng[i].Age.ToString();
                        dataGridView1.Rows[j].Cells[4].Value = fm1.list_studeng[i].ID;
                        dataGridView1.Rows[j].Cells[5].Value = fm1.list_studeng[i].Class;
                    }
                }
            }
        }

        /// <summary>
        /// 刷新当前所有学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_refresh_Click(object sender, EventArgs e)
        {
            ShowMessage();
        }

        /// <summary>
        /// 退出当前界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
            this.Dispose();
        }

        /// <summary>
        /// 将当前所有信息保存至一个txt文件夹中
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "请选择保存路径地址";
            sfd.InitialDirectory = @"C:\Users\75406\Desktop";
            sfd.Filter = "保存文件名|*.txt";
            sfd.ShowDialog();
            try
            {
                using (FileStream fs = new FileStream(sfd.FileName, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    //byte[] buffer = new byte[1024*1024*10];
                    string s = null;
                    for (int i = 0; i < dataGridView1.RowCount - 1; i++)
                    {
                        s += dataGridView1.Rows[i + 1].Cells[0].Value + " " + dataGridView1.Rows[i + 1].Cells[1].Value + " "
                            + dataGridView1.Rows[i + 1].Cells[2].Value + " " + dataGridView1.Rows[i + 1].Cells[3].Value + " "
                             + dataGridView1.Rows[i + 1].Cells[4].Value + " " + dataGridView1.Rows[i + 1].Cells[5].Value + "\n";
                    }
                    byte[] buffer = Encoding.Default.GetBytes(s);
                    fs.Write(buffer, 0, buffer.Length);
                    MessageBox.Show("保存成功");
                }
            }
            catch
            { 
            }
        }

        /// <summary>
        /// 从文件夹中加载信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "请选择打开文件路径地址";
            ofd.Filter = "文本文件|*.txt";
            ofd.InitialDirectory = @"C:\Users\75406\Desktop";
            ofd.ShowDialog();
            try
            {
                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                {
                    byte[] buffer = new byte[1024 * 1024 * 10];
                    int number = fs.Read(buffer, 0, buffer.Length);
                    string s = Encoding.Default.GetString(buffer, 0, number);
                    //处理字符串
                    string[] s_string = s.Split(' ', '\n');
                    Form1 fm1 = (Form1)this.Owner;
                    //将当前信息录入到系统中
                    for (int i = 0; i < s_string.Length / 6; i++)
                    {
                        //设置标志位，指示当前学号是否已经注册
                        bool flag = false;
                        //首先判断一下学号是否已经存在
                        for (int j = 0; j < fm1.list_studeng.Count; j++)
                        {
                            if (s_string[i * 6 + 4] == fm1.list_studeng[j].ID)//已经添加过该学生信息
                            {
                                flag = true;
                                break;
                            }
                        }
                        //如未注册，则添加学生信息
                        if (flag == false)
                        {
                            Student s_buffer = new Student(s_string[i * 6 + 1], Convert.ToInt32(s_string[i * 6 + 3]), s_string[i * 6 + 2], s_string[i * 6 + 4], s_string[i * 6 + 5]);
                            fm1.list_studeng.Add(s_buffer);
                        }
                    }
                    //提示导入成功
                    MessageBox.Show("导入成功");
                }
            }
            catch
            {
 
            }
        }

        /// <summary>
        /// 选择班级信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "所有")
            {
                comboBox2.Items.Clear();
                comboBox2.Visible = false;
            }
            else if (comboBox1.Text == "学生班级")
            {
                comboBox2.Visible = true;
                List<string> list_class = new List<string>();  //存放班级信息
                //将当前有的班级信息添加到下拉框中
                Form1 fm1 = (Form1)this.Owner;
                for (int i = 0; i < fm1.list_studeng.Count; i++)
                {
                    if (list_class.Contains(fm1.list_studeng[i].Class))
                    {
                        continue;
                    }
                    list_class.Add(fm1.list_studeng[i].Class);//添加班级信息
                }
                for (int i = 0; i < list_class.Count; i++)
                {
                    comboBox2.Items.Add(list_class[i]);
                }
            }
        }
    }
}
