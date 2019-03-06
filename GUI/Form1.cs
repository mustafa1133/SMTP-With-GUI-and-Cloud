using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Net.Mail;
using EASendMail;
using System.Data.SqlClient;
namespace GUI
{
    public partial class Form1 : Form
    {

        private bool _dragging = false;
        //private Point _offset;
        private Point _start_point = new Point(0, 0);
        ConnectDB connectDB = new ConnectDB();
        private int ms=0;
        private int storedMs = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'emailAppDataSet2.contract' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.contractTableAdapter1.Fill(this.emailAppDataSet2.contract);
            // TODO: 이 코드는 데이터를 'emailAppDataSet1.contract' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            RefreshTable();
            // TODO: 이 코드는 데이터를 'emailAppDataSet.address' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.

            DataBind();
        }

        private void RefreshTable()
        {
            //this.contractTableAdapter.Fill(this.emailAppDataSet1.contract);
            this.contractTableAdapter1.Fill(this.emailAppDataSet2.contract);
        }
        void DataBind()
        {
            //store user in the grid
            this.dgvUserData.DataSource = Users.SelectAllUsers();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void destination_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtattachment.Text = openFileDialog1.FileName.ToString();

            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtfrom_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            _dragging = true;
            _start_point = new Point(e.X, e.Y);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_dragging)
            {
                Point p = PointToScreen(e.Location);
                //getting the point to the location of e.x and e.y
                Location = new Point(p.X - this._start_point.X, p.Y - this._start_point.Y);
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            _dragging = false;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal || this.WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Minimized;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
            else if (this.WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void txtattachment_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {//search email
            string email = this.txtEmailAdd.Text;
            bool result = UserService.SelectUser(email, out Users user);
            {
                if (!result)
                {
                    MessageBox.Show("User does not exist");
                    return;
                }
                this.txtNameAdd.Text = user.Name;
                this.txtEmailAdd.Text = user.Email;

                this.dgvUserData.DataSource = Users.SelectAllUsers().Where(d => d.Email == email).ToList();
            }
        }

        private void btnAddEmail_Click(object sender, EventArgs e)
        {
            string name = this.txtNameAdd.Text;
            string email = this.txtEmailAdd.Text;
            var msgresult = MessageBox.Show($"Are you sure you want to add {email}?", "yes or no", MessageBoxButtons.YesNo);

            if (msgresult != DialogResult.Yes)
                return;
            bool result = UserService.CreateUser(email, name, out string msg);
            this.dgvUserData.DataSource = Users.SelectAllUsers();
            MessageBox.Show(msg);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string a="";
            if (dataGridView1.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView1.SelectedCells[0].RowIndex;
                int rowCounts = Convert.ToInt32(dataGridView1.RowCount.ToString());
                DataGridViewRow selectedRow;

                for (int i = 0; i < rowCounts; i++)
                {
                    selectedRow = dataGridView1.Rows[i];
                    a = Convert.ToString(selectedRow.Cells[2].Value);
                    EmailListBox.Items.Add(a);
                }
            }
            
        }

        private void textEmailAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameAdd_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string name = this.txtNameAdd.Text;
            string email = this.txtEmailAdd.Text;
            UserService.UpdateUser(name, email, out string msg);
            DataBind();
            MessageBox.Show(msg);
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {

            string email = this.txtEmailAdd.Text;
            var msgresult = MessageBox.Show($"Are you sure you want to delete {email}?", "Delete", MessageBoxButtons.YesNo);

            if (msgresult != DialogResult.Yes)
                return;
            UserService.DeleteUser(email, out string msg);
            DataBind();
            MessageBox.Show(msg);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            SendEmailAllGroup();
        }
        private void SendEmailAllGroup()
        {
            string emailList = "";
            foreach (string email in EmailListBox.Items)
            {
                emailList += $"{email.ToString()} ";
            }
            

            SendToMultipleUsers.SendEmail(emailList, txtsubject.Text, txtbody.Text);
            MessageBox.Show("Successfully sended!");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            connectDB.Create(NameTextBox.Text, EmailTextBox.Text);
            RefreshTable();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            connectDB.Update(IdTextBox.Text,NameTextBox.Text, EmailTextBox.Text);
            RefreshTable();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            connectDB.Delete(IdTextBox.Text);
            RefreshTable();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void Mouse(object sender, EventArgs e)
        {

        }

        private void MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EmailListBox.Items.Remove(EmailListBox.SelectedItem);
        }

        private void testGroupBtn_Click(object sender, EventArgs e)
        {
            string emailList = "";
            foreach (string email in EmailListBox.Items)
            {
                emailList += $"{email.ToString()} ";
            }
            MessageBox.Show(emailList);
        }

        private void mailTimer_Tick(object sender, EventArgs e)
        {
            ms--;
            timerTxt.Text = ms.ToString();
            if(ms == 0)
            {
                ms = storedMs;
                SendEmailAllGroup();
            }

        }

        private void timerBtn_Click(object sender, EventArgs e)
        {
            mailTimer.Start();
            mailTimer.Interval = 1000;
        }

        private void timerSetBtn_Click(object sender, EventArgs e)
        {
            ms = Convert.ToInt32(timerSetTextBox.Text);
            storedMs = ms;
            timerTxt.Text = ms.ToString();

        }

        private void stopTimerBtn_Click(object sender, EventArgs e)
        {
            mailTimer.Stop();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

    class ConnectDB
    {
        public void Delete(string id)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "dudgnl23.database.windows.net";//"DESKTOP-8TH372Q";//"dudgnl23.database.windows.net";
                builder.UserID = "benKim"; //"sa";//"benKim";
                builder.Password = "dudgnl23@#"; //"dudgnl23";//"dudgnl23@#";
                builder.InitialCatalog = "emailApp";
                string connetionString = @"Data Source=DESKTOP-8TH372Q;Initial Catalog=emailApp;User ID=sa;Password=dudgnl23";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"DELETE FROM contract where id={id}");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.InsertCommand = new SqlCommand(sql, connection);
                        adapter.InsertCommand.ExecuteNonQuery();

                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Update(string id, string name, string userEmail)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "dudgnl23.database.windows.net";//"DESKTOP-8TH372Q";//"dudgnl23.database.windows.net";
                builder.UserID = "benKim"; //"sa";//"benKim";
                builder.Password = "dudgnl23@#"; //"dudgnl23";//"dudgnl23@#";
                builder.InitialCatalog = "emailApp";
                string connetionString = @"Data Source=DESKTOP-8TH372Q;Initial Catalog=emailApp;User ID=sa;Password=dudgnl23";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"UPDATE contract SET name ='{name}', userEmail='{userEmail}' where id={id}");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.InsertCommand = new SqlCommand(sql, connection);
                        adapter.InsertCommand.ExecuteNonQuery();

                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }
        public void Create(string name,string userEmail)
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "dudgnl23.database.windows.net";//"DESKTOP-8TH372Q";//"dudgnl23.database.windows.net";
                builder.UserID = "benKim"; //"sa";//"benKim";
                builder.Password = "dudgnl23@#"; //"dudgnl23";//"dudgnl23@#";
                builder.InitialCatalog = "emailApp";
                string connetionString = @"Data Source=DESKTOP-8TH372Q;Initial Catalog=emailApp;User ID=sa;Password=dudgnl23";
           
                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append($"Insert into contract (name,userEmail) values ('{name}','{userEmail}') ");

                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter();
                        adapter.InsertCommand = new SqlCommand(sql, connection);
                        adapter.InsertCommand.ExecuteNonQuery();
                       
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public void Read()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = "dudgnl23.database.windows.net";//"DESKTOP-8TH372Q";//"dudgnl23.database.windows.net";
                builder.UserID = "benKim"; //"sa";//"benKim";
                builder.Password = "dudgnl23@#"; //"dudgnl23";//"dudgnl23@#";
                builder.InitialCatalog = "emailApp";
                string connetionString = @"Data Source=DESKTOP-8TH372Q;Initial Catalog=emailApp;User ID=sa;Password=dudgnl23";

                using (SqlConnection connection = new SqlConnection(builder.ConnectionString))
                {
                    connection.Open();
                    StringBuilder sb = new StringBuilder();
                    sb.Append("SELECT * from contract ");
                    
                    String sql = sb.ToString();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                MessageBox.Show($"{reader[0]} {reader[1]} {reader[2]}");
                            }
                        }
                    }
                }
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.ToString());
            }
            Console.ReadLine();
        }
    }
}
            
        
