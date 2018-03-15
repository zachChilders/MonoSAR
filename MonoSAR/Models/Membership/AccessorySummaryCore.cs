﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonoSAR.Models.Membership
{
    public abstract class AccessorySummaryCore
    {

        public String Title { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Expiration { get; set; }
        public Int32 RankOrder { get; set; }

        public String IssuedPretty { get { return Issued.ToShortDateString(); } }
        public String ExpirationPretty { get { return Expiration.ToShortDateString(); } }

        public Boolean IsExpired
        {
            get
            {
                if (Expiration > DateTime.Now)
                { return true; }

                return false;
            }
        }
    }
}
