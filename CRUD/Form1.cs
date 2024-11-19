using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;

namespace CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            GridView1.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UVGR9G8\\SQLEXPRESS;Initial Catalog=crud;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string deleteQuery = "DELETE FROM crud WHERE id=@id";
            SqlCommand cmd = new SqlCommand(deleteQuery, con);
            cmd.Parameters.AddWithValue("@id", numericUpDown1.Value);
            int count = cmd.ExecuteNonQuery();
            if (count > 0)
            {
                MessageBox.Show("deleted Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isAnyempty = false;
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    if (control.Text.Length == 0)
                    {
                        isAnyempty = true;
                        break;
                    }
                }
            }
            if (isAnyempty)
            {
                MessageBox.Show("Fill the required information ", " info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                SqlConnection con = new SqlConnection("Data Source=DESKTOP-UVGR9G8\\SQLEXPRESS;Initial Catalog=crud;Integrated Security=True;TrustServerCertificate=True");
                con.Open();
                string insertQuery = "INSERT INTO crud (email, address, username, password) VALUES (@email, @address, @username, @password)";
                SqlCommand cmd = new SqlCommand(insertQuery, con);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                int count = cmd.ExecuteNonQuery();
                con.Close();
                if (count > 0)
                {
                    MessageBox.Show("Created succesfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Error in Creating", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }


        private void button5_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Visible = false;
                }
                else if (control is NumericUpDown)
                {
                    control.Visible = false;
                }
                else if (control is Label)
                {
                    control.Visible = false;
                }
                else
                {
                    control.Visible = true;
                }

            }
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-UVGR9G8\\SQLEXPRESS;Initial Catalog=crud;Integrated Security=True;TrustServerCertificate=True");
            string readQuery = "SELECT * FROM crud";
            SqlDataAdapter sda = new SqlDataAdapter(readQuery, con);
            SqlCommandBuilder cmd = new SqlCommandBuilder(sda);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            GridView1.DataSource = dt;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection("Data Source=DESKTOP-UVGR9G8\\SQLEXPRESS;Initial Catalog=crud;Integrated Security=True;TrustServerCertificate=True"))
            {
                con.Open();

                // Start building the update query dynamically
                string updateQuery = "UPDATE crud SET ";
                List<string> updateFields = new List<string>();
                SqlCommand cmd = new SqlCommand();

                // Check each input field and add only the modified ones to the query
                if (!string.IsNullOrWhiteSpace(txtEmail.Text))
                {
                    updateFields.Add("email = @email");
                    cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtAddress.Text))
                {
                    updateFields.Add("address = @address");
                    cmd.Parameters.AddWithValue("@address", txtAddress.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtUserName.Text))
                {
                    updateFields.Add("username = @username");
                    cmd.Parameters.AddWithValue("@username", txtUserName.Text);
                }
                if (!string.IsNullOrWhiteSpace(txtPassword.Text))
                {
                    updateFields.Add("password = @password");
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);
                }

                // Ensure at least one field is being updated
                if (updateFields.Count == 0)
                {
                    MessageBox.Show("No fields to update. Please provide at least one value.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Combine the query parts
                updateQuery += string.Join(", ", updateFields) + " WHERE id = @id";
                cmd.CommandText = updateQuery;
                cmd.Connection = con;

                // Add the ID parameter
                cmd.Parameters.AddWithValue("@id", numericUpDown1.Value);

                // Execute the query
                int count = cmd.ExecuteNonQuery();
                con.Close();

                // Display the result
                if (count > 0)
                {
                    MessageBox.Show("Update Successful!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No record updated. Please check the ID.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

    }
}
    

