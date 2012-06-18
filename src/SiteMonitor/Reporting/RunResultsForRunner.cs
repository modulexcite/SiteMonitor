﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SiteMonitor.Reporting
{
    public class RunResultsForRunner
    {
        public RunResultsForRunner()
        {
            this.Entries = new List<Entry>();
        }
        
        public long LowerScale { get; set; }
        public long UpperScale { get; set; }
        public List<Entry> Entries { get; set; }
    }

    public class Entry
    {
        public DateTime RanAt { get; set; }
        public double TimeTaken { get; set; }
    }
}
