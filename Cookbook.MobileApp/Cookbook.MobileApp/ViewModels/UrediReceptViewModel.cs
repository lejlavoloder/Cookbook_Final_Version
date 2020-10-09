using Cookbook.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cookbook.MobileApp.ViewModels
{
  public  class UrediReceptViewModel:BaseViewModel
    {
       public Recept recept { get; set; }
      private  APIService _apiSlozenost = new APIService("Slozenost");
      private APIService _apiKategorija = new APIService("Kategorija");
      private APIService _apiGrupaJela = new APIService("GrupaJela");
     public ObservableCollection<Kategorija> KategorijaList { get; set; } = new ObservableCollection<Kategorija>();
     public ObservableCollection<Slozenost> SlozenostList { get; set; } = new ObservableCollection<Slozenost>();
     public ObservableCollection<GrupaJela> GrupaJelaList { get; set; } = new ObservableCollection<GrupaJela>();
      public ICommand UcitajKategorijuCommand { get; set; }
      public ICommand UcitajSlozenostCommand { get; set; }
      public ICommand UcitajGrupuJelaCommand { get; set; }
        public UrediReceptViewModel()
        {
            UcitajKategorijuCommand = new Command(async () => await UcitajKategoriju());
            UcitajSlozenostCommand = new Command(async () => await UcitajSlozenost());
            UcitajGrupuJelaCommand = new Command(async () => await UcitajGrupuJela());
        }
        public async Task UcitajKategoriju()
        {
            var list = await _apiKategorija.Get<List<Kategorija>>(null);
            KategorijaList.Clear();
            foreach (var g in list)
            {
                KategorijaList.Add(g);
            }
        }
        public async Task UcitajSlozenost()
        {
            var list = await _apiSlozenost.Get<List<Slozenost>>(null);
            SlozenostList.Clear();
            foreach (var g in list)
            {
                SlozenostList.Add(g);
            }
        }
        public async Task UcitajGrupuJela()
        {
            var list = await _apiGrupaJela.Get<List<GrupaJela>>(null);
            GrupaJelaList.Clear();
            foreach (var g in list)
            {
                GrupaJelaList.Add(g);
            }
        }

        private byte[] _slika;

        public byte[] Slika
        {
            get { return _slika; }
            set { SetProperty(ref _slika, value); }
        }
    }
}
