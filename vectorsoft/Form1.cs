using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace vectorsoft
{
    public partial class front : Form
    {
        //i had to use this connection i trust u guys will change it to conform to your Server
      //  SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3P9H2MI\\SQLEXPRESS;Initial Catalog=vectorsoft;User ID=test;Password=tester");
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-3P9H2MI\\SQLEXPRESS;Initial Catalog=vectorsoft;Trusted_Connection=Yes");


        public front()
        {
            InitializeComponent();
            txtGender.Enabled = false;
            cmGender.Visible = false;
            conn.Open();
            conn.Close();
        
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime idate;
            idate = dtPicker.Value;
            
            

            String i = cmType.SelectedIndex.ToString();
            String Name = txtName.Text;
            String Surname = txtSurname.Text;
            String id = txtPass.Text;
            String gender = "";
            String DOB = "";
            if (i == "0")
            {
                gender = txtGender.Text;
                DOB = txtDOB.Text;
            }

            if (i == "1")
            {
                gender = cmGender.SelectedItem.ToString();
                DOB = idate.ToString("yyyy/MM/dd");
            }

            try
            {
                conn.Open();
                String sql = "Insert into dbo.people (name,surname,IDTYPE,DOB,Gnder,idPass) values(@name,@surname,@IDTYPE,@DOB,@Gnder,@idPass)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@name", Name);
                cmd.Parameters.AddWithValue("@surname", Surname);
                cmd.Parameters.AddWithValue("@IDTYPE", i);
                cmd.Parameters.AddWithValue("@DOB", DOB);
                cmd.Parameters.AddWithValue("@Gnder", gender);
                cmd.Parameters.AddWithValue("@idPass", id);
                cmd.ExecuteNonQuery();
                conn.Close();
                lblSuccess.Show();
            }catch(SqlException ex)
            {
                //just catching all SQL related exceptions
                MessageBox.Show(ex.ToString());
            }



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public String getID(String ID){
            String year = "";
            String y = ID.Substring(0,2);
            String mon = ID.Substring(2, 2);
            String date=  ID.Substring(4,2);
            int yr = Int32.Parse(y);

            if (yr >= 0 && yr <= 18)
            {
                 year = "20" + y;
            }
            else
                year = "19" + y;

            return year+"/"+mon+"/"+date;
        }
        public String getGender(String ID)
        {
            String ty = "";
            String y = ID.Substring(6, 1);
            int gen = Int32.Parse(y);
            if(gen>=0 && gen<=4)
            {
                ty = "Female";
            }
            else
            {
                ty = "Male";
            }

            return ty;


        }

   

        private void cmType_SelectedIndexChanged(object sender, EventArgs e)
        {
            String i=cmType.SelectedIndex.ToString();
            if (i =="0")
            {
                txtDOB.Show();
                dtPicker.Visible = false;
                txtGender.Enabled = false;
                cmGender.Visible = false;
   
            }
           if (i =="1")
           {
               dtPicker.Visible = true;
               txtDOB.Visible = false;
               txtGender.Enabled = true;
               cmGender.Visible = true;
           }
        }
        public void enBTN()
        {
            if (validate() == true)
            {
                btnSave.Enabled = true;




                //lblDOB.ForeColor = System.Drawing.Color.Black;

            }
            else
                btnSave.Enabled = false;
        }

        public bool validate()
        {
            String x=cmGender.SelectedIndex.ToString();
            String i = cmType.SelectedIndex.ToString();
            Boolean sta = true;
            if (txtName.Text == "" )
            {
                sta = false;
            }
            else if(txtSurname.Text == "" )
                 sta = false;
            else if (txtPass.Text == "")
                sta = false;
        
           
            else if (i == "0")
            {
                if (txtPass.Text.Length <= 0 && txtPass.Text.Length >= 14)
                {
                    lblDOB.ForeColor = System.Drawing.Color.Red;
                    lblPasstype.ForeColor = System.Drawing.Color.Red;
                    sta = false;
                }
            }
            else if (i=="1")
            {
                if (x == "1" || x == "0")
                {
                    sta = true;
                    lblGender.ForeColor = System.Drawing.Color.Black;
                }
            }

            if (txtSurname.Text == "")
            {
                lblSurname.ForeColor = System.Drawing.Color.Red;
            }
            else
                lblSurname.ForeColor = System.Drawing.Color.Black;

            if (txtPass.Text == "")
            {
                lblPasstype.ForeColor = System.Drawing.Color.Red;
            }
            else
                lblPasstype.ForeColor = System.Drawing.Color.Black;
            //if (txtGender.Text == "" || x != "1" || x != "0")
            //{
            //    lblGender.ForeColor = System.Drawing.Color.Red;
            //}
            //else
            //    lblGender.ForeColor = System.Drawing.Color.Black;
            if (txtName.Text == "")
            {
                lblName.ForeColor = System.Drawing.Color.Red;
            }
            else
                lblName.ForeColor = System.Drawing.Color.Black;


       
            

            return sta;
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            String i = cmType.SelectedIndex.ToString();
            if (i == "0")
            {
                if (txtPass.Text.Length == 13 && txtPass.Text.Length != 0)
                {

                    txtGender.Text = getGender(txtPass.Text);
                    txtDOB.Text = getID(txtPass.Text);
                    lblPasstype.ForeColor = System.Drawing.Color.Black;

                    // MessageBox.Show(getGender(txtPass.Text) + "\n" + getID(txtPass.Text));
                }
                else
                {
                    txtGender.Text = "";
                    txtDOB.Text = "";
                    lblPasstype.ForeColor = System.Drawing.Color.Red;
                }
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            enBTN();
        }

        private void txtSurname_TextChanged(object sender, EventArgs e)
        {
            enBTN();
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            enBTN();
        }

        private void txtGender_TextChanged(object sender, EventArgs e)
        {
            enBTN();
        }

        private void cmGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            enBTN();
        }
    }
}
