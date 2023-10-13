using Service.Service;

public class AccountController
{
    private AccountService accountService;

    public AccountController()
    {
        accountService = new AccountService();
    }

    public void Login(string email, string password)
    {
        bool isAuthenticated = accountService.Login(email, password);
        if (isAuthenticated)
        {
            Console.WriteLine("Girish ugurludur!");
        }
        else
        {
            Console.WriteLine("Email ve ya Password yanlishdir!");
        }
    }
}
