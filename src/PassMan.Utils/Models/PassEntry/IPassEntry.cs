using System;
using System.Collections.Generic;
using System.Text;

namespace PassMan.Utils.Models.PassEntry
{
    public interface IPassEntry
    {
        Guid Id { get; set; }
        string Name { get; set; }
        string Description { get; set; }
        string EncryptedValue { get; set; }
    }
}
