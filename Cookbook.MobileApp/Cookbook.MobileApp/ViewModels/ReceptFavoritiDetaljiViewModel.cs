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
    public class ReceptFavoritiDetaljiViewModel : BaseViewModel
    {
        public Favoriti favoriti { get; set; }
        public APIService _apiRecept = new APIService("Recept");
        public APIService _apiReceptSastojak = new APIService("ReceptSastojak");
        
        public ReceptFavoritiDetaljiViewModel(Recept r, Favoriti f) : base()
        {
            recept = r;
            favoriti = f; 
            InitCommand = new Command(async () => await Init());
        }
        public ReceptFavoritiDetaljiViewModel()
        {
           
        }
        public ICommand InitCommand { get; set; }
        public ObservableCollection<ReceptSastojak> ReceptSastojakList { get; set; } = new ObservableCollection<ReceptSastojak>();
        public Recept recept { get; set; } = new Recept();
        public string Naziv => recept.Naziv;
        public string Slozenost => recept.Slozenost;
        public string GrupaJela => recept.GrupaJela;
        public string Kategorija => recept.Kategorija;
        public byte [] Slika => recept.Slika;
        public int BrojLjudi => recept.BrojLjudi;
        public double VrijemeKuhanja => recept.VrijemeKuhanja;
        public double VrijemePripreme => recept.VrijemePripreme;
        public string Tekst => recept.Tekst;
        public async Task Init()
        {
           
            var receptsastojci = await _apiReceptSastojak.Get<IEnumerable<ReceptSastojak>>(null);
            ReceptSastojakList.Clear();
            foreach (var sastojci in receptsastojci)
            {
                if (sastojci.ReceptId==favoriti.ReceptId)
                {
                    ReceptSastojakList.Add(sastojci);
                }
            }
            
        }
    }
}
