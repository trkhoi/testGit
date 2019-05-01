namespace TextDetection
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rVid = new System.Windows.Forms.RadioButton();
            this.rRec = new System.Windows.Forms.RadioButton();
            this.rDec = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnBr = new System.Windows.Forms.Button();
            this.textPath = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtConsole = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHis = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rVid);
            this.groupBox1.Controls.Add(this.rRec);
            this.groupBox1.Controls.Add(this.rDec);
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(23, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(564, 53);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Type";
            // 
            // rVid
            // 
            this.rVid.AutoSize = true;
            this.rVid.Location = new System.Drawing.Point(375, 23);
            this.rVid.Margin = new System.Windows.Forms.Padding(4);
            this.rVid.Name = "rVid";
            this.rVid.Size = new System.Drawing.Size(160, 21);
            this.rVid.TabIndex = 2;
            this.rVid.TabStop = true;
            this.rVid.Text = "Text Video Detection";
            this.rVid.UseVisualStyleBackColor = true;
            // 
            // rRec
            // 
            this.rRec.AutoSize = true;
            this.rRec.Location = new System.Drawing.Point(196, 23);
            this.rRec.Margin = new System.Windows.Forms.Padding(4);
            this.rRec.Name = "rRec";
            this.rRec.Size = new System.Drawing.Size(135, 21);
            this.rRec.TabIndex = 1;
            this.rRec.TabStop = true;
            this.rRec.Text = "Text Recognition";
            this.rRec.UseVisualStyleBackColor = true;
            // 
            // rDec
            // 
            this.rDec.AutoSize = true;
            this.rDec.Location = new System.Drawing.Point(28, 23);
            this.rDec.Margin = new System.Windows.Forms.Padding(4);
            this.rDec.Name = "rDec";
            this.rDec.Size = new System.Drawing.Size(120, 21);
            this.rDec.TabIndex = 0;
            this.rDec.TabStop = true;
            this.rDec.Text = "Text Detection";
            this.rDec.UseVisualStyleBackColor = true;
            this.rDec.CheckedChanged += new System.EventHandler(this.rDec_CheckedChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnBr);
            this.groupBox4.Controls.Add(this.textPath);
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(23, 73);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(564, 64);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Select File";
            // 
            // btnBr
            // 
            this.btnBr.BackColor = System.Drawing.Color.Tomato;
            this.btnBr.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnBr.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBr.Location = new System.Drawing.Point(8, 23);
            this.btnBr.Margin = new System.Windows.Forms.Padding(4);
            this.btnBr.Name = "btnBr";
            this.btnBr.Size = new System.Drawing.Size(100, 28);
            this.btnBr.TabIndex = 10;
            this.btnBr.Text = "Browse...";
            this.btnBr.UseVisualStyleBackColor = false;
            this.btnBr.Click += new System.EventHandler(this.btnBr_Click);
            // 
            // textPath
            // 
            this.textPath.Location = new System.Drawing.Point(116, 26);
            this.textPath.Margin = new System.Windows.Forms.Padding(4);
            this.textPath.Name = "textPath";
            this.textPath.Size = new System.Drawing.Size(439, 22);
            this.textPath.TabIndex = 2;
            this.textPath.TextChanged += new System.EventHandler(this.textPath_TextChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtConsole);
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(23, 236);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(564, 251);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Console";
            // 
            // txtConsole
            // 
            this.txtConsole.Location = new System.Drawing.Point(8, 25);
            this.txtConsole.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsole.Multiline = true;
            this.txtConsole.Name = "txtConsole";
            this.txtConsole.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtConsole.Size = new System.Drawing.Size(547, 218);
            this.txtConsole.TabIndex = 0;
            this.txtConsole.Text = "\r\n";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Tomato;
            this.btnStart.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnStart.Location = new System.Drawing.Point(299, 26);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(222, 37);
            this.btnStart.TabIndex = 12;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnHis);
            this.groupBox2.Controls.Add(this.btnStart);
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(23, 144);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(564, 84);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Settings";
            // 
            // btnHis
            // 
            this.btnHis.BackColor = System.Drawing.Color.Tomato;
            this.btnHis.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnHis.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnHis.Location = new System.Drawing.Point(39, 26);
            this.btnHis.Name = "btnHis";
            this.btnHis.Size = new System.Drawing.Size(205, 37);
            this.btnHis.TabIndex = 0;
            this.btnHis.Text = "Show History";
            this.btnHis.UseVisualStyleBackColor = false;
            this.btnHis.Click += new System.EventHandler(this.btnHis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(607, 519);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Text Detection";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rRec;
        private System.Windows.Forms.RadioButton rDec;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnBr;
        private System.Windows.Forms.TextBox textPath;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtConsole;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rVid;
        private System.Windows.Forms.Button btnHis;
    }
}

