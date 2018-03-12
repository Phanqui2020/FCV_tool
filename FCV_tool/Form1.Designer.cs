namespace FCV_tool
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
            this.txtFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDes = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtFunc
            // 
            this.txtFunc.Location = new System.Drawing.Point(128, 64);
            this.txtFunc.Name = "txtFunc";
            this.txtFunc.Size = new System.Drawing.Size(215, 20);
            this.txtFunc.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên chức năng";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(128, 100);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(83, 30);
            this.btnCreate.TabIndex = 2;
            this.btnCreate.Text = "Tạo file";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nhập đường dẫn ";
            // 
            // txtPath
            // 
            this.txtPath.Location = new System.Drawing.Point(128, 12);
            this.txtPath.Name = "txtPath";
            this.txtPath.Size = new System.Drawing.Size(215, 20);
            this.txtPath.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nhập đường dẫn view";
            // 
            // txtDes
            // 
            this.txtDes.Location = new System.Drawing.Point(128, 38);
            this.txtDes.Name = "txtDes";
            this.txtDes.Size = new System.Drawing.Size(215, 20);
            this.txtDes.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 299);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPath);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFunc);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDes;
    }
}

