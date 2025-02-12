using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cpanel
{
    public partial class Form4 : Form
    {
        booksEntities db=new booksEntities();
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

            var lastId = db.users
                        .Where(u => u.id.StartsWith("USR-")) // Pastikan hanya ID yang valid
                        .AsEnumerable()
                        .Select(u => int.Parse(u.id.Replace("USR-", ""))) // Ambil angka dan ubah ke int
                        .DefaultIfEmpty(0)
                        .Max();

            var IdUser = lastId + 1;

            if (!db.users.Any(u => u.id == "USR-" + IdUser))
            {
                RolebindingSource.DataSource = db.roles.ToList();
                usersBindingSource.Add(new users
                {
                    id = "USR-" + IdUser
                });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (usersBindingSource.Current is users u) { 
                    u.name_user = name_userTextBox.Text;
                    u.email = emailTextBox.Text;
                    u.birthdate = birthdateDateTimePicker.Value;
                    u.roles_id = rolesComboBox.SelectedValue.ToString();
                    u.password_user = password_userTextBox.Text;
                    u.status_user = "Active";



                db.users.AddOrUpdate(u); // Tambah user ke database
                db.SaveChanges(); // Simpan perubahan ke database

                MessageBox.Show("User berhasil ditambahkan!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                new Form2().ReloadData(); // Reload form
                new Form2().Show();
                button2.PerformClick(); // Reset form atau navigasi ke tempat lain
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Terjadi error: " + (ex.InnerException?.Message ?? ex.Message), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
