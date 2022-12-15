namespace PK
{
    partial class L
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
            this.IDC_NEXTL_BUTTON = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.m_npl = new System.Windows.Forms.TextBox();
            this.m_nml = new System.Windows.Forms.TextBox();
            this.m_zl = new System.Windows.Forms.TextBox();
            this.m_nextl = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDC_NEXTL_BUTTON
            // 
            this.IDC_NEXTL_BUTTON.Location = new System.Drawing.Point(91, 179);
            this.IDC_NEXTL_BUTTON.Name = "IDC_NEXTL_BUTTON";
            this.IDC_NEXTL_BUTTON.Size = new System.Drawing.Size(106, 29);
            this.IDC_NEXTL_BUTTON.TabIndex = 26;
            this.IDC_NEXTL_BUTTON.Text = "Следующий";
            this.IDC_NEXTL_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTL_BUTTON.Click += new System.EventHandler(this.IDC_NEXTL_BUTTON_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Значение (Гн)";
            // 
            // m_npl
            // 
            this.m_npl.Location = new System.Drawing.Point(193, 55);
            this.m_npl.Name = "m_npl";
            this.m_npl.Size = new System.Drawing.Size(66, 27);
            this.m_npl.TabIndex = 24;
            this.m_npl.Text = "0";
            // 
            // m_nml
            // 
            this.m_nml.Location = new System.Drawing.Point(193, 92);
            this.m_nml.Name = "m_nml";
            this.m_nml.Size = new System.Drawing.Size(66, 27);
            this.m_nml.TabIndex = 23;
            this.m_nml.Text = "0";
            // 
            // m_zl
            // 
            this.m_zl.Location = new System.Drawing.Point(193, 125);
            this.m_zl.Name = "m_zl";
            this.m_zl.Size = new System.Drawing.Size(66, 27);
            this.m_zl.TabIndex = 22;
            this.m_zl.Text = "0";
            // 
            // m_nextl
            // 
            this.m_nextl.Location = new System.Drawing.Point(193, 18);
            this.m_nextl.Name = "m_nextl";
            this.m_nextl.ReadOnly = true;
            this.m_nextl.Size = new System.Drawing.Size(66, 27);
            this.m_nextl.TabIndex = 21;
            this.m_nextl.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Узел n-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Узел n+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "Индуктивность L";
            // 
            // L
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 220);
            this.Controls.Add(this.IDC_NEXTL_BUTTON);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_npl);
            this.Controls.Add(this.m_nml);
            this.Controls.Add(this.m_zl);
            this.Controls.Add(this.m_nextl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "L";
            this.Text = "L";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button IDC_NEXTL_BUTTON;
        private Label label4;
        private TextBox m_npl;
        private TextBox m_nml;
        private TextBox m_zl;
        private TextBox m_nextl;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}