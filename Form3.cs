using System;
using System.Windows.Forms;
using BL.Providers;
using BL.Entities;

namespace n_layer_course.UI
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void insert_Click(object sender, EventArgs e)
        {
             OleDbConnection OleDbConnection1 = new OleDbConnection(this.ConnectionString);
    OleDbCommand OleDbCommand1 = new OleDbCommand();
    OleDbCommand1.Connection = OleDbConnection1;
    OleDbCommand1.CommandType = CommandType.Text;
    OleDbCommand1.CommandText = "INSERT INTO course(courseid,coursename,branchid,teachername,hour)VALUES(@courseid,@coursename,@branchid,@teachername,@hour)";
    OleDbCommand1.Parameters.AddWithValue("@courseid", this.txtcourseid.Text);
    OleDbCommand1.Parameters.AddWithValue("@coursename", this.txtcoursename.Text);
    OleDbCommand1.Parameters.AddWithValue("@branchid", this.txtbranchid.Text);
            OleDbCommand1.Parameters.AddWithValue("@teachername", this.txtteachername.Text);
            OleDbCommand1.Parameters.AddWithValue("@hour", this.txthour.Text);
    OleDbConnection1.Open();
    int result = OleDbCommand1.ExecuteNonQuery();
    OleDbConnection1.Close();
    if (result > 0)
    {
        MessageBox.Show("Insert OK");@
        this.SelectAllRecords();
    }
    else
    {
        MessageBox.Show("Error In Insert");
    }
}

        private void delete_Click(object sender, EventArgs e)
        {
             if (this.dataGridView1.Rows.Count > 0)
    {
       string currentPersonId = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();        
       OleDbConnection OleDbConnection1 = new OleDbConnection(this.ConnectionString);
        OleDbCommand OleDbCommand1 = new OleDbCommand();
        OleDbCommand1.Connection = OleDbConnection1;
        OleDbCommand1.CommandType = CommandType.Text;
        OleDbCommand1.CommandText = "DELETE FROM Person WHERE ID=" + currentPersonId;
        OleDbConnection1.Open();
        int result = OleDbCommand1.ExecuteNonQuery();
        OleDbConnection1.Close();
        if (result > 0)
        {
            MessageBox.Show("Delete OK");
            SelectAllRecords();
        }
        else
        {
            MessageBox.Show("Delete Error");
        }
    }
}

        private void update_Click(object sender, EventArgs e)
        {
             if (this.dataGridView1.Rows.Count > 0)
    {
        string currentPersonId = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
        OleDbConnection OleDbConnection1 = new OleDbConnection(this.ConnectionString);
        OleDbCommand OleDbCommand1 = new OleDbCommand();
        OleDbCommand1.Connection = OleDbConnection1;
        OleDbCommand1.Connection = OleDbConnection1;
        OleDbCommand1.CommandType = CommandType.Text;
        OleDbCommand1.CommandText = "UPDATE Person SET courseid=@courseid,coursename=@coursename,branchid=@branchid,teachername=@teachername,hour=@hour WHERE Id = @Id";
        OleDbCommand1.Parameters.AddWithValue("@courseid", this.txtcourseid.Text);
        OleDbCommand1.Parameters.AddWithValue("@coursename", this.txtcoursename.Text);
        OleDbCommand1.Parameters.AddWithValue("@branchid", this.txtbranchid.Text);
        OleDbCommand1.Parameters.AddWithValue("@teachername", this.txtteachername.Text);
        OleDbCommand1.Parameters.AddWithValue("@hour", this.txthour.Text);
        OleDbConnection1.Open();
        int result = OleDbCommand1.ExecuteNonQuery();
        OleDbConnection1.Close();

        if (result > 0)
        {
            MessageBox.Show("Update OK");
            SelectAllRecords();
        }
        else
        {
            MessageBox.Show("Update Error");
        }
    }
}

       

        














    }
}

