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
    public class OcijeniReceptViewModel:BaseViewModel
    {
        APIService _apiocjena = new APIService("Ocjena");
        APIService _apirecept = new APIService("Recept");
        APIService _apiposjetilac = new APIService("Posjetilac");

        public Recept recept { get; set; }
        public Ocjena ocjena { get; set; }
        public ObservableCollection<Recept> ReceptList { get; set; } = new ObservableCollection<Recept>();
        public ObservableCollection<Posjetilac> PosjetilacList { get; set; } = new ObservableCollection<Posjetilac>();
        public OcijeniReceptViewModel()
        {
            InitCommand = new Command(async () => await DodajOcjenu());
        }
        decimal _ocjena = 0;
        public decimal Ocjena
        {
            get { return _ocjena; }
            set { SetProperty(ref _ocjena, value); }
        }

        int _receptId = 0;
        public int ReceptId
        {
            get { return _receptId; }
            set { SetProperty(ref _receptId, value); }
        }

        int _posjetilacId = 0;

        public int PosjetilacId
        {
            get { return _posjetilacId; }
            set { SetProperty(ref _posjetilacId, value); }
        }
        public ICommand InitCommand { get; set; }
        public async Task Init()
        {
            Posjetilac posjetilac = new Posjetilac();
            var username = APIService.Username;
            List<Posjetilac> lista = await _apiposjetilac.Get<List<Posjetilac>>(null);
            foreach (var posjetilac1 in lista)
            {
                if (posjetilac1.KorisnickoIme == username)
                {
                    posjetilac = posjetilac1;
                    break;
                }
            }
            var req = new OcjenaSearchRequest
            {
                ReceptId = recept.ReceptId,
                PosjetilacId = posjetilac.PosjetilacId
            };
            var ocjene = await _apiocjena.Get<List<Ocjena>>(req);
            if (ocjene != null && ocjene.Count > 0)
            {
                ocjena = ocjene[0];
                Ocjena = ocjena.ocjena;
            }
        }

        public async Task DodajOcjenu()
        {
            IsBusy = true;
            if (ocjena != null)
            {
                await _apiocjena.Delete<Ocjena>(ocjena.OcjenaId);
            }

            ocjena = await _apiocjena.Insert<Ocjena>(new OcjenaUpsertRequest()
            {
                ocjena = _ocjena,
                PosjetilacId =_posjetilacId,
                ReceptId = _receptId
            });
            await Application.Current.MainPage.DisplayAlert(" ", "Uspješno sačuvani podaci", "OK");
        }

    }

}
