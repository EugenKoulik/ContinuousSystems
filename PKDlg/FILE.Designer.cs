using System.ComponentModel;

namespace PK;

partial class FILE
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
            this.m_file = new System.Windows.Forms.TextBox();
            this.IDC_FILEOK_BUTTON = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите имя файла";
            // 
            // m_file
            // 
            this.m_file.Location = new System.Drawing.Point(12, 53);
            this.m_file.Name = "m_file";
            this.m_file.Size = new System.Drawing.Size(357, 27);
            this.m_file.TabIndex = 1;
            // 
            // IDC_FILEOK_BUTTON
            // 
            this.IDC_FILEOK_BUTTON.Location = new System.Drawing.Point(135, 111);
            this.IDC_FILEOK_BUTTON.Name = "IDC_FILEOK_BUTTON";
            this.IDC_FILEOK_BUTTON.Size = new System.Drawing.Size(94, 29);
            this.IDC_FILEOK_BUTTON.TabIndex = 2;
            this.IDC_FILEOK_BUTTON.Text = "OK";
            this.IDC_FILEOK_BUTTON.UseVisualStyleBackColor = true;
            this.IDC_FILEOK_BUTTON.Click += new System.EventHandler(this.IDC_FILEOK_BUTTON_Click);
            // 
            // FILE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 152);
            this.Controls.Add(this.IDC_FILEOK_BUTTON);
            this.Controls.Add(this.m_file);
            this.Controls.Add(this.label1);
            this.Name = "FILE";
            this.Text = "Имя файла";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox m_file;
        private Button IDC_FILEOK_BUTTON;
}