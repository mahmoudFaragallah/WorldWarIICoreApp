﻿using System;
using System.Collections.Generic;
using System.Text;

namespace WorldWarIIApp.Domain
{
    public class Battle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Solider> Soliders { get; set; }

    }
}
