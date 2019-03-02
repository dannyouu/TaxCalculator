﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaxCalculator.Logic.Models;

namespace TaxCalculator.Logic.Interface
{
    public interface ITax
    {
        List<Taxes> ApplicableTaxes { get; set; }
    }
}
