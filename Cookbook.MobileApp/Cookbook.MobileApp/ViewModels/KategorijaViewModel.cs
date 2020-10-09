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
   public class KategorijaViewModel:BaseViewModel
    {
        public KategorijaViewModel()
        {
            DodajKategorijuCommand = new Command(async () => await DodajKategoriju());
            PrikazKategorijeCommand = new Command(async () => await PrikazKategorije());
        }

        public ICommand DodajKategorijuCommand { get; set; }
        public ICommand PrikazKategorijeCommand { get; set; }
        public ICommand InitCommand { get; set; }
       
        private APIService _service = new APIService("Kategorija");

        public ObservableCollection<Kategorija> KategorijaList { get; set; } = new ObservableCollection<Kategorija>();

        public Kategorija kategorija { get; set; }
        public async Task DodajKategoriju()
        {
            IsBusy = true;
            await _service.Insert<Kategorija>(new KategorijaInsertRequest()
            {
                Naziv = _naziv
            });
            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");

        }

        public async Task PrikazKategorije()
        {
            var list = await _service.Get<IEnumerable<Kategorija>>(null);
            KategorijaList.Clear();
            foreach (var kategorija in list)
            {
                KategorijaList.Add(kategorija);
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
