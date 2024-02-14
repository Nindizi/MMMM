using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMMM_Gui.Models
{
    public class ModList
    {
        /// <summary>
        /// List of mods
        /// </summary>
        public List<Mod>? ModsList { get; set; }

        /// <summary>
        /// When was the modlist updated
        /// </summary>
        public DateOnly? UpdatedWhen { get; set; }
    }
}
