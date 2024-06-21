using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Cmpt291UI
{
    public partial class LoginScreen : Form
    {
        public static string databasePath = EnumHelper.GetPath(DATABASEPATH.AyubMohamed);
        public static string employeeLoggedIn;

        public LoginScreen()
        {
            InitializeComponent();
        }


        //Global Enum for database paths
        public enum DATABASEPATH
        {
            AyubHaji,
            Sami,
            AyubMohamed
        }

        public static class DatabasePathStrings
        {
            public static readonly string[] Values =
            {
            "Data Source=LAPTOP-MID32020;Initial Catalog=291_FinalProject;Integrated Security=True;Encrypt=False"   ,
            "Data Source=LAPTOP-7KGL33RR;Initial Catalog=291;Integrated Security=True;Encrypt=False"                ,
            "Data Source=DESKTOP-3PU7T29;Initial Catalog=CMPT291;Integrated Security=True;Encrypt=False"
    };
        }

        public static class EnumHelper
        {
            public static string GetPath(DATABASEPATH user)
            {
                return DatabasePathStrings.Values[(int)user];
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            String employeeNum, user_password;

            employeeNum = employeeNumBox.Text;
            employeeLoggedIn = employeeNumBox.Text;
            user_password = passwordBox.Text;

            try
            {
                SqlConnection conn = new SqlConnection(databasePath);
                String query = "SELECT * FROM Employees where EmployeeNum = '"+employeeNumBox.Text+"' AND password = '"+ passwordBox.Text+"'";
                SqlDataAdapter sda = new SqlDataAdapter(query, conn);

                DataTable dtable = new DataTable();
                sda.Fill(dtable);

                if (dtable.Rows.Count > 0)
                {
                    employeeNum = employeeNumBox.Text;
                    user_password = passwordBox.Text;

                    // page that needed to be loaded next
                    EmployeeMainWindowBook form2 = new EmployeeMainWindowBook();
                    form2.Show();
                    this.Hide();
                    conn.Dispose();
                    conn.Close();
                }
                else
                {
                    MessageBox.Show("Invalid login details", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    employeeNumBox.Clear();
                    passwordBox.Clear();
                }
            }
            catch 
            {
                MessageBox.Show("Error");
            }
        }


        private void Clear_Click(object sender, EventArgs e)
        {
            employeeNumBox.Clear();
            passwordBox.Clear();

            employeeNumBox.Focus();
        }

        private void Exit_Click(object sender, EventArgs e)
        {   
            //Goes back to Main Page
            Login goBack = new Login();
            this.Hide();
            goBack.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(databasePath);

            // load addnewcustomer window
            AddNewCustomer addNewCustomersForm = new AddNewCustomer();
            addNewCustomersForm.Show();
            this.Hide();
            conn.Dispose();
            conn.Close();
        }

        private void employeeNumBox_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
