using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Contret;
using System;
using System.Windows.Forms;

namespace FormUİ.UpDateForms
{
    public partial class FormBookUserUpDate : Form
    {
        private readonly IBookUserDal _bookUserDal;
        public FormBookUserUpDate()
        {
            _bookUserDal = new EfBookUserDal();
            InitializeComponent();
        }
        public void GetSelectedBookUser(BookUser bookUser)
        {
            tbxBookUserUpDateId.Text = bookUser.Id.ToString();
            tbxBookUserUpDateUserId.Text = bookUser.UserId.ToString();
            tbxBookUserUpDateBookId.Text = bookUser.BookId.ToString();
        }
        private void btnBookUserUpDateSave_Click(object sender, EventArgs e)
        {
            _bookUserDal.Update(new BookUser
            {
                Id=Convert.ToInt32(tbxBookUserUpDateId.Text),
                UserId=Convert.ToInt32(tbxBookUserUpDateUserId.Text),
                BookId=Convert.ToInt32(tbxBookUserUpDateBookId.Text)
            });
            this.Close();
        }

        private void btnBookUserUpDateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
