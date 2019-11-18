using System;
using System.Collections.Generic;
using System.Text;
using PassMan.Utils.Models.PassEntry;

namespace PassMan.Utils.Models.Group
{
    public interface IGroup
    {
        string Name  { get; set; }
        string Description { get; set; }
        HashSet<PassEntry.PassEntry> Entries { get; set; }
    }
}
