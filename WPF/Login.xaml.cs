using BusinessObjects;
using Reponsitories;
using System.Windows;

namespace WPF
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        private readonly IAccountRepository _accountRepository;
        public Login()
        {
            InitializeComponent();
            _accountRepository = new AccountRepository();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            AccountMember account = _accountRepository.GetAccountMember(txtUser.Text);
            if (account != null && account.MemberPassword.Equals(txtPass.Password))
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Login thất bại!!");
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
