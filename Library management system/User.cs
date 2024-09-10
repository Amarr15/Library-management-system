using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_management_system
{
    internal abstract class User
    {
        public string Name { get; set; }

        public void Displaybooks(Library library)
        {
            library.display();
        }
    }
}
