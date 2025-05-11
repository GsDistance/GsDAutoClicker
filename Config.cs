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
        public string clickType { get; set; } = "Left";
        public string clickMode { get; set; } = "Single";
        public decimal interval1 { get; set; } = 0M;
        public decimal interval2 { get; set; } = 0M;
        public decimal interval3 { get; set; } = 1M;
        public decimal interval4 { get; set; } = 100M;
        public decimal repeats { get; set; } = 1M;
        public int X { get; set; } = 0;
        public int Y { get; set; } = 0;
        public Keys hotKey { get; set; } = Keys.None;
        public bool intervalZeroWarn { get; set; } = true;
        public bool locationWithoutHotkeyWarn { get; set; } = true;
    }
}
