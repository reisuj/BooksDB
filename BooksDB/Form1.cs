﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace BooksDB
{
    public partial class frmTitles : Form
    {
        OleDbConnection conn;
        public frmTitles()
        {
            InitializeComponent();
        }

        private void frmTitles_Load(object sender, EventArgs e)
        {
            var connString = @"Provider=Microsoft.ACE.OLEDB.12.0; Data Source=D:\repos\Databases\Books.accdb; Persist Security Info = False;";

            conn = new OleDbConnection(connString);
            conn.Open();
            txtConn.Text = conn.ToString();
        }
    }
}
