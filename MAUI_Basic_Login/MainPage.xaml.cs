namespace MAUI_Basic_Login;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnLoginClicked(object sender, EventArgs e)
    {
        string userId = UserNameEntry.Text ?? "";
        string password = PasswordEntry.Text ?? "";

        if (userId == "Owusu" && password == "Password1")
            MessageLabel.Text = $"Login successful {userId}";
        else
            MessageLabel.Text = $"Login failed {userId}";
    }

    private void OnCancelClicked(object sender, EventArgs e)
    {
        UserNameEntry.Text = "";
        PasswordEntry.Text = "";
        MessageLabel.Text = "";
    }
}
