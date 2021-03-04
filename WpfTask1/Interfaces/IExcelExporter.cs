﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfTask1.Models;

namespace WpfTask1.Interfaces
{
    interface IExcelExporter<T> where T : class
    {
        void ExcelExport(ICollection<T> items);
    }
}
