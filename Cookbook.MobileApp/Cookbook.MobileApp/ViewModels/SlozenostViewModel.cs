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
   public class SlozenostViewModel:BaseViewModel
    {
        public SlozenostViewModel()
        {

            DodajSlozenostCommand = new Command(async () => await DodajSlozenost());
            PrikazSlozenostiCommand = new Command(async () => await PrikazSlozenosti());
        }
        public ICommand DodajSlozenostCommand { get; set; }
        public ICommand PrikazSlozenostiCommand { get; set; }
        public ICommand InitCommand { get; set; }

        private APIService _service = new APIService("Slozenost");
        public ObservableCollection<Slozenost> SlozenostList { get; set; } = new ObservableCollection<Slozenost>();
        public async Task DodajSlozenost()
        {
            IsBusy = true;
            await _service.Insert<Slozenost>(new SlozenostUpsertRequest()
            {
                Naziv = _naziv,
                Opis = _opis
            });
            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
        }
        public async Task PrikazSlozenosti()
        {
            var list = await _service.Get<IEnumerable<Slozenost>>(null);
            SlozenostList.Clear();
            foreach (var slozenost in list)
            {
                SlozenostList.Add(slozenost);
            }
        }
        string _naziv = string.Empty;
        string _opis = string.Empty;
        public string Opis
        {
            get { return _opis; }
            set { SetProperty(ref _opis, value); }
        }
        public string Naziv
        {
            get { return _naziv; }
            set { SetProperty(ref _naziv, value); }
        }
    }
}
