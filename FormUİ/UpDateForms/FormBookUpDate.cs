using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Contret;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormUİ.UpDateForms
{
    public partial class FormBookUpDate : Form
    {
        private readonly IBookDal _bookDal;
        public FormBookUpDate()
        {
            _bookDal = new EfBookDal();
            InitializeComponent();
        }
        public void GetSelectedBook(Book book)
        {
            tbxBookUpDateId.Text = book.Id.ToString();
            tbxBookUpDateName.Text = book.Name;
            tbxBookUpDateAuthorId.Text = book.AuthorId.ToString();
        }
        private void btnBookUpDateSave_Click(object sender, EventArgs e)
        {
            _bookDal.Update(new Book
            {
                Id=Convert.ToInt32(tbxBookUpDateId.Text),
                Name=tbxBookUpDateName.Text,
                AuthorId = Convert.ToInt32(tbxBookUpDateAuthorId.Text)
            });
            this.Close();
        }

        private void btnBookUpDateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
