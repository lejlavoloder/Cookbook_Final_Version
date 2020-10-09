using Cookbook.MobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Cookbook.Model;
namespace Cookbook.MobileApp.ViewModels
{
  public  class LoginViewModel:BaseViewModel
    {
        private readonly APIService _service = new APIService("Korisnik");
       private readonly APIService _sevicePosjetitelji=new APIService("Posjetilac");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }
        string _username = string.Empty;
        public string Username
        {
            get { return _username; }
            set { SetProperty(ref _username, value); }
        }

        string _password = string.Empty;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }
        public ICommand LoginCommand { get; set; }
        async Task Login()
        {
            IsBusy = true;

            APIService.Username = Username;
            APIService.Password = Password; 
            
            try
            {
                await _service.Get<dynamic>(null);
                Posjetilac posjetitelj = null;
                List<Posjetilac> list = await _sevicePosjetitelji.Get<List<Posjetilac>>(null);
                foreach(var k in list)
                {
                    if (k.KorisnickoIme == Username)
                    {
                        posjetitelj = k;
                        break;
                    }
                }
                if (posjetitelj != null)
                {
                    Application.Current.MainPage = new MainPage();
                }
                else
                {
                    Application.Current.MainPage = new MainPageAdmin();
                }
            }
           
            catch(Exception ex)
            {

            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
