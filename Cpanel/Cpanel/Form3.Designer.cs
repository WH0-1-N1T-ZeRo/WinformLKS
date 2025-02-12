namespace Cpanel
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label book_titleLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label priceLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label stockLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.book_titleTextBox = new System.Windows.Forms.TextBox();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.stockTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idbooks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title_books = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stock_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_book = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_edit_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource_form = new System.Windows.Forms.BindingSource(this.components);
            authorLabel = new System.Windows.Forms.Label();
            book_titleLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            priceLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            stockLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_form)).BeginInit();
            this.SuspendLayout();
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AllowUserToAddRows = false;
            this.booksDataGridView.AllowUserToDeleteRows = false;
            this.booksDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.booksDataGridView.AutoGenerateColumns = false;
            this.booksDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbooks,
            this.title_books,
            this.author_book,
            this.publisher_book,
            this.stock_book,
            this.price_book,
            this.dataGridViewTextBoxColumn7,
            this.last_edit_by});
            this.booksDataGridView.DataSource = this.bindingSource_form;
            this.booksDataGridView.Location = new System.Drawing.Point(31, 64);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.ReadOnly = true;
            this.booksDataGridView.Size = new System.Drawing.Size(617, 301);
            this.booksDataGridView.TabIndex = 1;
            this.booksDataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.booksDataGridView_CellFormatting);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(authorLabel);
            this.groupBox1.Controls.Add(this.authorTextBox);
            this.groupBox1.Controls.Add(book_titleLabel);
            this.groupBox1.Controls.Add(this.book_titleTextBox);
            this.groupBox1.Controls.Add(idLabel);
            this.groupBox1.Controls.Add(this.idTextBox);
            this.groupBox1.Controls.Add(priceLabel);
            this.groupBox1.Controls.Add(this.priceTextBox);
            this.groupBox1.Controls.Add(publisherLabel);
            this.groupBox1.Controls.Add(this.publisherTextBox);
            this.groupBox1.Controls.Add(stockLabel);
            this.groupBox1.Controls.Add(this.stockTextBox);
            this.groupBox1.Location = new System.Drawing.Point(753, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 301);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Books Properti";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(654, 64);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(93, 301);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // authorLabel
            // 
            authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(15, 89);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(38, 13);
            authorLabel.TabIndex = 0;
            authorLabel.Text = "Author";
            // 
            // authorTextBox
            // 
            this.authorTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "author", true));
            this.authorTextBox.Location = new System.Drawing.Point(87, 86);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(144, 20);
            this.authorTextBox.TabIndex = 1;
            // 
            // book_titleLabel
            // 
            book_titleLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            book_titleLabel.AutoSize = true;
            book_titleLabel.Location = new System.Drawing.Point(15, 63);
            book_titleLabel.Name = "book_titleLabel";
            book_titleLabel.Size = new System.Drawing.Size(55, 13);
            book_titleLabel.TabIndex = 2;
            book_titleLabel.Text = "Book Title";
            // 
            // book_titleTextBox
            // 
            this.book_titleTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.book_titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "book_title", true));
            this.book_titleTextBox.Location = new System.Drawing.Point(87, 60);
            this.book_titleTextBox.Name = "book_titleTextBox";
            this.book_titleTextBox.Size = new System.Drawing.Size(144, 20);
            this.book_titleTextBox.TabIndex = 3;
            // 
            // idLabel
            // 
            idLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(15, 37);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(51, 13);
            idLabel.TabIndex = 4;
            idLabel.Text = "Books ID";
            // 
            // idTextBox
            // 
            this.idTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(87, 34);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(144, 20);
            this.idTextBox.TabIndex = 5;
            // 
            // priceLabel
            // 
            priceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            priceLabel.AutoSize = true;
            priceLabel.Location = new System.Drawing.Point(15, 167);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new System.Drawing.Size(31, 13);
            priceLabel.TabIndex = 8;
            priceLabel.Text = "Price";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "price", true));
            this.priceTextBox.Location = new System.Drawing.Point(87, 164);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(144, 20);
            this.priceTextBox.TabIndex = 9;
            // 
            // publisherLabel
            // 
            publisherLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(15, 115);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(50, 13);
            publisherLabel.TabIndex = 10;
            publisherLabel.Text = "Publisher";
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.publisherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "publisher", true));
            this.publisherTextBox.Location = new System.Drawing.Point(87, 112);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(144, 20);
            this.publisherTextBox.TabIndex = 11;
            // 
            // stockLabel
            // 
            stockLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            stockLabel.AutoSize = true;
            stockLabel.Location = new System.Drawing.Point(15, 141);
            stockLabel.Name = "stockLabel";
            stockLabel.Size = new System.Drawing.Size(35, 13);
            stockLabel.TabIndex = 12;
            stockLabel.Text = "Stock";
            // 
            // stockTextBox
            // 
            this.stockTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "stock", true));
            this.stockTextBox.Location = new System.Drawing.Point(87, 138);
            this.stockTextBox.Name = "stockTextBox";
            this.stockTextBox.Size = new System.Drawing.Size(144, 20);
            this.stockTextBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.Location = new System.Drawing.Point(9, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.Location = new System.Drawing.Point(12, 86);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.Location = new System.Drawing.Point(12, 115);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(217, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "Serch";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(298, 26);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 5;
            this.button5.Text = "Cancel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 26);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(136, 20);
            this.textBox1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Search";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataSource = typeof(Cpanel.books);
            // 
            // idbooks
            // 
            this.idbooks.DataPropertyName = "id";
            this.idbooks.HeaderText = "Books ID";
            this.idbooks.Name = "idbooks";
            this.idbooks.ReadOnly = true;
            // 
            // title_books
            // 
            this.title_books.DataPropertyName = "book_title";
            this.title_books.HeaderText = "Book Title";
            this.title_books.Name = "title_books";
            this.title_books.ReadOnly = true;
            // 
            // author_book
            // 
            this.author_book.DataPropertyName = "author";
            this.author_book.HeaderText = "Author";
            this.author_book.Name = "author_book";
            this.author_book.ReadOnly = true;
            // 
            // publisher_book
            // 
            this.publisher_book.DataPropertyName = "publisher";
            this.publisher_book.HeaderText = "Publisher";
            this.publisher_book.Name = "publisher_book";
            this.publisher_book.ReadOnly = true;
            // 
            // stock_book
            // 
            this.stock_book.DataPropertyName = "stock";
            this.stock_book.HeaderText = "Stock";
            this.stock_book.Name = "stock_book";
            this.stock_book.ReadOnly = true;
            // 
            // price_book
            // 
            this.price_book.DataPropertyName = "price";
            this.price_book.HeaderText = "Price";
            this.price_book.Name = "price_book";
            this.price_book.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "id_user";
            this.dataGridViewTextBoxColumn7.HeaderText = "id_user";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Visible = false;
            // 
            // last_edit_by
            // 
            this.last_edit_by.DataPropertyName = "users";
            this.last_edit_by.HeaderText = "Last Edited By";
            this.last_edit_by.Name = "last_edit_by";
            this.last_edit_by.ReadOnly = true;
            // 
            // bindingSource_form
            // 
            this.bindingSource_form.DataSource = typeof(Cpanel.books);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 377);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.booksDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form3";
            this.Text = "Books";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource_form)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox book_titleTextBox;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox stockTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource bindingSource_form;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn title_books;
        private System.Windows.Forms.DataGridViewTextBoxColumn author_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn stock_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_book;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_edit_by;
    }
}