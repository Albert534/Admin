using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace MainGUI
{
    public partial class Menu : UserControl
    {
        SqlConnection con;
        SqlDataAdapter adap;
        DataSet ds;
        SqlCommandBuilder cmdl;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source=DESKTOP-COH8Q90;Initial Catalog=realmenu;Persist Security Info=True;User ID=sa;Password=APO gaming";
                con.Open();
                adap = new SqlDataAdapter("select Menu , Prize from tblmenu", con);
                ds = new System.Data.DataSet();
                adap.Fill(ds, "realmenu");
                dataGridView1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)

            {
                MessageBox.Show("Error/n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
