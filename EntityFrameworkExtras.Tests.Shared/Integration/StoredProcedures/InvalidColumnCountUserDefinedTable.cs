﻿using System;

#if EF5
using EntityFrameworkExtras.EF5;
#elif EF6
using EntityFrameworkExtras.EF6;
#elif EFCORE
using EntityFrameworkExtras.EFCore;
#endif

namespace EntityFrameworkExtras.Tests.Integration.StoredProcedures
{
    [UserDefinedTableType("AllTypesUDT")]
    public class InvalidColumnCountUserDefinedTable
    {
        
        [UserDefinedTableTypeColumn(1)]
        public String ParameterNvarChar { get; set; }

        [UserDefinedTableTypeColumn(2)]
        public Int64? ParameterBigInt { get; set; }

        [UserDefinedTableTypeColumn(3)]
        public Byte[] ParameterBinary { get; set; }

        [UserDefinedTableTypeColumn(4)]
        public Boolean? ParameterBit { get; set; }

    }
}