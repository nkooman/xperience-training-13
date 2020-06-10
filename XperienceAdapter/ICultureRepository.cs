﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Abstractions;

namespace XperienceAdapter
{
    public interface ICultureRepository : IRepository<SiteCulture>
    {
        SiteCulture GetByExactIsoCode(string isoCode);

        SiteCulture GetDefault();
    }
}
