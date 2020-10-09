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
    public class GrupaJelaViewModel:BaseViewModel
    {
        public GrupaJelaViewModel()
        {
            DodajGrupuJelaCommand = new Command(async () => await DodajGrupuJela());
            PrikazGrupeJelaCommand = new Command(async () => await PrikazGrupeJela());
        }
        public ICommand DodajGrupuJelaCommand { get; set; }
        public ICommand PrikazGrupeJelaCommand { get; set; }
        public ICommand InitCommand { get; set; }

        private APIService _service = new APIService("GrupaJela");
        public ObservableCollection<GrupaJela> GrupaJelaList{ get; set; } = new ObservableCollection<GrupaJela>();
        public async Task DodajGrupuJela()
        {
            IsBusy = true;
            await _service.Insert<GrupaJela>(new GrupaJelaUpsertRequest()
            {
                Naziv = _naziv,
                Opis=_opis
            });
            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
        }
        public async Task PrikazGrupeJela()
        {
            var list = await _service.Get<IEnumerable<GrupaJela>>(null);
            GrupaJelaList.Clear();
            foreach (var grupajela in list)
            {
                GrupaJelaList.Add(grupajela);
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
