namespace ShopMT.UIForms.ViewModels
{
    using System;
    using System.Windows.Input;
    using GalaSoft.MvvmLight.Command;
    using Xamarin.Forms;

    public class LoginViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }

        public ICommand LoginCommand =>  new RelayCommand(Login);
        public LoginViewModel()
        {
            this.Email = "mateo1013@gmail.com";
            this.Password = "123456";
        }

        private async void Login()
        {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert
                    (
                    "Error",
                    "You must enter an Email",
                    "Accept"
                    );
                return;
            }

            if (string.IsNullOrEmpty(this.Password))
            {
                await Application.Current.MainPage.DisplayAlert
                    (
                    "Error",
                    "You must enter an password",
                    "Accept"
                    );
                return;
            }

            if(!this.Email.Equals("mateo1013@gmail.com") || !this.Password.Equals("123456")) {
                await Application.Current.MainPage.DisplayAlert
                (
                "Error",
                "User or Password Wrong",
                "Accept"
                );

            }
            await Application.Current.MainPage.DisplayAlert
                (
                "OK",
                "Yeah!!",
                "Accept"
                );
        }
    }
}
