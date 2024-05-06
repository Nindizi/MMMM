using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMMM_Gui.Models
{
    public class Mod
    {
        public Mod()
        {

        }

        /// <summary>
        /// Name of the mod
        /// </summary>
        public string? _ModName { get; set; }

        /// <summary>
        /// Version of mod
        /// </summary>
        public double? _Version { get; set; }

        /// <summary>
        /// Date mod was downloaded
        /// </summary>
        public DateOnly? _DownloadDate { get; set; }
    }
}
