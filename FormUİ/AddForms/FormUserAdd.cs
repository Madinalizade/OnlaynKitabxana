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

namespace FormUİ.AddForms
{
    public partial class FormUserAdd : Form
    {
        private IUserDal _userDal;
        public FormUserAdd()
        {
            InitializeComponent();
            _userDal = new EfUserDal();
        }

        
        private void btnUserAddSave_Click(object sender, EventArgs e)
        {
            _userDal.Add(new User
            {
                FirstName = tbxUserAddFirstName.Text,
                LastName = tbxUserAddLastName.Text,
                Email = tbxUserAddEmail.Text,
                Password = tbxUserAddPassword.Text,
                Birthday = dtpUserAddBirthday.Value
            });
            this.Close();
        }

        private void btnUserAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
