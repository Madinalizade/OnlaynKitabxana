using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Contret;
using System;
using System.Windows.Forms;

namespace FormUİ.AddForms
{
    public partial class FormBookAdd : Form
    {
        private IBookDal _bookDal;
        private IAuthorDal _authorDal;
        private IGenreDal _genreDal;
        public FormBookAdd()
        {
            InitializeComponent();
            _bookDal = new EfBookDal();
            _authorDal = new EfAuthorDal();
            _genreDal = new EfGenreDal();
        }

        private void LoadAuthors()
        {
            cbxAuthors.DataSource = _authorDal.GetAll();
            cbxAuthors.DisplayMember = "GetFullName";
            cbxAuthors.ValueMember = "Id";
        }
        private void LoadGenres()
        {
            cbxGenres.DataSource = _genreDal.GetAll();
            cbxGenres.DisplayMember = "Name";
            cbxGenres.ValueMember = "Id";
        }
        private void btnBookAddSave_Click(object sender, EventArgs e)
        {
            _bookDal.Add(new Book
            {
                Name = tbxBookAddName.Text,
                AuthorId = Convert.ToInt32(cbxAuthors.SelectedValue),
                GenreId = Convert.ToInt32(cbxGenres.SelectedValue)
            });
            this.Close();
        }

        private void btnBookAddCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormBookAdd_Load(object sender, EventArgs e)
        {
            LoadAuthors();
            LoadGenres();
        }
    }
}
