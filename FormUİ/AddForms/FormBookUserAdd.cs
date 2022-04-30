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
    public partial class FormBookUserAdd : Form
    {
        private readonly IBookUserDal _bookUserDal;
        public FormBookUserAdd()
        {
            _bookUserDal = new EfBookUserDal();
            InitializeComponent();
        }

        private void btnBookUserSave_Click(object sender, EventArgs e)
        {
            _bookUserDal.Add(new BookUser
            {
               
                UserId=int.Parse(tbxBookUserAddUserId.Text),
                BookId=int.Parse(tbxBookUserAddBookId.Text)
            });
            this.Close();
        }

        private void btnBookUserCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
