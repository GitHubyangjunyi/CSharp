namespace File
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txtH = new System.Windows.Forms.TextBox();
            this.txtSex = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnRead = new System.Windows.Forms.Button();
            this.BtnWrite = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtH
            // 
            this.txtH.Location = new System.Drawing.Point(171, 105);
            this.txtH.Name = "txtH";
            this.txtH.Size = new System.Drawing.Size(250, 21);
            this.txtH.TabIndex = 11;
            // 
            // txtSex
            // 
            this.txtSex.Location = new System.Drawing.Point(171, 66);
            this.txtSex.Name = "txtSex";
            this.txtSex.Size = new System.Drawing.Size(250, 21);
            this.txtSex.TabIndex = 12;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(250, 21);
            this.txtName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(119, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 10;
            this.label3.Text = "爱好";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 9;
            this.label2.Text = "性别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 8;
            this.label1.Text = "姓名";
            // 
            // BtnRead
            // 
            this.BtnRead.Location = new System.Drawing.Point(311, 196);
            this.BtnRead.Name = "BtnRead";
            this.BtnRead.Size = new System.Drawing.Size(145, 37);
            this.BtnRead.TabIndex = 7;
            this.BtnRead.Text = "读取文件";
            this.BtnRead.UseVisualStyleBackColor = true;
            this.BtnRead.Click += new System.EventHandler(this.BtnRead_Click);
            // 
            // BtnWrite
            // 
            this.BtnWrite.Location = new System.Drawing.Point(121, 196);
            this.BtnWrite.Name = "BtnWrite";
            this.BtnWrite.Size = new System.Drawing.Size(145, 37);
            this.BtnWrite.TabIndex = 6;
            this.BtnWrite.Text = "写入文件";
            this.BtnWrite.UseVisualStyleBackColor = true;
            this.BtnWrite.Click += new System.EventHandler(this.BtnWrite_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(61, 265);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(465, 111);
            this.textBox1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 490);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtH);
            this.Controls.Add(this.txtSex);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnRead);
            this.Controls.Add(this.BtnWrite);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtH;
        private System.Windows.Forms.TextBox txtSex;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnRead;
        private System.Windows.Forms.Button BtnWrite;
        private System.Windows.Forms.TextBox textBox1;
    }
}

