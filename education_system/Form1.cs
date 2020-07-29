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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //存放所有当前的学生信息
        public List<Student> list_studeng = new List<Student>();

        /// <summary>
        /// 登录状态
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            //设置登陆界面
            title.Visible = true;
            user_label.Visible = true;
            user_txt.Visible = true;
            password_txt.Visible = true;
            password_label.Visible = true;
            detect_txt.Visible = true;
            detect_pic.Visible = true;
            bt_login.Visible = true;
            bt_reset.Visible = true;

            bt_add.Visible = false;
            bt_del.Visible = false;
            bt_search.Visible = false;
            bt_correct.Visible = false;
            bt_show.Visible = false;

            label_add.Visible = false;
            label_del.Visible = false;
            label_modify.Visible = false;
            label_search.Visible = false;
            label_show.Visible = false;

            //刷新验证码
            CheckCode = Captcha.GetRandomNum(5);
            detect_pic.Image = Captcha.CreateCodeImg(CheckCode);
        }

        //存放当前的验证码值
        public string CheckCode
        {
            set;
            get;
        }

        /// <summary>
        /// 登录按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_login_Click(object sender, EventArgs e)
        {
            if (detect_txt.Text != CheckCode)
            {
                MessageBox.Show("验证码输入错误");
                password_txt.Clear();  //将密码与验证码内容清除一下
                detect_txt.Clear();
                password_txt.Focus();
                //并重新刷新一次验证码
                CheckCode = Captcha.GetRandomNum(5);
                detect_pic.Image = Captcha.CreateCodeImg(CheckCode);
            }
            else  //验证用户名与密码是否正确
            {
                if (user_txt.Text == "admin" && password_txt.Text == "123456")  //输入正确，进去到下一环节
                {
                    MessageBox.Show("登录成功");
                    //将当前登录界面的内容隐藏，并将下一个界面的内容显示出来
                    title.Visible = true;
                    user_label.Visible = false;
                    user_txt.Visible = false;
                    password_txt.Visible = false;
                    password_label.Visible = false;
                    detect_txt.Visible = false;
                    detect_pic.Visible = false;
                    bt_login.Visible = false;
                    bt_reset.Visible = false;

                    bt_add.Visible = true;
                    bt_del.Visible = true;
                    bt_search.Visible = true;
                    bt_correct.Visible = true;
                    bt_show.Visible = true;
                }
                else  //输入错误，重新输入
                {
                    MessageBox.Show("用户名或密码错误，请重新输入");
                    //并重新刷新一次验证码
                    CheckCode = Captcha.GetRandomNum(5);
                    detect_pic.Image = Captcha.CreateCodeImg(CheckCode);
                    //将当前密码与用户名、验证码内容清除
                    user_txt.Clear();
                    password_txt.Clear();
                    detect_txt.Clear();
                    user_txt.Focus();
                }
            }

        }

        /// <summary>
        /// 更换验证码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void detect_pic_MouseClick(object sender, MouseEventArgs e)
        {
            //重新刷新一次验证码
            CheckCode = Captcha.GetRandomNum(5);
            detect_pic.Image = Captcha.CreateCodeImg(CheckCode);
        }

        /// <summary>
        /// 重置用户名密码等
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_reset_Click(object sender, EventArgs e)
        {
            CheckCode = Captcha.GetRandomNum(5);
            detect_pic.Image = Captcha.CreateCodeImg(CheckCode);
            //将当前密码与用户名、验证码内容清除
            user_txt.Clear();
            password_txt.Clear();
            detect_txt.Clear();
            user_txt.Focus();
        }

        /// <summary>
        /// 增加学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_add_Click(object sender, EventArgs e)
        {
            Form2 fm2 = new Form2();
            fm2.Owner = this;
            fm2.ShowDialog();
        }

        /// <summary>
        /// 删除学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_del_Click(object sender, EventArgs e)
        {
            Form4 fm4 = new Form4();
            fm4.Owner = this;
            fm4.ShowDialog();
        }

        /// <summary>
        /// 查找学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_search_Click(object sender, EventArgs e)
        {
            Form3 fm3 = new Form3();
            fm3.Owner = this;
            fm3.ShowDialog();
        }

        /// <summary>
        /// 修改学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_correct_Click(object sender, EventArgs e)
        {
            Form5 fm5 = new Form5();
            fm5.Owner = this;
            fm5.ShowDialog();
        }

        /// <summary>
        /// 保存、浏览、加载学生信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_show_Click(object sender, EventArgs e)
        {
            Form6 fm6 = new Form6();
            fm6.Owner = this;
            fm6.ShowDialog();
        }

        /// <summary>
        /// 添加按钮提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_add_MouseEnter(object sender, EventArgs e)
        {
            label_add.Visible = true;
        }
        private void bt_add_MouseLeave(object sender, EventArgs e)
        {
            label_add.Visible = false;
        }

        /// <summary>
        /// 删除按钮提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_del_MouseEnter(object sender, EventArgs e)
        {
            label_del.Visible = true;
        }
        private void bt_del_MouseLeave(object sender, EventArgs e)
        {
            label_del.Visible = false;
        }

        /// <summary>
        /// 查找按钮提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_search_MouseEnter(object sender, EventArgs e)
        {
            label_search.Visible = true;
        }
        private void bt_search_MouseLeave(object sender, EventArgs e)
        {
            label_search.Visible = false;
        }

        /// <summary>
        /// 修改按钮提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_correct_MouseEnter(object sender, EventArgs e)
        {
            label_modify.Visible = true;
        }
        private void bt_correct_MouseLeave(object sender, EventArgs e)
        {
            label_modify.Visible = false;
        }

        /// <summary>
        /// 显示按钮提示信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bt_show_MouseEnter(object sender, EventArgs e)
        {
            label_show.Visible = true;
        }
        private void bt_show_MouseLeave(object sender, EventArgs e)
        {
            label_show.Visible = false;
        }

    }
}
