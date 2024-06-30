using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandCShap.entities
{
    public class ClassRoom
    {
        public string room;

        public string Room
        {
            get => room;
            set => room = value ?? throw new ArgumentNullException(nameof(value));
        }

    }
}
