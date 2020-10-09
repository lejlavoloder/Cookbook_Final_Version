using Cookbook.Model;
using Cookbook.Model.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cookbook.MobileApp.ViewModels
{
    public class SastojakViewModel:BaseViewModel
    {
        public SastojakViewModel()
        {
            DodajSastojakCommand = new Command(async () => await DodajSastojak());
            PrikazSastojakaCommand = new Command(async () => await PrikazSastojaka());
        }
        public ICommand DodajSastojakCommand { get; set; }
        public ICommand PrikazSastojakaCommand { get; set; }
        public ICommand InitCommand { get; set; }

        private APIService _service = new APIService("Sastojak");
        public ObservableCollection<Sastojak> SastojakList { get; set; } = new ObservableCollection<Sastojak>();
        public async Task DodajSastojak()
        {
            IsBusy = true;
            await _service.Insert<Sastojak>(new SastojakInsertRequest()
            {
                Naziv = _naziv,
            });
            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
        }
        public async Task PrikazSastojaka()
        {
            var list = await _service.Get<IEnumerable<Sastojak>>(null);
            SastojakList.Clear();
            foreach (var sastojak in list)
            {
                SastojakList.Add(sastojak);
            }
        }
        string _naziv = string.Empty;
   
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }
    }
}
