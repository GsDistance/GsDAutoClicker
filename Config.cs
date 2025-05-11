using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace GsDAutoClicker
{
    internal class Config
    {
        public Guid uid { get; set; } = Guid.NewGuid();
        public string version { get; set; } = Application.ProductVersion;
    }
}
