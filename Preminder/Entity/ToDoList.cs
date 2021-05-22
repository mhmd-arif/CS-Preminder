using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Preminder.Entity
{
    public class ToDoList
    {
        // properties
        public int No { get; set; }
        public string Tugas { get; set; }
        public string Tenggat_Pengumpulan { get; set; }
        public string Keterangan { get; set; }

        // constructor
        public ToDoList() { }
        public ToDoList(int _no, string _tugas, string _tenggat, string _keterangan)
        {
            No = _no;
            Tugas = _tugas;
            Tenggat_Pengumpulan = _tenggat;
            Keterangan = _keterangan;
        }
    }
}
