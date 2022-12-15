namespace PK
{
    partial class C
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
            this.IDC_NEXTC_BUTTON = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.m_npc = new System.Windows.Forms.TextBox();
            this.m_nmc = new System.Windows.Forms.TextBox();
            this.m_zc = new System.Windows.Forms.TextBox();
            this.m_nextc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // IDC_NEXTC_BUTTON
            // 
            this.IDC_NEXTC_BUTTON.Location = new System.Drawing.Point(91, 176);
            this.IDC_NEXTC_BUTTON.Name = "IDC_NEXTC_BUTTON";
            this.IDC_NEXTC_BUTTON.Size = new System.Drawing.Size(106, 29);
            this.IDC_NEXTC_BUTTON.TabIndex = 17;
            this.IDC_NEXTC_BUTTON.Text = "Следующий";
            this.IDC_NEXTC_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_NEXTC_BUTTON.Click += new System.EventHandler(this.IDC_NEXTC_BUTTON_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Ёмкость (мкФ)";
            // 
            // m_npc
            // 
            this.m_npc.Location = new System.Drawing.Point(193, 52);
            this.m_npc.Name = "m_npc";
            this.m_npc.Size = new System.Drawing.Size(66, 27);
            this.m_npc.TabIndex = 15;
            this.m_npc.Text = "0";
            // 
            // m_nmc
            // 
            this.m_nmc.Location = new System.Drawing.Point(193, 89);
            this.m_nmc.Name = "m_nmc";
            this.m_nmc.Size = new System.Drawing.Size(66, 27);
            this.m_nmc.TabIndex = 14;
            this.m_nmc.Text = "0";
            // 
            // m_zc
            // 
            this.m_zc.Location = new System.Drawing.Point(193, 122);
            this.m_zc.Name = "m_zc";
            this.m_zc.Size = new System.Drawing.Size(66, 27);
            this.m_zc.TabIndex = 13;
            this.m_zc.Text = "0";
            // 
            // m_nextc
            // 
            this.m_nextc.Location = new System.Drawing.Point(193, 15);
            this.m_nextc.Name = "m_nextc";
            this.m_nextc.ReadOnly = true;
            this.m_nextc.Size = new System.Drawing.Size(66, 27);
            this.m_nextc.TabIndex = 12;
            this.m_nextc.Text = "1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Узел n-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Узел n+";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Конденсатор C";
            // 
            // C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 218);
            this.Controls.Add(this.IDC_NEXTC_BUTTON);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_npc);
            this.Controls.Add(this.m_nmc);
            this.Controls.Add(this.m_zc);
            this.Controls.Add(this.m_nextc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "C";
            this.Text = "C";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button IDC_NEXTC_BUTTON;
        private Label label4;
        private TextBox m_npc;
        private TextBox m_nmc;
        private TextBox m_zc;
        private TextBox m_nextc;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}