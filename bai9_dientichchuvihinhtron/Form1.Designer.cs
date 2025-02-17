namespace bai9_dientichchuvihinhtron
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btntinh = new System.Windows.Forms.Button();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.txtso = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbdt = new System.Windows.Forms.RadioButton();
            this.rdbcv = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "tính diện tích chu vi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(204, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "bán kính ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(204, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "KQ";
            // 
            // btntinh
            // 
            this.btntinh.Location = new System.Drawing.Point(297, 158);
            this.btntinh.Name = "btntinh";
            this.btntinh.Size = new System.Drawing.Size(75, 23);
            this.btntinh.TabIndex = 1;
            this.btntinh.Text = "tính ";
            this.btntinh.UseVisualStyleBackColor = true;
            this.btntinh.Click += new System.EventHandler(this.btntinh_Click);
            // 
            // txtKQ
            // 
            this.txtKQ.Location = new System.Drawing.Point(284, 122);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(100, 20);
            this.txtKQ.TabIndex = 2;
            // 
            // txtso
            // 
            this.txtso.Location = new System.Drawing.Point(284, 75);
            this.txtso.Name = "txtso";
            this.txtso.Size = new System.Drawing.Size(100, 20);
            this.txtso.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbcv);
            this.groupBox1.Controls.Add(this.rdbdt);
            this.groupBox1.Location = new System.Drawing.Point(476, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "chọn cái cần tính ";
            // 
            // rdbdt
            // 
            this.rdbdt.AutoSize = true;
            this.rdbdt.Location = new System.Drawing.Point(18, 24);
            this.rdbdt.Name = "rdbdt";
            this.rdbdt.Size = new System.Drawing.Size(70, 17);
            this.rdbdt.TabIndex = 0;
            this.rdbdt.TabStop = true;
            this.rdbdt.Text = "diện tích ";
            this.rdbdt.UseVisualStyleBackColor = true;
            // 
            // rdbcv
            // 
            this.rdbcv.AutoSize = true;
            this.rdbcv.Location = new System.Drawing.Point(18, 50);
            this.rdbcv.Name = "rdbcv";
            this.rdbcv.Size = new System.Drawing.Size(57, 17);
            this.rdbcv.TabIndex = 0;
            this.rdbcv.TabStop = true;
            this.rdbcv.Text = "chu vi ";
            this.rdbcv.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtso);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.btntinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btntinh;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.TextBox txtso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbcv;
        private System.Windows.Forms.RadioButton rdbdt;
    }
}

