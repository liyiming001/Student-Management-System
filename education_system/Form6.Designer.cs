namespace education_system
{
    partial class Form6
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_refresh = new System.Windows.Forms.Button();
            this.bt_save = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bt_return = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(97, 97);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(906, 492);
            this.dataGridView1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(481, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 38);
            this.label1.TabIndex = 19;
            this.label1.Text = "学生信息";
            // 
            // bt_refresh
            // 
            this.bt_refresh.Location = new System.Drawing.Point(1059, 191);
            this.bt_refresh.Name = "bt_refresh";
            this.bt_refresh.Size = new System.Drawing.Size(118, 36);
            this.bt_refresh.TabIndex = 20;
            this.bt_refresh.Text = "刷  新";
            this.bt_refresh.UseVisualStyleBackColor = true;
            this.bt_refresh.Click += new System.EventHandler(this.bt_refresh_Click);
            // 
            // bt_save
            // 
            this.bt_save.Location = new System.Drawing.Point(1059, 289);
            this.bt_save.Name = "bt_save";
            this.bt_save.Size = new System.Drawing.Size(118, 36);
            this.bt_save.TabIndex = 21;
            this.bt_save.Text = "保  存";
            this.bt_save.UseVisualStyleBackColor = true;
            this.bt_save.Click += new System.EventHandler(this.bt_save_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(1059, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(118, 36);
            this.button3.TabIndex = 22;
            this.button3.Text = "加  载";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // bt_return
            // 
            this.bt_return.Location = new System.Drawing.Point(1059, 465);
            this.bt_return.Name = "bt_return";
            this.bt_return.Size = new System.Drawing.Size(118, 36);
            this.bt_return.TabIndex = 23;
            this.bt_return.Text = "返  回";
            this.bt_return.UseVisualStyleBackColor = true;
            this.bt_return.Click += new System.EventHandler(this.bt_return_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(1059, 97);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(118, 23);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(1059, 143);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(117, 23);
            this.comboBox2.TabIndex = 25;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1224, 625);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_return);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bt_save);
            this.Controls.Add(this.bt_refresh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_refresh;
        private System.Windows.Forms.Button bt_save;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bt_return;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}