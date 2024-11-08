using BordroOtomasyon.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BordroOtomasyon.UI
{
    public partial class Login : Form
    {
        private readonly AppDbContext _context;

        public Login(AppDbContext context)
        {
            _context = context;
        }

        public Login()
        {
            InitializeComponent();
            
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
           string email=textEmail.Text;
            string password=textPassword.Text;
            var admin=_context.Users .FirstOrDefault(u=>u.Email == email&& u.PasswordHash == password);
            if(admin != null)
            {
                Console.WriteLine("Giriş Başarılı");
            }
            else
            {
                Console.WriteLine("Giriş başarısız");
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.Show();
                this.Hide();
            }
        


        }
    }
}
