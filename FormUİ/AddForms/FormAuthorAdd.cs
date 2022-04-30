using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Contret;
using System;
using System.Windows.Forms;

namespace FormUİ.AddForms
{
    public partial class FormAuthorAdd : Form
    {
        private IAuthorDal _authorDal;
        public FormAuthorAdd()
        {
            InitializeComponent();
            _authorDal = new EfAuthorDal();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _authorDal.Add(new Author
            {
                FirstName = tbxFirstName.Text,
                LastName = tbxLastName.Text
            });
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

      
    }
}
