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
    public partial class FormGenreUpDate : Form
    {
        private readonly IGenreDal _genreDal;
        public FormGenreUpDate()
        {
            _genreDal = new EfGenreDal();
            InitializeComponent();
        }
        public void GetSelectedGenre(Genre genre)
        {
            tbxGenreUpDateId.Text = genre.Id.ToString();
            tbxGenreUpDateName.Text = genre.Name;
        }
        private void btnGenreUpDateSave_Click(object sender, EventArgs e)
        {
            _genreDal.Update(new Genre
            {
                Id=Convert.ToInt32(tbxGenreUpDateId.Text),
                Name=tbxGenreUpDateName.Text
            });
            this.Close();
        }

        private void btnGenreUpDateCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
