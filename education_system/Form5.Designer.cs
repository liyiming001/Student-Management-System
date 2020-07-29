namespace education_system
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_return = new System.Windows.Forms.Button();
            this.bt_xiugai = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_search = new System.Windows.Forms.Button();
            this.input_txt = new System.Windows.Forms.TextBox();
            this.tip_txt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(1033, 443);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(106, 42);
            this.bt_return.TabIndex = 20;
            this.bt_return.Text = "返  回";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // bt_xiugai
            // 
            this.bt_xiugai.Location = new System.Drawing.Point(1033, 251);
            this.bt_xiugai.Name = "bt_xiugai";
            this.bt_xiugai.Size = new System.Drawing.Size(106, 42);
            this.bt_xiugai.TabIndex = 18;
            this.bt_xiugai.Text = "修  改";
            this.bt_xiugai.UseVisualStyleBackColor = true;
            this.bt_xiugai.Click += new System.EventHandler(this.bt_xiugai_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(83, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(906, 256);
            this.dataGridView1.TabIndex = 17;
            // 
            // bt_search
            // 
            this.bt_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_search.Location = new System.Drawing.Point(1033, 153);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(106, 42);
            this.bt_search.TabIndex = 16;
            this.bt_search.Text = "查  找";
            this.bt_search.UseVisualStyleBackColor = true;
            this.bt_search.Click += new System.EventHandler(this.bt_search_Click);
            // 
            // input_txt
            // 
            this.input_txt.Location = new System.Drawing.Point(556, 162);
            this.input_txt.Name = "input_txt";
            this.input_txt.Size = new System.Drawing.Size(433, 25);
            this.input_txt.TabIndex = 15;
            // 
            // tip_txt
            // 
            this.tip_txt.FormattingEnabled = true;
            this.tip_txt.Location = new System.Drawing.Point(254, 162);
            this.tip_txt.Name = "tip_txt";
            this.tip_txt.Size = new System.Drawing.Size(200, 23);
            this.tip_txt.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(244, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(745, 60);
            this.label1.TabIndex = 13;
            this.label1.Text = "请输入需要修改学生的信息";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1273, 547);
            this.Controls.Add(this.bt_return);
            this.Controls.Add(this.bt_xiugai);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.input_txt);
            this.Controls.Add(this.tip_txt);
            this.Controls.Add(this.label1);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.Button bt_xiugai;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.TextBox input_txt;
        private System.Windows.Forms.ComboBox tip_txt;
        private System.Windows.Forms.Label label1;
    }
}