namespace Hex
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
            this.components = new System.ComponentModel.Container();
            this.tbDec = new System.Windows.Forms.TextBox();
            this.tbBin = new System.Windows.Forms.TextBox();
            this.tbHex = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chbox15 = new System.Windows.Forms.CheckBox();
            this.chbox14 = new System.Windows.Forms.CheckBox();
            this.chbox13 = new System.Windows.Forms.CheckBox();
            this.chbox12 = new System.Windows.Forms.CheckBox();
            this.chbox11 = new System.Windows.Forms.CheckBox();
            this.chbox10 = new System.Windows.Forms.CheckBox();
            this.chbox9 = new System.Windows.Forms.CheckBox();
            this.chbox8 = new System.Windows.Forms.CheckBox();
            this.chbox7 = new System.Windows.Forms.CheckBox();
            this.chbox6 = new System.Windows.Forms.CheckBox();
            this.chbox5 = new System.Windows.Forms.CheckBox();
            this.chbox4 = new System.Windows.Forms.CheckBox();
            this.chbox3 = new System.Windows.Forms.CheckBox();
            this.chbox2 = new System.Windows.Forms.CheckBox();
            this.chbox1 = new System.Windows.Forms.CheckBox();
            this.chbox0 = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblReset = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.lblOnTop = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbDec
            // 
            this.tbDec.Location = new System.Drawing.Point(309, 9);
            this.tbDec.MaxLength = 5;
            this.tbDec.Name = "tbDec";
            this.tbDec.Size = new System.Drawing.Size(52, 22);
            this.tbDec.TabIndex = 0;
            this.tbDec.Text = "0";
            this.tbDec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbDec.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbDec_MouseClick);
            this.tbDec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDec_KeyPress);
            this.tbDec.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbDec_KeyUp);
            // 
            // tbBin
            // 
            this.tbBin.Location = new System.Drawing.Point(131, 9);
            this.tbBin.MaxLength = 16;
            this.tbBin.Name = "tbBin";
            this.tbBin.Size = new System.Drawing.Size(127, 22);
            this.tbBin.TabIndex = 1;
            this.tbBin.Text = "0";
            this.tbBin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbBin.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbBin_MouseClick);
            this.tbBin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBin_KeyPress);
            this.tbBin.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbBin_KeyUp);
            // 
            // tbHex
            // 
            this.tbHex.Location = new System.Drawing.Point(44, 10);
            this.tbHex.MaxLength = 4;
            this.tbHex.Name = "tbHex";
            this.tbHex.Size = new System.Drawing.Size(42, 22);
            this.tbHex.TabIndex = 1;
            this.tbHex.Text = "0";
            this.tbHex.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbHex.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbHex_MouseClick);
            this.tbHex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHex_KeyPress);
            this.tbHex.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbHex_KeyUp);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "HEX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "BIN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(270, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "DEC";
            // 
            // chbox15
            // 
            this.chbox15.AutoSize = true;
            this.chbox15.Location = new System.Drawing.Point(9, 57);
            this.chbox15.Name = "chbox15";
            this.chbox15.Size = new System.Drawing.Size(18, 17);
            this.chbox15.TabIndex = 4;
            this.chbox15.UseVisualStyleBackColor = true;
            this.chbox15.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox14
            // 
            this.chbox14.AutoSize = true;
            this.chbox14.Location = new System.Drawing.Point(33, 57);
            this.chbox14.Name = "chbox14";
            this.chbox14.Size = new System.Drawing.Size(18, 17);
            this.chbox14.TabIndex = 4;
            this.chbox14.UseVisualStyleBackColor = true;
            this.chbox14.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox13
            // 
            this.chbox13.AutoSize = true;
            this.chbox13.Location = new System.Drawing.Point(57, 57);
            this.chbox13.Name = "chbox13";
            this.chbox13.Size = new System.Drawing.Size(18, 17);
            this.chbox13.TabIndex = 4;
            this.chbox13.UseVisualStyleBackColor = true;
            this.chbox13.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox12
            // 
            this.chbox12.AutoSize = true;
            this.chbox12.Location = new System.Drawing.Point(81, 57);
            this.chbox12.Name = "chbox12";
            this.chbox12.Size = new System.Drawing.Size(18, 17);
            this.chbox12.TabIndex = 4;
            this.chbox12.UseVisualStyleBackColor = true;
            this.chbox12.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox11
            // 
            this.chbox11.AutoSize = true;
            this.chbox11.Location = new System.Drawing.Point(105, 57);
            this.chbox11.Name = "chbox11";
            this.chbox11.Size = new System.Drawing.Size(18, 17);
            this.chbox11.TabIndex = 4;
            this.chbox11.UseVisualStyleBackColor = true;
            this.chbox11.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox10
            // 
            this.chbox10.AutoSize = true;
            this.chbox10.Location = new System.Drawing.Point(129, 57);
            this.chbox10.Name = "chbox10";
            this.chbox10.Size = new System.Drawing.Size(18, 17);
            this.chbox10.TabIndex = 4;
            this.chbox10.UseVisualStyleBackColor = true;
            this.chbox10.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox9
            // 
            this.chbox9.AutoSize = true;
            this.chbox9.Location = new System.Drawing.Point(153, 57);
            this.chbox9.Name = "chbox9";
            this.chbox9.Size = new System.Drawing.Size(18, 17);
            this.chbox9.TabIndex = 4;
            this.chbox9.UseVisualStyleBackColor = true;
            this.chbox9.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox8
            // 
            this.chbox8.AutoSize = true;
            this.chbox8.Location = new System.Drawing.Point(177, 57);
            this.chbox8.Name = "chbox8";
            this.chbox8.Size = new System.Drawing.Size(18, 17);
            this.chbox8.TabIndex = 4;
            this.chbox8.UseVisualStyleBackColor = true;
            this.chbox8.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox7
            // 
            this.chbox7.AutoSize = true;
            this.chbox7.BackColor = System.Drawing.Color.White;
            this.chbox7.Location = new System.Drawing.Point(227, 57);
            this.chbox7.Name = "chbox7";
            this.chbox7.Size = new System.Drawing.Size(18, 17);
            this.chbox7.TabIndex = 4;
            this.chbox7.UseVisualStyleBackColor = false;
            this.chbox7.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox6
            // 
            this.chbox6.AutoSize = true;
            this.chbox6.BackColor = System.Drawing.Color.White;
            this.chbox6.Location = new System.Drawing.Point(251, 57);
            this.chbox6.Name = "chbox6";
            this.chbox6.Size = new System.Drawing.Size(18, 17);
            this.chbox6.TabIndex = 4;
            this.chbox6.UseVisualStyleBackColor = false;
            this.chbox6.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox5
            // 
            this.chbox5.AutoSize = true;
            this.chbox5.BackColor = System.Drawing.Color.White;
            this.chbox5.Location = new System.Drawing.Point(275, 57);
            this.chbox5.Name = "chbox5";
            this.chbox5.Size = new System.Drawing.Size(18, 17);
            this.chbox5.TabIndex = 4;
            this.chbox5.UseVisualStyleBackColor = false;
            this.chbox5.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox4
            // 
            this.chbox4.AutoSize = true;
            this.chbox4.BackColor = System.Drawing.Color.White;
            this.chbox4.Location = new System.Drawing.Point(299, 57);
            this.chbox4.Name = "chbox4";
            this.chbox4.Size = new System.Drawing.Size(18, 17);
            this.chbox4.TabIndex = 4;
            this.chbox4.UseVisualStyleBackColor = false;
            this.chbox4.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox3
            // 
            this.chbox3.AutoSize = true;
            this.chbox3.BackColor = System.Drawing.Color.White;
            this.chbox3.Location = new System.Drawing.Point(323, 57);
            this.chbox3.Name = "chbox3";
            this.chbox3.Size = new System.Drawing.Size(18, 17);
            this.chbox3.TabIndex = 4;
            this.chbox3.UseVisualStyleBackColor = false;
            this.chbox3.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox2
            // 
            this.chbox2.AutoSize = true;
            this.chbox2.BackColor = System.Drawing.Color.White;
            this.chbox2.Location = new System.Drawing.Point(347, 57);
            this.chbox2.Name = "chbox2";
            this.chbox2.Size = new System.Drawing.Size(18, 17);
            this.chbox2.TabIndex = 4;
            this.chbox2.UseVisualStyleBackColor = false;
            this.chbox2.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox1
            // 
            this.chbox1.AutoSize = true;
            this.chbox1.BackColor = System.Drawing.Color.White;
            this.chbox1.Location = new System.Drawing.Point(371, 57);
            this.chbox1.Name = "chbox1";
            this.chbox1.Size = new System.Drawing.Size(18, 17);
            this.chbox1.TabIndex = 4;
            this.chbox1.UseVisualStyleBackColor = false;
            this.chbox1.Click += new System.EventHandler(this.chbox_Click);
            // 
            // chbox0
            // 
            this.chbox0.AutoSize = true;
            this.chbox0.BackColor = System.Drawing.Color.White;
            this.chbox0.Location = new System.Drawing.Point(395, 57);
            this.chbox0.Name = "chbox0";
            this.chbox0.Size = new System.Drawing.Size(18, 17);
            this.chbox0.TabIndex = 4;
            this.chbox0.UseVisualStyleBackColor = false;
            this.chbox0.Click += new System.EventHandler(this.chbox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(395, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "3";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(299, 37);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 5;
            this.label8.Text = "4";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(276, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "5";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(252, 37);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 16);
            this.label10.TabIndex = 5;
            this.label10.Text = "6";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(227, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 16);
            this.label11.TabIndex = 5;
            this.label11.Text = "7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(177, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 16);
            this.label12.TabIndex = 5;
            this.label12.Text = "8";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(154, 37);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 16);
            this.label13.TabIndex = 5;
            this.label13.Text = "9";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(126, 37);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 16);
            this.label14.TabIndex = 5;
            this.label14.Text = "10";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(102, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(21, 16);
            this.label15.TabIndex = 5;
            this.label15.Text = "11";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(78, 37);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 16);
            this.label16.TabIndex = 5;
            this.label16.Text = "12";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(53, 37);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(21, 16);
            this.label17.TabIndex = 5;
            this.label17.Text = "13";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 37);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(21, 16);
            this.label18.TabIndex = 5;
            this.label18.Text = "14";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(6, 37);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(21, 16);
            this.label19.TabIndex = 5;
            this.label19.Text = "15";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(435, 57);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(432, 37);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(22, 16);
            this.label20.TabIndex = 7;
            this.label20.Text = "All";
            // 
            // lblReset
            // 
            this.lblReset.AutoSize = true;
            this.lblReset.BackColor = System.Drawing.Color.Firebrick;
            this.lblReset.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblReset.ForeColor = System.Drawing.Color.White;
            this.lblReset.Location = new System.Drawing.Point(369, 9);
            this.lblReset.Name = "lblReset";
            this.lblReset.Padding = new System.Windows.Forms.Padding(2);
            this.lblReset.Size = new System.Drawing.Size(41, 22);
            this.lblReset.TabIndex = 8;
            this.lblReset.Text = "Res";
            this.lblReset.Click += new System.EventHandler(this.lblReset_Click);
            // 
            // lblOnTop
            // 
            this.lblOnTop.AutoSize = true;
            this.lblOnTop.BackColor = System.Drawing.Color.DarkGray;
            this.lblOnTop.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblOnTop.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblOnTop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblOnTop.ForeColor = System.Drawing.Color.White;
            this.lblOnTop.Location = new System.Drawing.Point(413, 9);
            this.lblOnTop.Name = "lblOnTop";
            this.lblOnTop.Padding = new System.Windows.Forms.Padding(2);
            this.lblOnTop.Size = new System.Drawing.Size(41, 22);
            this.lblOnTop.TabIndex = 8;
            this.lblOnTop.Text = "Top";
            this.lblOnTop.Click += new System.EventHandler(this.lblOnTop_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 79);
            this.Controls.Add(this.lblOnTop);
            this.Controls.Add(this.lblReset);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chbox7);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chbox15);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chbox14);
            this.Controls.Add(this.tbHex);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.tbBin);
            this.Controls.Add(this.chbox13);
            this.Controls.Add(this.tbDec);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.chbox6);
            this.Controls.Add(this.chbox12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.chbox0);
            this.Controls.Add(this.chbox11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.chbox1);
            this.Controls.Add(this.chbox10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.chbox2);
            this.Controls.Add(this.chbox9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chbox3);
            this.Controls.Add(this.chbox8);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.chbox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.chbox5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "HEX converter";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDec;
        private System.Windows.Forms.TextBox tbBin;
        private System.Windows.Forms.TextBox tbHex;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chbox15;
        private System.Windows.Forms.CheckBox chbox14;
        private System.Windows.Forms.CheckBox chbox13;
        private System.Windows.Forms.CheckBox chbox12;
        private System.Windows.Forms.CheckBox chbox11;
        private System.Windows.Forms.CheckBox chbox10;
        private System.Windows.Forms.CheckBox chbox9;
        private System.Windows.Forms.CheckBox chbox8;
        private System.Windows.Forms.CheckBox chbox7;
        private System.Windows.Forms.CheckBox chbox6;
        private System.Windows.Forms.CheckBox chbox5;
        private System.Windows.Forms.CheckBox chbox4;
        private System.Windows.Forms.CheckBox chbox3;
        private System.Windows.Forms.CheckBox chbox2;
        private System.Windows.Forms.CheckBox chbox1;
        private System.Windows.Forms.CheckBox chbox0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblReset;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label lblOnTop;
    }
}

