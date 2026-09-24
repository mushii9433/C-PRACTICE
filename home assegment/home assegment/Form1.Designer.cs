namespace home_assegment
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
            this.txtdayweek = new System.Windows.Forms.TextBox();
            this.txtnamemonth = new System.Windows.Forms.TextBox();
            this.txtnumericmouth = new System.Windows.Forms.TextBox();
            this.txtyear = new System.Windows.Forms.TextBox();
            this.lbldayweek = new System.Windows.Forms.Label();
            this.lblnamemounth = new System.Windows.Forms.Label();
            this.lblnumaric = new System.Windows.Forms.Label();
            this.lblyear = new System.Windows.Forms.Label();
            this.lbloutput = new System.Windows.Forms.Label();
            this.btnshow = new System.Windows.Forms.Button();
            this.btnclrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtdayweek
            // 
            this.txtdayweek.Location = new System.Drawing.Point(438, 35);
            this.txtdayweek.Name = "txtdayweek";
            this.txtdayweek.Size = new System.Drawing.Size(299, 26);
            this.txtdayweek.TabIndex = 0;
            // 
            // txtnamemonth
            // 
            this.txtnamemonth.Location = new System.Drawing.Point(438, 99);
            this.txtnamemonth.Name = "txtnamemonth";
            this.txtnamemonth.Size = new System.Drawing.Size(299, 26);
            this.txtnamemonth.TabIndex = 1;
            this.txtnamemonth.TextChanged += new System.EventHandler(this.txtmonth_TextChanged);
            // 
            // txtnumericmouth
            // 
            this.txtnumericmouth.Location = new System.Drawing.Point(438, 164);
            this.txtnumericmouth.Name = "txtnumericmouth";
            this.txtnumericmouth.Size = new System.Drawing.Size(299, 26);
            this.txtnumericmouth.TabIndex = 2;
            this.txtnumericmouth.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtyear
            // 
            this.txtyear.Location = new System.Drawing.Point(438, 236);
            this.txtyear.Name = "txtyear";
            this.txtyear.Size = new System.Drawing.Size(299, 26);
            this.txtyear.TabIndex = 3;
            // 
            // lbldayweek
            // 
            this.lbldayweek.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbldayweek.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldayweek.Location = new System.Drawing.Point(64, 29);
            this.lbldayweek.Name = "lbldayweek";
            this.lbldayweek.Size = new System.Drawing.Size(350, 26);
            this.lbldayweek.TabIndex = 4;
            this.lbldayweek.Text = "enter day of week";
            // 
            // lblnamemounth
            // 
            this.lblnamemounth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnamemounth.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnamemounth.Location = new System.Drawing.Point(64, 99);
            this.lblnamemounth.Name = "lblnamemounth";
            this.lblnamemounth.Size = new System.Drawing.Size(301, 26);
            this.lblnamemounth.TabIndex = 5;
            this.lblnamemounth.Text = "enter name month";
            // 
            // lblnumaric
            // 
            this.lblnumaric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnumaric.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnumaric.Location = new System.Drawing.Point(64, 164);
            this.lblnumaric.Name = "lblnumaric";
            this.lblnumaric.Size = new System.Drawing.Size(301, 26);
            this.lblnumaric.TabIndex = 6;
            this.lblnumaric.Text = "enter nuumaric of the month";
            // 
            // lblyear
            // 
            this.lblyear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblyear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblyear.Location = new System.Drawing.Point(64, 236);
            this.lblyear.Name = "lblyear";
            this.lblyear.Size = new System.Drawing.Size(301, 26);
            this.lblyear.TabIndex = 7;
            this.lblyear.Text = "enter year";
            // 
            // lbloutput
            // 
            this.lbloutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbloutput.Location = new System.Drawing.Point(64, 307);
            this.lbloutput.Name = "lbloutput";
            this.lbloutput.Size = new System.Drawing.Size(569, 55);
            this.lbloutput.TabIndex = 8;
            // 
            // btnshow
            // 
            this.btnshow.Location = new System.Drawing.Point(154, 385);
            this.btnshow.Name = "btnshow";
            this.btnshow.Size = new System.Drawing.Size(108, 53);
            this.btnshow.TabIndex = 9;
            this.btnshow.Text = "show data";
            this.btnshow.UseVisualStyleBackColor = true;
            this.btnshow.Click += new System.EventHandler(this.btnshow_Click);
            // 
            // btnclrear
            // 
            this.btnclrear.Location = new System.Drawing.Point(373, 385);
            this.btnclrear.Name = "btnclrear";
            this.btnclrear.Size = new System.Drawing.Size(108, 53);
            this.btnclrear.TabIndex = 10;
            this.btnclrear.Text = "clear";
            this.btnclrear.UseVisualStyleBackColor = true;
            this.btnclrear.Click += new System.EventHandler(this.btnclrear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnclrear);
            this.Controls.Add(this.btnshow);
            this.Controls.Add(this.lbloutput);
            this.Controls.Add(this.lblyear);
            this.Controls.Add(this.lblnumaric);
            this.Controls.Add(this.lblnamemounth);
            this.Controls.Add(this.lbldayweek);
            this.Controls.Add(this.txtyear);
            this.Controls.Add(this.txtnumericmouth);
            this.Controls.Add(this.txtnamemonth);
            this.Controls.Add(this.txtdayweek);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdayweek;
        private System.Windows.Forms.TextBox txtnamemonth;
        private System.Windows.Forms.TextBox txtnumericmouth;
        private System.Windows.Forms.TextBox txtyear;
        private System.Windows.Forms.Label lbldayweek;
        private System.Windows.Forms.Label lblnamemounth;
        private System.Windows.Forms.Label lblnumaric;
        private System.Windows.Forms.Label lblyear;
        private System.Windows.Forms.Label lbloutput;
        private System.Windows.Forms.Button btnshow;
        private System.Windows.Forms.Button btnclrear;
    }
}

