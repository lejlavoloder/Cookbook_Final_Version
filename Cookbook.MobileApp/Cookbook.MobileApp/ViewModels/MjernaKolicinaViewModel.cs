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
   public class MjernaKolicinaViewModel:BaseViewModel
    {
        public MjernaKolicinaViewModel()
        {
            DodajMjernuKolicinuCommand = new Command(async () => await DodajMjernuKolicinu());
            PrikazMjerneKolicineCommand = new Command(async () => await PrikazMjerneKolicine());
        }
        public ICommand DodajMjernuKolicinuCommand { get; set; }
        public ICommand PrikazMjerneKolicineCommand { get; set; }
        private APIService _service = new APIService("MjernaKolicina");
        public ObservableCollection<MjernaKolicina> MjernaKolicinaList { get; set; } = new ObservableCollection<MjernaKolicina>();
        public async Task DodajMjernuKolicinu()
        {
            IsBusy = true;
            await _service.Insert<MjernaKolicina>(new MjernaKolicinaUpsertRequest()
            {
                Kolicina = _mjernakolicina

            }) ;
            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
        }
        public async Task PrikazMjerneKolicine()
        {
            var list = await _service.Get<IEnumerable<MjernaKolicina>>(null);
            MjernaKolicinaList.Clear();
            foreach (var mjernakolicina in list)
            {
                MjernaKolicinaList.Add(mjernakolicina);
            }
        }
        int _mjernakolicina = 0;
        public int Kolicina
        {
            get { return _mjernakolicina; }
            set { SetProperty(ref _mjernakolicina, value); }
        }
    }
}
