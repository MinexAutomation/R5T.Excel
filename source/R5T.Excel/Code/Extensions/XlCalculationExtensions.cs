﻿using System;

using Xl = Microsoft.Office.Interop.Excel;

using R5T.NetStandard;


namespace R5T.Excel
{
    public static class XlCalculationExtensions
    {
        public static ExcelCalculationMode ToExcelCalculationMode(this Xl.XlCalculation xlCalculation)
        {
            switch(xlCalculation)
            {
                case Xl.XlCalculation.xlCalculationAutomatic:
                    return ExcelCalculationMode.Automatic;

                case Xl.XlCalculation.xlCalculationManual:
                    return ExcelCalculationMode.Manual;

                case Xl.XlCalculation.xlCalculationSemiautomatic:
                    return ExcelCalculationMode.SemiAutomatic;

                default:
                    throw new ArgumentException(EnumHelper.UnexpectedEnumerationValueMessage(xlCalculation), nameof(xlCalculation));
            }
        }
    }
}
