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
    public partial class Form3 : Form
    {
        booksEntities db=new booksEntities();
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            bindingSource_form.DataSource = db.books.ToList();
        }

        private void booksDataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (booksDataGridView.Rows[e.RowIndex].DataBoundItem is books b)
            {
                if(b.stock < 10)
                {
                    // Mengganti warna latar belakang baris
                    booksDataGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;

                    // Jika kamu ingin mengganti warna font juga
                    booksDataGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.White;
                }
                if (e.ColumnIndex == last_edit_by.Index) e.Value = b.users.name_user;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bindingSource_form.DataSource = db.books
    .Where(b => b.book_title.Contains(textBox1.Text) ||
                b.author.Contains(textBox1.Text) ||
                b.publisher.Contains(textBox1.Text) ||
                b.stock.ToString().Contains(textBox1.Text) ||
                b.price.ToString().Contains(textBox1.Text))
    .ToList();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            OnLoad(EventArgs.Empty);
        }
    }
}
