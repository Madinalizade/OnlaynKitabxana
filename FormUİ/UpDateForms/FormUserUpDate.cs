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
    public partial class FormUserUpDate : Form
    {
        private readonly IUserDal _userDal;
        public FormUserUpDate()
        {
            InitializeComponent();
            _userDal = new EfUserDal();
        }
        public void GetSelectedUser(User user)
        {
            tbxUpDateId.Text = user.Id.ToString();
            tbxUpDateFirstName.Text = user.FirstName;
            tbxUpDateLastName.Text = user.LastName;
            tbxUpDateEmail.Text = user.Email;
            tbxUpDatePassword.Text = user.Password;
            DateTime birthday = user.Birthday;
         
        }
        private void btnUserUpDateSave_Click(object sender, EventArgs e)
        {
            _userDal.Update(new User
            {
                Id = int.Parse(tbxUpDateId.Text),
                FirstName = tbxUpDateFirstName.Text,
                LastName = tbxUpDateLastName.Text,
                Email=tbxUpDateEmail.Text,
                Password=tbxUpDatePassword.Text,
                Birthday=DateTime.Now
            });
            this.Close();
        }

        private void btnUserUpDateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
