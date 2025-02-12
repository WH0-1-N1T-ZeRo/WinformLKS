using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpanel
{
    public partial class Form2 : Form
    {
        booksEntities db = new booksEntities();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            usersBindingSource.DataSource = db.users.ToList();
        }

        private void usersDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (usersDataGridView.Rows[e.RowIndex].DataBoundItem is users users)
            {
                // Kondisi untuk mengganti warna baris berdasarkan peran atau kriteria lainnya
                if (users.status_user == "Inactive") // Misalnya, mengganti warna untuk pengguna dengan role "Admin"
                {
                    // Mengganti warna latar belakang baris
                    usersDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

                    // Jika kamu ingin mengganti warna font juga
                    usersDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                if (e.ColumnIndex == user_role.Index) e.Value = users.roles.title;
                if (e.ColumnIndex == Age.Index){
                    e.Value = CekUmur(users.birthdate);
                }
            }
        }

        static string CekUmur(DateTime birthdate)
        {
            DateTime today = DateTime.Today;

            // Menghitung usia berdasarkan tanggal lahir
            int age = today.Year - birthdate.Year;

            // Jika tanggal lahir belum tercapai tahun ini, kurangi usia 1
            if (birthdate.Date > today.AddYears(-age))
            {
                age--;
            }

            // Mengembalikan usia dalam format string
            return age.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (usersBindingSource.Current is users users)
            {
                var userToUpdate = db.users.Find(users.id);
                if (userToUpdate != null)
                {
                    userToUpdate.status_user = "Active";
                    db.SaveChanges();
                    OnLoad(EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("User tidak ditemukan di database.");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (usersBindingSource.Current is users users)
            {
                var userToUpdate = db.users.Find(users.id);
                if (userToUpdate != null)
                {
                    userToUpdate.status_user = "Inactive";
                    db.SaveChanges();
                    OnLoad(EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("User tidak ditemukan di database.");
                }
            }
        }

        public void ReloadData()
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Form4().Show();
        }
    }
}
