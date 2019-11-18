using System;
using System.Collections.Generic;
using System.Text;
using PassMan.Utils.Models.PassEntry;

namespace PassMan.Utils.Models.Group
{
    public class Group : IGroup
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public HashSet<PassEntry.PassEntry> Entries { get; set; }
    }
}
