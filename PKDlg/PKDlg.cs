namespace PK
{
    public partial class PKDlg : Form
    {
        public PKDlg()
        {
            InitializeComponent();
        }

         private void ID_EXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ID_CONS_Click(object sender, EventArgs e)
        {
            var size = new SIZE();
            size.ShowDialog(this);
            size.Dispose();

            if (GV.nr > 0)
            {
                var ir = new R();
                ir.ShowDialog(this);
                ir.Dispose();
            }

            if (GV.nc > 0)
            {
                var ic = new C();
                ic.ShowDialog(this);
                ic.Dispose();
            }

            if (GV.nl > 0)
            {
                var il = new L();
                il.ShowDialog(this);
                il.Dispose();
            }
            
            var res = MessageBox.Show("", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                var file = new FILE();
                GV.k = 0;
                file.ShowDialog(this);
                file.Dispose();
            }

            var f = new F();
            f.ShowDialog(this);
            f.Dispose();
            
            var io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_RED_Click(object sender, EventArgs e)
        {
            var red = new RED();

            red.ShowDialog(this);
            red.Dispose();
        }

        private void ID_FILE_Click(object sender, EventArgs e)
        {
            GV.k = 1;
            var file = new FILE();
            
            try
            {
                file.ShowDialog(this);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
                return;
            }
            
            file.Dispose();
            
            var f = new F();
            f.ShowDialog(this);
            f.Dispose();
            
            var io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_F_Click(object sender, EventArgs e)
        {
            var f = new F();
            f.ShowDialog(this);
            f.Dispose();
        }

        private void ID_IO_Click(object sender, EventArgs e)
        {
            var io = new IO();
            io.ShowDialog(this);
            io.Dispose();
        }

        private void ID_PRIV_Click(object sender, EventArgs e)
        {
            GV.flag = false;
        }

        private void ID_SYS_Click(object sender, EventArgs e)
        {
            GV.flag = true;
        }

        private void ID_INTERNET_Click(object sender, EventArgs e)
        {
            if (!GV.flag)
            {
                INT cint = new INT();
                cint.Show(this);
            }
            else
            {
                System.Diagnostics.Process.Start(@"C:\\Program Files (x86)\\Microsoft\\Edge\\Application\\msedge",
                    @"http://127.0.0.1/MF/Int3d.htm");
            }
        }
    }
}