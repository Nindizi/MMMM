using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMMM_Gui.Models
{
    public class ModManager
    {
        public static ObservableCollection<Mod> _DatabaseUsers = new ObservableCollection<Mod>();

        public static ObservableCollection<Mod> GetMods()
        {
            return _DatabaseUsers;
        } 

        public static void AddMod(Mod mod)
        {
            _DatabaseUsers.Add(mod);
        }

        public static void RemoveMod(Mod mod)
        {
            _DatabaseUsers.Remove(mod);
        }
    }
}
