using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mumos.ViewModels
{
    public class InputData
    {
        public string Title { get; set; }

        public ICollection<InputTech> Technologies { get; set; }
    }
}
