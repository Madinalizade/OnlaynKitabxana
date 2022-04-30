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
    public partial class FormAuthorUpDate : Form
    {
        private readonly IAuthorDal _authorDal;
        public FormAuthorUpDate()
        {
            InitializeComponent();
            _authorDal = new EfAuthorDal();
        }
        public void GetSelectedAuthor(Author author)
        {
            tbxId.Text = author.Id.ToString();
            tbxFirstName.Text = author.FirstName;
            tbxLastName.Text = author.LastName;
        }
        private void btnUpDateSave_Click(object sender, EventArgs e)
        {
            _authorDal.Update(new Author
            {
                Id=Convert.ToInt32(tbxId.Text),
                FirstName=tbxFirstName.Text,
                 LastName=tbxLastName.Text
            });
            this.Close();
        }

        private void btnUpDateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
