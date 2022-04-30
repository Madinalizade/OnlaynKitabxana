using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Contret;
using FormUİ.AddForms;
using FormUİ.UpDateForms;
using System;
using Entities.Dtos;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FormUİ
{
    public partial class MainForm : Form
    {
        private readonly IAuthorDal _authorDal;
        private readonly IBookDal _bookDal;
        private readonly IUserDal _userDal;
        private readonly IBookUserDal _bookUserDal;
        private readonly IGenreDal _genreDal;
        public MainForm()
        {
            InitializeComponent();
            _authorDal = new EfAuthorDal();
            _userDal = new EfUserDal();
            _bookUserDal = new EfBookUserDal();
            _bookDal = new EfBookDal();
            _genreDal = new EfGenreDal();
        }
        private List<Author> LoadAuthorsData() => _authorDal.GetAll();
        private List<User> LoadUsersData() => _userDal.GetAll();
        private List<Book> LoadBookData() => _bookDal.GetAll();
        private List<BookUserDto> LoadBookUserData() => _bookUserDal.GetBookUserDetails();
        private List<Genre> LoadGenreData() => _genreDal.GetAll();
        private void btnAuthors_Click(object sender, EventArgs e)
        {
            dgwForm.DataSource = LoadAuthorsData();
            dgwForm.Columns["GetFullName"].Visible = false;
        }

        private void btnUsers_Click(object sender, EventArgs e)
        {
            dgwForm.DataSource = LoadUsersData();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            dgwForm.DataSource = LoadBookData();
        }

        private void btnBookUsers_Click(object sender, EventArgs e)
        {
            dgwForm.DataSource = LoadBookUserData();
            dgwForm.Columns[0].HeaderText = "User's Name";
            dgwForm.Columns[1].HeaderText = "Name of Book";
            dgwForm.Columns[2].HeaderText = "Author's Name";
        }

        private void btnGenre_Click(object sender, EventArgs e)
        {
            dgwForm.DataSource = LoadGenreData();
        }

        private void btnAuthorAdd_Click(object sender, EventArgs e)
        {
            FormAuthorAdd formAuthorAdd = new FormAuthorAdd();
            formAuthorAdd.Show();
        }

        private void btnUserAdd_Click(object sender, EventArgs e)
        {
            FormUserAdd formUserAdd = new FormUserAdd();
            formUserAdd.Show();
        }
        private void btnBookAdd_Click(object sender, EventArgs e)
        {
            FormBookAdd formBookAdd = new FormBookAdd();
            formBookAdd.Show();
        }
        private void btnBookUserAdd_Click(object sender, EventArgs e)
        {
            FormBookUserAdd formBookUserAdd = new FormBookUserAdd();
            formBookUserAdd.Show();
        }
        private void btnGenreAdd_Click(object sender, EventArgs e)
        {
            FormGenreAdd formGenreAdd = new FormGenreAdd();
            formGenreAdd.Show();
        }
       
        private void btnBookUpDate_Click(object sender, EventArgs e)
        {
            FormBookUpDate formBookUpDate = new FormBookUpDate();
            formBookUpDate.GetSelectedBook(new Book
            {
                Id = Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value),
                Name = dgwForm.CurrentRow.Cells[1].Value.ToString(),
                AuthorId= Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value)
            });
            formBookUpDate.Show();
        }
        private void btnAuthorUpDate_Click(object sender, EventArgs e)
        {
            FormAuthorUpDate formAuthorUpDate = new FormAuthorUpDate();
            formAuthorUpDate.GetSelectedAuthor(new Author
            {
                Id = Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value),
                FirstName = dgwForm.CurrentRow.Cells[1].Value.ToString(),
                LastName = dgwForm.CurrentRow.Cells[2].Value.ToString()
            });
            formAuthorUpDate.Show();
        }
        private void btnUserUpDate_Click(object sender, EventArgs e)
        {
            FormUserUpDate formUserUpDate = new FormUserUpDate();
            formUserUpDate.GetSelectedUser(new User
            {
                Id = Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value),
                FirstName = dgwForm.CurrentRow.Cells[1].Value.ToString(),
                LastName=dgwForm.CurrentRow.Cells[2].Value.ToString(),
                Email=dgwForm.CurrentRow.Cells[3].Value.ToString(),
                Password=dgwForm.CurrentRow.Cells[4].Value.ToString(),
               Birthday = Convert.ToDateTime(dgwForm.CurrentRow.Cells[5].Value.ToString())
            }) ;
            formUserUpDate.Show();
        }
        private void btnBookUserUpDate_Click(object sender, EventArgs e)
        {
            FormBookUserUpDate formBookUserUpDate = new FormBookUserUpDate();
            formBookUserUpDate.GetSelectedBookUser(new BookUser
            {
                Id=Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value),
                UserId=Convert.ToInt32(dgwForm.CurrentRow.Cells[1].Value),
                BookId=Convert.ToInt32(dgwForm.CurrentRow.Cells[2].Value)
            });
            formBookUserUpDate.Show();
        }
        private void btnGenreUpDate_Click(object sender, EventArgs e)
        {
            FormGenreUpDate formGenreUpDate = new FormGenreUpDate();
            formGenreUpDate.GetSelectedGenre(new Genre
            {
                Id = Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value),
                Name = dgwForm.CurrentRow.Cells[1].Value.ToString()
            }) ;
        }
        private void LoadOption()
        {
            string[] options = { "Select", "Author", "User", "Genre", "Book User", "Book" };
            cbxDeleteOption.DataSource = options;
        }
        private void btnDeleteSelectedOption_Click(object sender, EventArgs e)
        {
            int option = cbxDeleteOption.SelectedIndex;
            switch (option)
            {
                case 0:
                    MessageBox.Show("Invalid Operation");
                    break;
                case 1:
                    _authorDal.Delete(new Author
                    {
                        Id=Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value),
                        FirstName=dgwForm.CurrentRow.Cells[1].Value.ToString(),
                        LastName=dgwForm.CurrentRow.Cells[2].Value.ToString()
                    });
                    break;
                case 2:
                    _userDal.Delete(new User
                    {
                        Id = Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value),
                        FirstName = dgwForm.CurrentRow.Cells[1].Value.ToString(),
                        LastName = dgwForm.CurrentRow.Cells[2].Value.ToString(),
                        Email = dgwForm.CurrentRow.Cells[3].Value.ToString(),
                        Password = dgwForm.CurrentRow.Cells[4].Value.ToString(),
                        Birthday = Convert.ToDateTime(dgwForm.CurrentRow.Cells[5].Value.ToString())
                    });
                    break;
                case 5:
                    _bookDal.Delete(new Book
                    {
                        Id = Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value),
                        Name = dgwForm.CurrentRow.Cells[1].Value.ToString(),
                        AuthorId = Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value)
                    });
                    break;
                case 4:
                    _bookUserDal.Delete(new BookUser
                    {
                        Id = Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value),
                        UserId = Convert.ToInt32(dgwForm.CurrentRow.Cells[1].Value),
                        BookId = Convert.ToInt32(dgwForm.CurrentRow.Cells[2].Value)
                    });
                    break;
                case 3:
                    _genreDal.Delete(new Genre
                    {
                        Id = Convert.ToInt32(dgwForm.CurrentRow.Cells[0].Value),
                        Name = dgwForm.CurrentRow.Cells[1].Value.ToString()
                    });
                    break;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadOption();
        }

       
    }
}
