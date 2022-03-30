using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceMethodKullanimi
{
    internal interface IDatabase
    {
        string DatabaseName { get; set; }
        string Company { get; set; }
        void Create();
        void Read();
        void Update();
        void Delete();
    }
}
