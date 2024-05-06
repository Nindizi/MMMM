using CommunityToolkit.Mvvm.Input;
using MMMM_Gui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MMMM_Gui.ViewModels
{
    public class AddModViewModel
    {
        public ICommand AddModCommand { get; set; }

        public string? VMModName {  get; set; }
        public double? VMModVersion { get; set; }
        public DateOnly? VMDownloadDate { get; set; }

        public AddModViewModel()
        {
            
        }

        private bool CanAddMod()
        {
            return true;
        }

        private void AddMod(Object obl)
        {
            ModManager.AddMod(new Mod() {_ModName = VMModName, _Version = VMModVersion, _DownloadDate = VMDownloadDate });
        }

    }
}
