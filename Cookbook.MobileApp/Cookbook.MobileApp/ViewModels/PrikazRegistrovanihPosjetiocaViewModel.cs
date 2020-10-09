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
    public class PrikazRegistrovanihPosjetiocaViewModel:BaseViewModel
    {
        public PrikazRegistrovanihPosjetiocaViewModel()
        {
            PrikazPosjetilacaCommand = new Command(async () => await PrikazPosjetilaca());
        }
        public ICommand PrikazPosjetilacaCommand { get; set; }
        private APIService _apiPosjetilac = new APIService("Posjetilac");
        public ObservableCollection<Posjetilac> PosjetilacList { get; set; } = new ObservableCollection<Posjetilac>();
        public async Task PrikazPosjetilaca()
        {
            var list = await _apiPosjetilac.Get<IEnumerable<Posjetilac>>(null);
            PosjetilacList.Clear();
            foreach (var posjetilac in list)
            {
                PosjetilacList.Add(posjetilac);
            }
        }

    }
}
