using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathofStash
{
    class Account
    {
        string name
        {
            get; set;
        }

        List<Stash> stashes;

        public Account(string name)
        {
            this.name = name;
            stashes = new List<Stash>();
        }
    }
}
