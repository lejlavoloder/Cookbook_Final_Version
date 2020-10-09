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
  public class VrstaClankaViewModel:BaseViewModel
    {
        public VrstaClankaViewModel()
        {
            DodajVrstuClankaCommand = new Command(async () => await DodajVrstuClanka());
            PrikazVrsteClankaCommand = new Command(async () => await PrikazVrsteClanka());
        }
        public ICommand DodajVrstuClankaCommand { get; set; }
        public ICommand PrikazVrsteClankaCommand { get; set; }

        private APIService _service = new APIService("VrstaClanka");
        public ObservableCollection<VrstaClanka> VrstaClankaList { get; set; } = new ObservableCollection<VrstaClanka>();
        public async Task DodajVrstuClanka()
        {
            IsBusy = true;
            await _service.Insert<VrstaClanka>(new VrstaClankaInsertRequest()
            {
                Naziv = _naziv
            });
            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
        }
        public async Task PrikazVrsteClanka()
        {
            var list = await _service.Get<IEnumerable<VrstaClanka>>(null);
            VrstaClankaList.Clear();
            foreach (var vrstaclanka in list)
            {
                VrstaClankaList.Add(vrstaclanka);
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
