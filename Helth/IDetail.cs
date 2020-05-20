using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helth
{
    interface IDetail
    {
        string Kegiatan { get; set; }
        string Lokasi { get; set; }
        string Deskripsi { get; set; }
    }
}
