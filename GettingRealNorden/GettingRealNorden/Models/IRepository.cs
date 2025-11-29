using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingRealNorden.Models
{
    public interface IRepository
    {
        public string FileName { get; }

        public void InitializeRepo();
    }
}
