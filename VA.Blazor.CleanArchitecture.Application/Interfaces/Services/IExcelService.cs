using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace VA.Blazor.CleanArchitecture.Application.Interfaces.Services
{
    public interface IExcelService
    {
        Task<string> ExportAsync<TData>(IEnumerable<TData> data
            , Dictionary<string, Func<TData, object>> mappers
            , string sheetName = "Sheet1");
    }
}