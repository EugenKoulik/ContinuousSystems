using System.Globalization;

namespace PK
{
    public partial class FILE : Form
    {
        public FILE()
        {
            InitializeComponent();
        }

        private void IDC_FILEOK_BUTTON_Click(object sender, EventArgs e)
        {
            switch (GV.k)
            {
                case 0:
                    GV.filename = m_file.Text;
                    if (GV.filename != "")
                        fileout(GV.filename);
                    else
                        MessageBox.Show("Введите имя файла");
                    break;
                case 1:
                    GV.filename = m_file.Text;
                    try
                    {
                        filein(GV.filename);
                    }
                    catch (Exception err)
                    {
                        throw new Exception(err.Message);
                    }

                    break;
            }
            Close();
        }
        private void fileout(string filename)      //Вывод описания схемы в файл
        {
            var fout = new StreamWriter(GV.filename);
            int i;
            var str = GV.nv + " " + GV.nr + " " + GV.nc + " " + GV.nl;
            fout.WriteLine(str);
            for (i = 1; i <= GV.nr; i++)
            {
                str = GV.in_r[i, 0] + " " + GV.in_r[i, 1] + " "
                    + GV.z_r[i].ToString(CultureInfo.InvariantCulture);
                fout.WriteLine(str);
            }
            for (i = 1; i <= GV.nc; i++)
            {
                str = GV.in_c[i, 0] + " " + GV.in_c[i, 1] + " "
                    + GV.z_c[i].ToString(CultureInfo.InvariantCulture);
                fout.WriteLine(str);
            }
            for (i = 1; i <= GV.nl; i++)
            {
                str = GV.in_l[i, 0] + " " + GV.in_l[i, 1] + " "
                    + GV.z_l[i].ToString(CultureInfo.InvariantCulture);
                fout.WriteLine(str);
            }
            //...
            fout.Close();
        }
        private void filein(String filename)      //Ввод описания схемы из файла
        {
            var fin = new StreamReader(GV.filename);
            char[] sep = { ' ' };
            var str = fin.ReadLine();
            var s = str!.Split(sep, 4);//Значение второго аргумента!!!
            GV.nv = int.Parse(s[0]);
            GV.nr = int.Parse(s[1]);
            GV.nc = int.Parse(s[2]);
            GV.nl = int.Parse(s[3]);
            //...
            for (var i = 1; i <= GV.nr; i++)
            {
                str = fin.ReadLine();
                s = str!.Split(sep, 3);
                GV.in_r[i, 0] = int.Parse(s[0]);
                GV.in_r[i, 1] = int.Parse(s[1]);
                GV.z_r[i] = float.Parse(s[2]);
            }
            for (var i = 1; i <= GV.nc; i++)
            {
                str = fin.ReadLine();
                s = str!.Split(sep, 3);
                GV.in_c[i, 0] = int.Parse(s[0]);
                GV.in_c[i, 1] = int.Parse(s[1]);
                GV.z_c[i] = float.Parse(s[2]);
            }
            for (var i = 1; i <= GV.nl; i++)
            {
                str = fin.ReadLine();
                s = str!.Split(sep, 3);
                GV.in_l[i, 0] = int.Parse(s[0]);
                GV.in_l[i, 1] = int.Parse(s[1]);
                GV.z_l[i] = float.Parse(s[2]);
            }
            //...
            fin.Close();
        }
    }
}

