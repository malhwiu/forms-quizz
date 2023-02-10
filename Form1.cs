﻿using System;
using System.Data.SQLite;
using System.Windows.Forms;


namespace TietovisaForms {
    public partial class Form1 : Form {
        // FIXME: make not use relative path
        static readonly string path = $"{System.AppDomain.CurrentDomain.BaseDirectory}db\\visa.db";
        /* cs 7 does not have constant string interpolation.
         * This string is constructed at runtime :( */
        public readonly static string conStr = $"Data Source={path};ApplicationIntent=ReadOnly";
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
                visa.Topic=data.ToString();
            }

            con.Close();
            visa.StartGame();

        }
    }

}
