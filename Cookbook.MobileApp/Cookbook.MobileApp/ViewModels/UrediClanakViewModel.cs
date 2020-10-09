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
  public class UrediClanakViewModel
    {
        public Clanak clanak { get; set; }
        private APIService vrstaclanka = new APIService("VrstaClanka");
        public ObservableCollection<VrstaClanka> VrstaClankaList { get; set; } = new ObservableCollection<VrstaClanka>();
        public ICommand InitCommand { get; set; }

        public UrediClanakViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }
        public async Task Init()
        {
            var list = await vrstaclanka.Get<List<VrstaClanka>>(null);
            VrstaClankaList.Clear();
            foreach (var g in list)
            {
                VrstaClankaList.Add(g);
            }
        }
    }
}
