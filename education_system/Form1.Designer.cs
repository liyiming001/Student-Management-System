namespace education_system
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.user_txt = new System.Windows.Forms.TextBox();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.user_label = new System.Windows.Forms.Label();
            this.password_label = new System.Windows.Forms.Label();
            this.bt_login = new System.Windows.Forms.Button();
            this.bt_reset = new System.Windows.Forms.Button();
            this.detect_txt = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.bt_add = new System.Windows.Forms.Button();
            this.bt_del = new System.Windows.Forms.Button();
            this.bt_search = new System.Windows.Forms.Button();
            this.bt_correct = new System.Windows.Forms.Button();
            this.label_add = new System.Windows.Forms.Label();
            this.label_del = new System.Windows.Forms.Label();
            this.label_search = new System.Windows.Forms.Label();
            this.label_modify = new System.Windows.Forms.Label();
            this.bt_show = new System.Windows.Forms.Button();
            this.label_show = new System.Windows.Forms.Label();
            this.detect_pic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.detect_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // user_txt
            // 
            this.user_txt.Location = new System.Drawing.Point(526, 285);
            this.user_txt.Name = "user_txt";
            this.user_txt.Size = new System.Drawing.Size(295, 25);
            this.user_txt.TabIndex = 0;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(526, 349);
            this.password_txt.Name = "password_txt";
            this.password_txt.PasswordChar = '*';
            this.password_txt.Size = new System.Drawing.Size(295, 25);
            this.password_txt.TabIndex = 1;
            // 
            // user_label
            // 
            this.user_label.AutoSize = true;
            this.user_label.Location = new System.Drawing.Point(435, 288);
            this.user_label.Name = "user_label";
            this.user_label.Size = new System.Drawing.Size(52, 15);
            this.user_label.TabIndex = 2;
            this.user_label.Text = "用户名";
            // 
            // password_label
            // 
            this.password_label.AutoSize = true;
            this.password_label.Location = new System.Drawing.Point(434, 352);
            this.password_label.Name = "password_label";
            this.password_label.Size = new System.Drawing.Size(53, 15);
            this.password_label.TabIndex = 3;
            this.password_label.Text = "密  码";
            // 
            // bt_login
            // 
            this.bt_login.Location = new System.Drawing.Point(526, 450);
            this.bt_login.Name = "bt_login";
            this.bt_login.Size = new System.Drawing.Size(100, 31);
            this.bt_login.TabIndex = 4;
            this.bt_login.Text = "登录";
            this.bt_login.UseVisualStyleBackColor = true;
            this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
            // 
            // bt_reset
            // 
            this.bt_reset.Location = new System.Drawing.Point(721, 450);
            this.bt_reset.Name = "bt_reset";
            this.bt_reset.Size = new System.Drawing.Size(100, 31);
            this.bt_reset.TabIndex = 5;
            this.bt_reset.Text = "重置";
            this.bt_reset.UseVisualStyleBackColor = true;
            this.bt_reset.Click += new System.EventHandler(this.bt_reset_Click);
            // 
            // detect_txt
            // 
            this.detect_txt.Location = new System.Drawing.Point(526, 393);
            this.detect_txt.Name = "detect_txt";
            this.detect_txt.Size = new System.Drawing.Size(128, 25);
            this.detect_txt.TabIndex = 7;
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("黑体", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.title.Location = new System.Drawing.Point(388, 87);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(514, 80);
            this.title.TabIndex = 8;
            this.title.Text = "教务管理系统";
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(78, 437);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(151, 44);
            this.bt_add.TabIndex = 9;
            this.bt_add.Text = "增";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            this.bt_add.MouseEnter += new System.EventHandler(this.bt_add_MouseEnter);
            this.bt_add.MouseLeave += new System.EventHandler(this.bt_add_MouseLeave);
            // 
            // bt_del
            // 
            this.bt_del.Location = new System.Drawing.Point(325, 437);
            this.bt_del.Name = "bt_del";
            this.bt_del.Size = new System.Drawing.Size(151, 44);
            this.bt_del.TabIndex = 10;
            this.bt_del.Text = "删";
            this.bt_del.UseVisualStyleBackColor = true;
            this.bt_del.Click += new System.EventHandler(this.bt_del_Click);
            this.bt_del.MouseEnter += new System.EventHandler(this.bt_del_MouseEnter);
            this.bt_del.MouseLeave += new System.EventHandler(this.bt_del_MouseLeave);
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(564, 437);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(151, 44);
            this.bt_search.TabIndex = 11;
            this.bt_search.Text = "查";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            this.bt_search.MouseEnter += new System.EventHandler(this.bt_search_MouseEnter);
            this.bt_search.MouseLeave += new System.EventHandler(this.bt_search_MouseLeave);
            // 
            // bt_correct
            // 
            this.bt_correct.Location = new System.Drawing.Point(794, 437);
            this.bt_correct.Name = "bt_correct";
            this.bt_correct.Size = new System.Drawing.Size(151, 44);
            this.bt_correct.TabIndex = 12;
            this.bt_correct.Text = "改";
            this.bt_correct.UseVisualStyleBackColor = true;
            this.bt_correct.Click += new System.EventHandler(this.bt_correct_Click);
            this.bt_correct.MouseEnter += new System.EventHandler(this.bt_correct_MouseEnter);
            this.bt_correct.MouseLeave += new System.EventHandler(this.bt_correct_MouseLeave);
            // 
            // label_add
            // 
            this.label_add.AutoSize = true;
            this.label_add.Location = new System.Drawing.Point(108, 416);
            this.label_add.Name = "label_add";
            this.label_add.Size = new System.Drawing.Size(97, 15);
            this.label_add.TabIndex = 13;
            this.label_add.Text = "增加学生信息";
            // 
            // label_del
            // 
            this.label_del.AutoSize = true;
            this.label_del.Location = new System.Drawing.Point(356, 416);
            this.label_del.Name = "label_del";
            this.label_del.Size = new System.Drawing.Size(97, 15);
            this.label_del.TabIndex = 14;
            this.label_del.Text = "删除学生信息";
            // 
            // label_search
            // 
            this.label_search.AutoSize = true;
            this.label_search.Location = new System.Drawing.Point(604, 416);
            this.label_search.Name = "label_search";
            this.label_search.Size = new System.Drawing.Size(97, 15);
            this.label_search.TabIndex = 15;
            this.label_search.Text = "查找学生信息";
            // 
            // label_modify
            // 
            this.label_modify.AutoSize = true;
            this.label_modify.Location = new System.Drawing.Point(824, 416);
            this.label_modify.Name = "label_modify";
            this.label_modify.Size = new System.Drawing.Size(97, 15);
            this.label_modify.TabIndex = 16;
            this.label_modify.Text = "修改学生信息";
            // 
            // bt_show
            // 
            this.bt_show.Location = new System.Drawing.Point(1030, 437);
            this.bt_show.Name = "bt_show";
            this.bt_show.Size = new System.Drawing.Size(151, 44);
            this.bt_show.TabIndex = 17;
            this.bt_show.Text = "总";
            this.bt_show.UseVisualStyleBackColor = true;
            this.bt_show.Click += new System.EventHandler(this.bt_show_Click);
            this.bt_show.MouseEnter += new System.EventHandler(this.bt_show_MouseEnter);
            this.bt_show.MouseLeave += new System.EventHandler(this.bt_show_MouseLeave);
            // 
            // label_show
            // 
            this.label_show.AutoSize = true;
            this.label_show.Location = new System.Drawing.Point(1045, 416);
            this.label_show.Name = "label_show";
            this.label_show.Size = new System.Drawing.Size(127, 15);
            this.label_show.TabIndex = 18;
            this.label_show.Text = "显示所有学生信息";
            // 
            // detect_pic
            // 
            this.detect_pic.Location = new System.Drawing.Point(721, 380);
            this.detect_pic.Name = "detect_pic";
            this.detect_pic.Size = new System.Drawing.Size(88, 51);
            this.detect_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.detect_pic.TabIndex = 6;
            this.detect_pic.TabStop = false;
            this.detect_pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.detect_pic_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1266, 733);
            this.Controls.Add(this.label_show);
            this.Controls.Add(this.bt_show);
            this.Controls.Add(this.label_modify);
            this.Controls.Add(this.label_search);
            this.Controls.Add(this.label_del);
            this.Controls.Add(this.label_add);
            this.Controls.Add(this.bt_correct);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.bt_del);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.detect_txt);
            this.Controls.Add(this.detect_pic);
            this.Controls.Add(this.bt_reset);
            this.Controls.Add(this.bt_login);
            this.Controls.Add(this.password_label);
            this.Controls.Add(this.user_label);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.user_txt);
            this.Controls.Add(this.title);
            this.Name = "Form1";
            this.Text = "教务管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detect_pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox user_txt;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.Label user_label;
        private System.Windows.Forms.Label password_label;
        private System.Windows.Forms.Button bt_login;
        private System.Windows.Forms.Button bt_reset;
        private System.Windows.Forms.PictureBox detect_pic;
        private System.Windows.Forms.TextBox detect_txt;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.Button bt_del;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.Button bt_correct;
        private System.Windows.Forms.Label label_add;
        private System.Windows.Forms.Label label_del;
        private System.Windows.Forms.Label label_search;
        private System.Windows.Forms.Label label_modify;
        private System.Windows.Forms.Button bt_show;
        private System.Windows.Forms.Label label_show;
    }
}

