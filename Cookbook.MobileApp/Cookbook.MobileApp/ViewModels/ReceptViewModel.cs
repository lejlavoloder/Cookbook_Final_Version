using Cookbook.Model;
using Cookbook.Model.Requests;
using Cookbook.MobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Windows.Input;
using System.Collections.ObjectModel;
using Cookbook.MobileApp.Views;
namespace Cookbook.MobileApp.ViewModels
{
    public class ReceptViewModel : BaseViewModel
    {
        private readonly APIService _kategorija = new APIService("Kategorija");
        private readonly APIService _slozenost = new APIService("Slozenost");
        private readonly APIService _grupajela = new APIService("GrupaJela");
        private readonly APIService _recept = new APIService("Recept");
        private APIService _korisnik = new APIService("Korisnik");
        public ReceptViewModel()
        {
            PretragaRecepataCommand = new Command(async () => await PretragaRecepata());
            PrikazRecepataCommand = new Command(async () => await PrikazRecepataPage());
        }
        public ICommand PretragaRecepataCommand { get; set; }
        public ICommand PrikazRecepataCommand { get; set; }

        public ObservableCollection<Recept> ReceptList { get; set; } = new ObservableCollection<Recept>();
        public ObservableCollection<Kategorija> KategorijaList { get; set; } = new ObservableCollection<Kategorija>();
        public ObservableCollection<Slozenost> SlozenostList { get; set; } = new ObservableCollection<Slozenost>();
        public ObservableCollection<GrupaJela> GrupaJelaList { get; set; } = new ObservableCollection<GrupaJela>();
        Slozenost _selectedSlozenost = null;
        Kategorija _selectedKategorija = null;
        GrupaJela _selectedGrupaJela = null;
        public Slozenost SelectedSlozenost
        {
            get { return _selectedSlozenost; }
            set
            {
                SetProperty(ref _selectedSlozenost, value);
                if (value != null)
                {
                    PretragaRecepataCommand.Execute(null);
                }
            }
        }
        public Kategorija SelectedKategorija
        {
            get { return _selectedKategorija; }
            set
            {
                SetProperty(ref _selectedKategorija, value);
                if (value != null)
                {
                    PretragaRecepataCommand.Execute(null);
                }

            }
        }
        public GrupaJela SelectedGrupaJela
        {
            get { return _selectedGrupaJela; }
            set
            {
                SetProperty(ref _selectedGrupaJela, value);
                if (value != null)
                {
                    PretragaRecepataCommand.Execute(null);
                }

            }
        }
        public async Task PrikazRecepataPage()
        {
            var list = await _recept.Get<IEnumerable<Recept>>(null);
            ReceptList.Clear();
            foreach (var s in list)
            {
                if (s.Odobren == true)
                {
                    ReceptList.Add(s);
                }
            }
        }
        public async Task PretragaRecepata()
        {
            if (GrupaJelaList.Count() == 0)
            {
                var grupajelalist = await _grupajela.Get<List<GrupaJela>>(null);
                foreach (var i in grupajelalist)
                {

                    GrupaJelaList.Add(i);
                }
            }
            if (KategorijaList.Count() == 0)
            {
                var kategorijalist = await _kategorija.Get<List<Kategorija>>(null);
                foreach (var i in kategorijalist)
                {
                    KategorijaList.Add(i);
                }
            }
            if (SlozenostList.Count() == 0)
            {
                var slozenostlist = await _slozenost.Get<List<Slozenost>>(null);
                foreach (var i in slozenostlist)
                {
                    SlozenostList.Add(i);
                }
            }

            if ((SelectedGrupaJela != null && SelectedKategorija != null) && SelectedSlozenost != null)
            {
                ReceptSearchRequest request = new ReceptSearchRequest()
                {
                    KategorijaId = SelectedKategorija.KategorijaId,
                    GrupaJelaId = _selectedGrupaJela.GrupaJelaId,
                    SlozenostId = _selectedSlozenost.SlozenostId
                };

                var list = await _recept.Get<List<Recept>>(request);
                ReceptList.Clear();
                foreach (var i in list)
                {
                    if (i.Odobren == true)
                    {
                        ReceptList.Add(i);
                    }
                }
            }
        }
    }
}
