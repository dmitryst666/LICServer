using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.IO;
using Microsoft.Win32;

namespace LICServer
{
    

    public partial class Form1 : Form
    {
        private string dbFileName;
        private SQLiteConnection m_dbConn;
        private SQLiteCommand m_sqlCmd;

        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_dbConn = new SQLiteConnection();
            m_sqlCmd = new SQLiteCommand();

            dbFileName = "sample.sqlite";
        }


        /// <summary>
        /// Get Unique ID
        /// </summary>

        public string GetMachineGuid()
        {
            string location = @"SOFTWARE\Microsoft\Cryptography";
            string name = "MachineGuid";

            using (RegistryKey localMachineX64View =
                RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64))
            {
                using (RegistryKey rk = localMachineX64View.OpenSubKey(location))
                {
                    if (rk == null)
                        throw new KeyNotFoundException(
                            string.Format("Key Not Found: {0}", location));

                    object machineGuid = rk.GetValue(name);
                    if (machineGuid == null)
                        throw new IndexOutOfRangeException(
                            string.Format("Index Not Found: {0}", name));

                    return machineGuid.ToString();
                }
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("Generated HWID:\n" + GetMachineGuid() );
        }



        private void createBtn_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dbFileName))
                SQLiteConnection.CreateFile(dbFileName);

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                m_sqlCmd.CommandText = "CREATE TABLE IF NOT EXISTS Catalog (id INTEGER PRIMARY KEY AUTOINCREMENT, HWID TEXT, LIC INTEGER)";
                m_sqlCmd.ExecuteNonQuery();

                label1.Text = "Connected";
            }
            catch (SQLiteException ex)
            {
                label1.Text = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void connDB_Click(object sender, EventArgs e)
        {
            if (!File.Exists(dbFileName))
                MessageBox.Show("Please, create DB and blank table (Push \"Create\" button)");

            try
            {
                m_dbConn = new SQLiteConnection("Data Source=" + dbFileName + ";Version=3;");
                m_dbConn.Open();
                m_sqlCmd.Connection = m_dbConn;

                label1.Text = "Connected";
            }
            catch (SQLiteException ex)
            {
                label1.Text = "Disconnected";
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            DataTable dTable = new DataTable();
            String sqlQuery;

            if (m_dbConn.State != ConnectionState.Open)
            {
                MessageBox.Show("Opening connection with database");
                connDB.PerformClick();
                //return;
            }

            try
            {
                sqlQuery = "SELECT * FROM Catalog";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sqlQuery, m_dbConn);
                adapter.Fill(dTable);
                dgvViewer.DataSource = dTable;

                if (dTable.Rows.Count > 0)
                {
                    //dgvViewer.Rows.Clear();

                    //for (int i = 0; i < dTable.Rows.Count; i++)
                    //    dgvViewer.Rows.Add(dTable.Rows[i].ItemArray);
                }
                else
                    MessageBox.Show("Database is empty");
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


    }

    public class Prod
    {
        
        public int ProductId { get; set; }
        
        public string Name { get; set; }
    }
}
