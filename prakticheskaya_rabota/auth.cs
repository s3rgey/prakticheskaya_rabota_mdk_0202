using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakticheskaya_rabota
{
    public partial class auth : MaterialForm
    {
        Database Database = new Database();
        public auth()
        {
            InitializeComponent();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
               Primary.Indigo500, Primary.Indigo700, Primary.Indigo100, Accent.Indigo200, TextShade.WHITE
            );
        }

        private void auth_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.X)
            {
                Application.Exit();
            }
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            DataTable table = Database.SelecttUser(login.Text, password.Text);
            if (table.Rows.Count > 0)
            {
                MaterialMessageBox.Show("\n Вы успешно авторизовались", "Внимание", MessageBoxButtons.OK);
            }
            else
            {
                MaterialMessageBox.Show("\n Неверный логин или пароль", "Внимание", MessageBoxButtons.OK);
            }
        }
    }
}
