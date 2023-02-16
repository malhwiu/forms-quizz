using System;
using System.Data.SQLite;
using System.Windows.Forms;


namespace TietovisaForms {
    public partial class Form1 : Form {
        // FIXME: make not use relative path
        private static readonly string path = $"{System.AppDomain.CurrentDomain.BaseDirectory}db\\visa.db";
        /* cs 7 does not have constant string interpolation.
         * This string is constructed at runtime :( */

        /*Nikolai: 
         * UPD: switched conStr to private instead of public public readonly static,
         * since there is no longer need using it outside of this class
         */

        private string conStr = $"Data Source={path};ApplicationIntent=ReadOnly";
        public Form1() {
            InitializeComponent();
        }

        private void ConnectDb_Click(object sender, EventArgs e) {

            var visa = new Tietovisa();
            visa.Show();

            var con = new SQLiteConnection(conStr);
            con.Open();

            var cmd = con.CreateCommand();
            cmd.CommandText="select * from tb_Topic;";

            var reader = cmd.ExecuteReader();

            while(reader.Read()) {
                var data = reader.GetValue(1);
                //note this add the assigned element to a combobox
            }

            uint qcount = (uint)uNoQdef.Value;

            con.Close();
            visa.StartGame(conStr, qcount);

        }
    }

}
