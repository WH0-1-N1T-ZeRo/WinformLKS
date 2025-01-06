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
    public partial class Form1 : Form
    {
        booksEntities db = new booksEntities();
        int salah = 3;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //menyalakan fungsi create
            usersBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var nama = name_userTextBox.Text;
            var pass = password_userTextBox.Text;
            if (salah == 0)
            {
                button2.PerformClick();
            }

            var CheckLogin = db.users.FirstOrDefault(u => u.name_user == nama && u.password_user == pass);
            if (CheckLogin != null)
            {
                if(CheckLogin.status_user == "Inactive")
                {
                    MessageBox.Show("Akun ada mati mohon hubungi admin untuk meng aktifkan kembali akun anda!!");
                }
                //Pengecekan Role User memakai relasi dari ENF
                else if(CheckLogin.roles.title == "Administrator") new Form2().Show();
                else if (CheckLogin.roles.title == "Operator") new Form3().Show();
            }
            else
            {
                salah -= 1;
                MessageBox.Show("Username atau password anda salah mohon coba lagi sisa percobaan anda adalah " +salah);
            }
        }
    }
}
