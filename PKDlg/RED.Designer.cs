namespace PK
{
    partial class RED
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
            this.m_redlst = new System.Windows.Forms.ListBox();
            this.OK = new System.Windows.Forms.Button();
            this.IDC_IN_BUTTON = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_n = new System.Windows.Forms.TextBox();
            this.m_np1 = new System.Windows.Forms.TextBox();
            this.m_nm1 = new System.Windows.Forms.TextBox();
            this.m_np2 = new System.Windows.Forms.TextBox();
            this.m_nm2 = new System.Windows.Forms.TextBox();
            this.m_z1 = new System.Windows.Forms.TextBox();
            this.m_z4 = new System.Windows.Forms.TextBox();
            this.m_z3 = new System.Windows.Forms.TextBox();
            this.m_z2 = new System.Windows.Forms.TextBox();
            this.m_z6 = new System.Windows.Forms.TextBox();
            this.m_z5 = new System.Windows.Forms.TextBox();
            this.IDC_NP1_STATIC = new System.Windows.Forms.Label();
            this.IDC_NM1_STATIC = new System.Windows.Forms.Label();
            this.IDC_NM2_STATIC = new System.Windows.Forms.Label();
            this.IDC_NP2_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z2_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z1_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z6_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z5_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z4_STATIC = new System.Windows.Forms.Label();
            this.IDC_Z3_STATIC = new System.Windows.Forms.Label();
            this.IDC_OUT_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // m_redlst
            // 
            this.m_redlst.FormattingEnabled = true;
            this.m_redlst.ItemHeight = 20;
            this.m_redlst.Items.AddRange(new object[] {
            "Резисторы",
            "Конденсаторы",
            "Индуктивности"});
            this.m_redlst.Location = new System.Drawing.Point(12, 57);
            this.m_redlst.Name = "m_redlst";
            this.m_redlst.Size = new System.Drawing.Size(192, 364);
            this.m_redlst.TabIndex = 0;
            this.m_redlst.DoubleClick += new System.EventHandler(this.m_redlst_DoubleClick);
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(65, 524);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(94, 29);
            this.OK.TabIndex = 1;
            this.OK.Text = "ОК";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // IDC_IN_BUTTON
            // 
            this.IDC_IN_BUTTON.Location = new System.Drawing.Point(475, 524);
            this.IDC_IN_BUTTON.Name = "IDC_IN_BUTTON";
            this.IDC_IN_BUTTON.Size = new System.Drawing.Size(142, 29);
            this.IDC_IN_BUTTON.TabIndex = 2;
            this.IDC_IN_BUTTON.Text = "Ввод описания";
            this.IDC_IN_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_IN_BUTTON.Click += new System.EventHandler(this.IDC_IN_BUTTON_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Тип компонента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Номер компонента";
            // 
            // m_n
            // 
            this.m_n.Location = new System.Drawing.Point(439, 19);
            this.m_n.Name = "m_n";
            this.m_n.Size = new System.Drawing.Size(125, 27);
            this.m_n.TabIndex = 5;
            this.m_n.Text = "1";
            // 
            // m_np1
            // 
            this.m_np1.Location = new System.Drawing.Point(324, 116);
            this.m_np1.Name = "m_np1";
            this.m_np1.Size = new System.Drawing.Size(91, 27);
            this.m_np1.TabIndex = 6;
            // 
            // m_nm1
            // 
            this.m_nm1.Location = new System.Drawing.Point(324, 164);
            this.m_nm1.Name = "m_nm1";
            this.m_nm1.Size = new System.Drawing.Size(91, 27);
            this.m_nm1.TabIndex = 7;
            // 
            // m_np2
            // 
            this.m_np2.Location = new System.Drawing.Point(568, 116);
            this.m_np2.Name = "m_np2";
            this.m_np2.Size = new System.Drawing.Size(93, 27);
            this.m_np2.TabIndex = 8;
            // 
            // m_nm2
            // 
            this.m_nm2.Location = new System.Drawing.Point(568, 164);
            this.m_nm2.Name = "m_nm2";
            this.m_nm2.Size = new System.Drawing.Size(93, 27);
            this.m_nm2.TabIndex = 9;
            // 
            // m_z1
            // 
            this.m_z1.Location = new System.Drawing.Point(568, 211);
            this.m_z1.Name = "m_z1";
            this.m_z1.Size = new System.Drawing.Size(93, 27);
            this.m_z1.TabIndex = 10;
            // 
            // m_z4
            // 
            this.m_z4.Location = new System.Drawing.Point(568, 354);
            this.m_z4.Name = "m_z4";
            this.m_z4.Size = new System.Drawing.Size(93, 27);
            this.m_z4.TabIndex = 13;
            // 
            // m_z3
            // 
            this.m_z3.Location = new System.Drawing.Point(568, 307);
            this.m_z3.Name = "m_z3";
            this.m_z3.Size = new System.Drawing.Size(93, 27);
            this.m_z3.TabIndex = 12;
            // 
            // m_z2
            // 
            this.m_z2.Location = new System.Drawing.Point(568, 259);
            this.m_z2.Name = "m_z2";
            this.m_z2.Size = new System.Drawing.Size(93, 27);
            this.m_z2.TabIndex = 11;
            // 
            // m_z6
            // 
            this.m_z6.Location = new System.Drawing.Point(568, 453);
            this.m_z6.Name = "m_z6";
            this.m_z6.Size = new System.Drawing.Size(93, 27);
            this.m_z6.TabIndex = 15;
            // 
            // m_z5
            // 
            this.m_z5.Location = new System.Drawing.Point(568, 405);
            this.m_z5.Name = "m_z5";
            this.m_z5.Size = new System.Drawing.Size(93, 27);
            this.m_z5.TabIndex = 14;
            // 
            // IDC_NP1_STATIC
            // 
            this.IDC_NP1_STATIC.AutoSize = true;
            this.IDC_NP1_STATIC.Location = new System.Drawing.Point(233, 119);
            this.IDC_NP1_STATIC.Name = "IDC_NP1_STATIC";
            this.IDC_NP1_STATIC.Size = new System.Drawing.Size(76, 20);
            this.IDC_NP1_STATIC.TabIndex = 16;
            this.IDC_NP1_STATIC.Text = "Значение";
            // 
            // IDC_NM1_STATIC
            // 
            this.IDC_NM1_STATIC.AutoSize = true;
            this.IDC_NM1_STATIC.Location = new System.Drawing.Point(233, 167);
            this.IDC_NM1_STATIC.Name = "IDC_NM1_STATIC";
            this.IDC_NM1_STATIC.Size = new System.Drawing.Size(76, 20);
            this.IDC_NM1_STATIC.TabIndex = 17;
            this.IDC_NM1_STATIC.Text = "Значение";
            // 
            // IDC_NM2_STATIC
            // 
            this.IDC_NM2_STATIC.AutoSize = true;
            this.IDC_NM2_STATIC.Location = new System.Drawing.Point(475, 167);
            this.IDC_NM2_STATIC.Name = "IDC_NM2_STATIC";
            this.IDC_NM2_STATIC.Size = new System.Drawing.Size(76, 20);
            this.IDC_NM2_STATIC.TabIndex = 19;
            this.IDC_NM2_STATIC.Text = "Значение";
            // 
            // IDC_NP2_STATIC
            // 
            this.IDC_NP2_STATIC.AutoSize = true;
            this.IDC_NP2_STATIC.Location = new System.Drawing.Point(475, 119);
            this.IDC_NP2_STATIC.Name = "IDC_NP2_STATIC";
            this.IDC_NP2_STATIC.Size = new System.Drawing.Size(76, 20);
            this.IDC_NP2_STATIC.TabIndex = 18;
            this.IDC_NP2_STATIC.Text = "Значение";
            // 
            // IDC_Z2_STATIC
            // 
            this.IDC_Z2_STATIC.AutoSize = true;
            this.IDC_Z2_STATIC.Location = new System.Drawing.Point(475, 262);
            this.IDC_Z2_STATIC.Name = "IDC_Z2_STATIC";
            this.IDC_Z2_STATIC.Size = new System.Drawing.Size(76, 20);
            this.IDC_Z2_STATIC.TabIndex = 21;
            this.IDC_Z2_STATIC.Text = "Значение";
            // 
            // IDC_Z1_STATIC
            // 
            this.IDC_Z1_STATIC.AutoSize = true;
            this.IDC_Z1_STATIC.Location = new System.Drawing.Point(475, 214);
            this.IDC_Z1_STATIC.Name = "IDC_Z1_STATIC";
            this.IDC_Z1_STATIC.Size = new System.Drawing.Size(76, 20);
            this.IDC_Z1_STATIC.TabIndex = 20;
            this.IDC_Z1_STATIC.Text = "Значение";
            // 
            // IDC_Z6_STATIC
            // 
            this.IDC_Z6_STATIC.AutoSize = true;
            this.IDC_Z6_STATIC.Location = new System.Drawing.Point(475, 453);
            this.IDC_Z6_STATIC.Name = "IDC_Z6_STATIC";
            this.IDC_Z6_STATIC.Size = new System.Drawing.Size(76, 20);
            this.IDC_Z6_STATIC.TabIndex = 25;
            this.IDC_Z6_STATIC.Text = "Значение";
            // 
            // IDC_Z5_STATIC
            // 
            this.IDC_Z5_STATIC.AutoSize = true;
            this.IDC_Z5_STATIC.Location = new System.Drawing.Point(475, 405);
            this.IDC_Z5_STATIC.Name = "IDC_Z5_STATIC";
            this.IDC_Z5_STATIC.Size = new System.Drawing.Size(76, 20);
            this.IDC_Z5_STATIC.TabIndex = 24;
            this.IDC_Z5_STATIC.Text = "Значение";
            // 
            // IDC_Z4_STATIC
            // 
            this.IDC_Z4_STATIC.AutoSize = true;
            this.IDC_Z4_STATIC.Location = new System.Drawing.Point(475, 358);
            this.IDC_Z4_STATIC.Name = "IDC_Z4_STATIC";
            this.IDC_Z4_STATIC.Size = new System.Drawing.Size(76, 20);
            this.IDC_Z4_STATIC.TabIndex = 23;
            this.IDC_Z4_STATIC.Text = "Значение";
            // 
            // IDC_Z3_STATIC
            // 
            this.IDC_Z3_STATIC.AutoSize = true;
            this.IDC_Z3_STATIC.Location = new System.Drawing.Point(475, 310);
            this.IDC_Z3_STATIC.Name = "IDC_Z3_STATIC";
            this.IDC_Z3_STATIC.Size = new System.Drawing.Size(76, 20);
            this.IDC_Z3_STATIC.TabIndex = 22;
            this.IDC_Z3_STATIC.Text = "Значение";
            // 
            // IDC_OUT_BUTTON
            // 
            this.IDC_OUT_BUTTON.Location = new System.Drawing.Point(376, 57);
            this.IDC_OUT_BUTTON.Name = "IDC_OUT_BUTTON";
            this.IDC_OUT_BUTTON.Size = new System.Drawing.Size(137, 29);
            this.IDC_OUT_BUTTON.TabIndex = 26;
            this.IDC_OUT_BUTTON.Text = "Вывод описания";
            this.IDC_OUT_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_OUT_BUTTON.Click += new System.EventHandler(this.IDC_OUT_BUTTON_Click);
            // 
            // RED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 583);
            this.Controls.Add(this.IDC_OUT_BUTTON);
            this.Controls.Add(this.IDC_Z6_STATIC);
            this.Controls.Add(this.IDC_Z5_STATIC);
            this.Controls.Add(this.IDC_Z4_STATIC);
            this.Controls.Add(this.IDC_Z3_STATIC);
            this.Controls.Add(this.IDC_Z2_STATIC);
            this.Controls.Add(this.IDC_Z1_STATIC);
            this.Controls.Add(this.IDC_NM2_STATIC);
            this.Controls.Add(this.IDC_NP2_STATIC);
            this.Controls.Add(this.IDC_NM1_STATIC);
            this.Controls.Add(this.IDC_NP1_STATIC);
            this.Controls.Add(this.m_z6);
            this.Controls.Add(this.m_z5);
            this.Controls.Add(this.m_z4);
            this.Controls.Add(this.m_z3);
            this.Controls.Add(this.m_z2);
            this.Controls.Add(this.m_z1);
            this.Controls.Add(this.m_nm2);
            this.Controls.Add(this.m_np2);
            this.Controls.Add(this.m_nm1);
            this.Controls.Add(this.m_np1);
            this.Controls.Add(this.m_n);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDC_IN_BUTTON);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.m_redlst);
            this.Name = "RED";
            this.Text = "Редактирование компонентов";
            this.Load += new System.EventHandler(this.RED_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox m_redlst;
        private Button OK;
        private Button IDC_IN_BUTTON;
        private Label label1;
        private Label label2;
        private TextBox m_n;
        private TextBox m_np1;
        private TextBox m_nm1;
        private TextBox m_np2;
        private TextBox m_nm2;
        private TextBox m_z1;
        private TextBox m_z4;
        private TextBox m_z3;
        private TextBox m_z2;
        private TextBox m_z6;
        private TextBox m_z5;
        private Label IDC_NP1_STATIC;
        private Label IDC_NM1_STATIC;
        private Label IDC_NM2_STATIC;
        private Label IDC_NP2_STATIC;
        private Label IDC_Z2_STATIC;
        private Label IDC_Z1_STATIC;
        private Label IDC_Z6_STATIC;
        private Label IDC_Z5_STATIC;
        private Label IDC_Z4_STATIC;
        private Label IDC_Z3_STATIC;
        private Button IDC_OUT_BUTTON;
    }
}