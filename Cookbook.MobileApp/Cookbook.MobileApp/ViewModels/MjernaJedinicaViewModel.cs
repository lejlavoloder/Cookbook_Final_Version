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
    public class MjernaJedinicaViewModel : BaseViewModel
    {
        public MjernaJedinicaViewModel()
        {
            DodajMjernuJedinicuCommand = new Command(async () => await DodajMjernuJedinicu());
            PrikazMjerneJediniceCommand = new Command(async () => await PrikazMjerneJedinice());
        }
        public ICommand DodajMjernuJedinicuCommand { get; set; }
        public ICommand PrikazMjerneJediniceCommand { get; set; }
        public ICommand InitCommand { get; set; }

        private APIService _service = new APIService("MjernaJedinica");
        public ObservableCollection<MjernaJedinica> MjernaJedinicaList { get; set; } = new ObservableCollection<MjernaJedinica>();

        public MjernaJedinica mjernajedinica { get; set; }
        public async Task DodajMjernuJedinicu()
        {
            IsBusy = true;
            await _service.Insert<MjernaJedinica>(new MjernaJedinicaInsertRequest()
            {
                Naziv = _naziv
            });
            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");

        }
        public async Task PrikazMjerneJedinice()
        {
            var list = await _service.Get<IEnumerable<MjernaJedinica>>(null);
            MjernaJedinicaList.Clear();
            foreach (var mjernajedinica in list)
            {
                MjernaJedinicaList.Add(mjernajedinica);
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