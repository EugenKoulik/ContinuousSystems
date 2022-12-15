namespace PK
{
    public partial class L : Form
    {
        public L()
        {
            InitializeComponent();
        }

        private void IDC_NEXTL_BUTTON_Click(object sender, EventArgs e)
        {
            int i = Int32.Parse(m_nextl.Text);
            GV.in_l[i, 0] = Int32.Parse(m_npl.Text);
            GV.in_l[i, 1] = Int32.Parse(m_nml.Text);
            GV.z_l[i] = Single.Parse(m_zl.Text);
            i++;
            m_nextl.Text = i.ToString();

            if (i <= GV.nl)
            {
                m_npl.Text = "0";
                m_nml.Text = "0";
                m_zl.Text = "0";
                m_npl.Focus();
            }
            else
            {
                this.Close();
            }
                
        }
    }
}
