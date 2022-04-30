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
    public partial class FormGenreAdd : Form
    {
        private IGenreDal _genreDal;
        public FormGenreAdd()
        {
            _genreDal = new EfGenreDal();
            InitializeComponent();
        }

        private void btnGenreAddSave_Click(object sender, EventArgs e)
        {
            _genreDal.Add(new Genre
            {
                Name=tbxGenreAddName.Text
            });
            this.Close();
        }

        private void btnGenreAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
