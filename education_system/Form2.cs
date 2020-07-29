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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 添加信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_add_Click(object sender, EventArgs e)
        {
            //创建父窗体对象
            Form1 fm1 = (Form1)this.Owner;
            //判断ID是否唯一，不唯一说明已经被创建过，提示添加失败;
            for (int i = 0; i < fm1.list_studeng.Count; i++)
            {
                if (fm1.list_studeng[i].ID == ID_txt.Text)  //说明已经添加过
                {
                    MessageBox.Show("该ID已被创建，请重新输入");
                    //清除文本框内容
                    ID_txt.Clear();
                    name_txt.Clear();
                    gender_txt1.Text = null;
                    age_txt.Clear();
                    class_txt.Clear();
                    name_txt.Focus();
                    //返回
                    return;
                }
            }
            //验证信息是否正确
            if (gender_txt1.Text != "男" && gender_txt1.Text != "女")
            {
                MessageBox.Show("性别输入格式错误，请输入男或女");
                //清除文本框内容
                ID_txt.Clear();
                name_txt.Clear();
                gender_txt1.Text = null;
                age_txt.Clear();
                class_txt.Clear();
                name_txt.Focus();
                //返回
                return;
            }
            //验证年龄是否输入正确
            int age;
            try
            {
                age = Convert.ToInt32(age_txt.Text);
                if (age < 0 || age > 150)
                {
                    MessageBox.Show("年龄输入内容错误，请输入正确的年龄");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("年龄输入内容错误，请输入正确的年龄");
                //清除文本框内容
                ID_txt.Clear();
                name_txt.Clear();
                gender_txt1.Text = null;
                age_txt.Clear();
                class_txt.Clear();
                name_txt.Focus();
                //返回
                return;
            }
            //信息输入正确，将信息添加至列表中
            Student stu = new Student(name_txt.Text, age, gender_txt1.Text, ID_txt.Text, class_txt.Text);
            fm1.list_studeng.Add(stu);
            MessageBox.Show("添加成功");
            ID_txt.Clear();
            name_txt.Clear();
            gender_txt1.Text = null;
            age_txt.Clear();
            class_txt.Clear();
            name_txt.Focus();
        }

        /// <summary>
        /// 返回上一界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 重置当前信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_reset1_Click(object sender, EventArgs e)
        {
            ID_txt.Clear();
            name_txt.Clear();
            gender_txt1.Text = null;
            age_txt.Clear();
            class_txt.Clear();
            name_txt.Focus();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            gender_txt1.Items.Add("男");
            gender_txt1.Items.Add("女");
        }

        /// <summary>
        /// 显示重置按钮提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_reset1_MouseEnter(object sender, EventArgs e)
        {
            reset_label.Visible = true;
        }

        private void bt_reset1_MouseLeave(object sender, EventArgs e)
        {
            reset_label.Visible = false;
        }
    }
}
