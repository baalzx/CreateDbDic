namespace DatabaseFramework
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.dgv_Mc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Lx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Yxk = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Ms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgv_Zj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(146, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(146, 115);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 21);
            this.textBox1.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgv_Mc,
            this.dgv_Lx,
            this.dgv_Yxk,
            this.dgv_Ms,
            this.dgv_Zj});
            this.dgv.Location = new System.Drawing.Point(89, 186);
            this.dgv.Name = "dgv";
            this.dgv.RowTemplate.Height = 23;
            this.dgv.Size = new System.Drawing.Size(240, 150);
            this.dgv.TabIndex = 2;
            // 
            // dgv_Mc
            // 
            this.dgv_Mc.HeaderText = "Column1";
            this.dgv_Mc.Name = "dgv_Mc";
            // 
            // dgv_Lx
            // 
            this.dgv_Lx.HeaderText = "Column2";
            this.dgv_Lx.Name = "dgv_Lx";
            // 
            // dgv_Yxk
            // 
            this.dgv_Yxk.HeaderText = "Column3";
            this.dgv_Yxk.Name = "dgv_Yxk";
            // 
            // dgv_Ms
            // 
            this.dgv_Ms.HeaderText = "Column4";
            this.dgv_Ms.Name = "dgv_Ms";
            // 
            // dgv_Zj
            // 
            this.dgv_Zj.HeaderText = "dgv_Zj";
            this.dgv_Zj.Name = "dgv_Zj";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 366);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Mc;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Lx;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Yxk;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Ms;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgv_Zj;
    }
}

