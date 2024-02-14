using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMMM_Gui.Models
{
    public class Mod
    {
        /// <summary>
        /// Name of the mod
        /// </summary>
        public string? ModName { get; set; }

        /// <summary>
        /// Version of mod
        /// </summary>
        public double? Version { get; set; }

        /// <summary>
        /// Date mod was downloaded
        /// </summary>
        public DateOnly? DownloadDate { get; set; }
    }
}
