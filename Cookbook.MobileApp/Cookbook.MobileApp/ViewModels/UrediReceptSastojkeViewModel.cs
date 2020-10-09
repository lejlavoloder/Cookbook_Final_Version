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
   public class UrediReceptSastojkeViewModel:BaseViewModel
    {

        public ReceptSastojak receptsastojak { get; set; }
        private APIService _apisastojak = new APIService("Sastojak");
        private APIService _apimjernajedinica = new APIService("MjernaJedinica");
        private APIService _apimjernakolicina = new APIService("MjernaKolicina");
        public ObservableCollection<Sastojak> SastojakList { get; set; } = new ObservableCollection<Sastojak>();
        public ObservableCollection<MjernaKolicina> MjernaKolicinaList { get; set; } = new ObservableCollection<MjernaKolicina>();
        public ObservableCollection<MjernaJedinica> MjernaJedinicaList { get; set; } = new ObservableCollection<MjernaJedinica>();
        public ICommand InitCommand { get; set; }
        public ICommand UcitajKolicinuCommand { get; set; }
        public ICommand UcitajJedinicuCommand { get; set; }
        public UrediReceptSastojkeViewModel()
        {
            InitCommand = new Command(async () => await Init());
            UcitajKolicinuCommand = new Command(async () => await UcitajKolicinu());
            UcitajJedinicuCommand = new Command(async () => await UcitajJedinicu());
        }
        public async Task UcitajKolicinu()
        {
            var list = await _apimjernakolicina.Get<List<MjernaKolicina>>(null);
            MjernaKolicinaList.Clear();
            foreach (var g in list)
            {
                MjernaKolicinaList.Add(g);
            }
        }
        public async Task UcitajJedinicu()
        {
            var list = await _apimjernajedinica.Get<List<MjernaJedinica>>(null);
            MjernaJedinicaList.Clear();
            foreach (var g in list)
            {
                MjernaJedinicaList.Add(g);
            }
        }
        public async Task Init()
        {
            var list = await _apisastojak.Get<List<Sastojak>>(null);
            SastojakList.Clear();
            foreach (var g in list)
            {
                SastojakList.Add(g);
            }
        }
    }
}
