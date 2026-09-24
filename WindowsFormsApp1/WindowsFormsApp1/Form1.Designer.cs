namespace WindowsFormsApp1
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
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.bntclose = new System.Windows.Forms.Button();
            this.lblname = new System.Windows.Forms.Label();
            this.lblstudentid = new System.Windows.Forms.Label();
            this.lbldepartment = new System.Windows.Forms.Label();
            this.lblsemester = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtstudentid = new System.Windows.Forms.TextBox();
            this.txtdepertment = new System.Windows.Forms.TextBox();
            this.txtsemester = new System.Windows.Forms.TextBox();
            this.lblshow = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(173, 334);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(166, 41);
            this.btnshow.TabIndex = 0;
            this.btnshow.Text = "show informetion";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(369, 334);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(166, 41);
            this.btnclear.TabIndex = 1;
            this.btnclear.Text = "clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // bntclose
            // 
            this.bntclose.Location = new System.Drawing.Point(567, 334);
            this.bntclose.Name = "bntclose";
            this.bntclose.Size = new System.Drawing.Size(166, 41);
            this.bntclose.TabIndex = 2;
            this.bntclose.Text = "close";
            this.bntclose.UseVisualStyleBackColor = true;
            this.bntclose.Click += new System.EventHandler(this.bntclose_Click);
            // 
            // lblname
            // 
            this.lblname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblname.Location = new System.Drawing.Point(60, 2);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(256, 42);
            this.lblname.TabIndex = 3;
            this.lblname.Text = "enter student name";
            // 
            // lblstudentid
            // 
            this.lblstudentid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblstudentid.Location = new System.Drawing.Point(60, 55);
            this.lblstudentid.Name = "lblstudentid";
            this.lblstudentid.Size = new System.Drawing.Size(256, 42);
            this.lblstudentid.TabIndex = 4;
            this.lblstudentid.Text = "enter student id";
            // 
            // lbldepartment
            // 
            this.lbldepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldepartment.Location = new System.Drawing.Point(60, 115);
            this.lbldepartment.Name = "lbldepartment";
            this.lbldepartment.Size = new System.Drawing.Size(207, 42);
            this.lbldepartment.TabIndex = 5;
            this.lbldepartment.Text = "enter department";
            // 
            // lblsemester
            // 
            this.lblsemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsemester.Location = new System.Drawing.Point(60, 183);
            this.lblsemester.Name = "lblsemester";
            this.lblsemester.Size = new System.Drawing.Size(207, 42);
            this.lblsemester.TabIndex = 6;
            this.lblsemester.Text = "enter semester";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(447, 11);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(271, 26);
            this.txtname.TabIndex = 7;
            // 
            // txtstudentid
            // 
            this.txtstudentid.Location = new System.Drawing.Point(447, 80);
            this.txtstudentid.Name = "txtstudentid";
            this.txtstudentid.Size = new System.Drawing.Size(271, 26);
            this.txtstudentid.TabIndex = 8;
            // 
            // txtdepertment
            // 
            this.txtdepertment.Location = new System.Drawing.Point(447, 141);
            this.txtdepertment.Name = "txtdepertment";
            this.txtdepertment.Size = new System.Drawing.Size(271, 26);
            this.txtdepertment.TabIndex = 9;
            // 
            // txtsemester
            // 
            this.txtsemester.Location = new System.Drawing.Point(447, 213);
            this.txtsemester.Name = "txtsemester";
            this.txtsemester.Size = new System.Drawing.Size(271, 26);
            this.txtsemester.TabIndex = 10;
            // 
            // lblshow
            // 
            this.lblshow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblshow.Location = new System.Drawing.Point(107, 267);
            this.lblshow.Name = "lblshow";
            this.lblshow.Size = new System.Drawing.Size(428, 51);
            this.lblshow.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblshow);
            this.Controls.Add(this.txtsemester);
            this.Controls.Add(this.txtdepertment);
            this.Controls.Add(this.txtstudentid);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.lblsemester);
            this.Controls.Add(this.lbldepartment);
            this.Controls.Add(this.lblstudentid);
            this.Controls.Add(this.lblname);
            this.Controls.Add(this.bntclose);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnshow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button bntclose;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.Label lblstudentid;
        private System.Windows.Forms.Label lbldepartment;
        private System.Windows.Forms.Label lblsemester;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtstudentid;
        private System.Windows.Forms.TextBox txtdepertment;
        private System.Windows.Forms.TextBox txtsemester;
        private System.Windows.Forms.Label lblshow;
    }
}

