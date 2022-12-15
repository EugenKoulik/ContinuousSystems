namespace PK
{
    public partial class SIZE : Form
    {
        public SIZE()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            GV.nv = Int32.Parse(m_nv.Text);
            GV.nr = Int32.Parse(m_nr.Text);
            GV.nc = Int32.Parse(m_nc.Text);
            GV.nl = Int32.Parse(m_nl.Text);
            this.Close();
        }
    }
}
