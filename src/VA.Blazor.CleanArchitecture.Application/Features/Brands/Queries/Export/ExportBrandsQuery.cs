﻿using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Extensions;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Repositories;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Services;
using VA.Blazor.CleanArchitecture.Application.Specifications;
using VA.Blazor.CleanArchitecture.Domain.Entities.Catalog;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace VA.Blazor.CleanArchitecture.Application.Features.Brands.Queries.Export
{
    public class ExportBrandsQuery : IRequest<string>
    {
        public string SearchString { get; set; }

        public ExportBrandsQuery(string searchString = "")
        {
            SearchString = searchString;
        }
    }

    internal class ExportBrandsQueryHandler : IRequestHandler<ExportBrandsQuery, string>
    {
        private readonly IExcelService _excelService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<ExportBrandsQueryHandler> _localizer;

        public ExportBrandsQueryHandler(IExcelService excelService
            , IUnitOfWork unitOfWork
            , IStringLocalizer<ExportBrandsQueryHandler> localizer)
        {
            _excelService = excelService;
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<string> Handle(ExportBrandsQuery request, CancellationToken cancellationToken)
        {
            var brandFilterSpec = new BrandFilterSpecification(request.SearchString);
            var brands = await _unitOfWork.Repository<Brand>().Entities
                .Specify(brandFilterSpec)
                .ToListAsync(cancellationToken);
            var data = await _excelService.ExportAsync(brands, mappers: new Dictionary<string, Func<Brand, object>>
            {
                { _localizer["Id"], item => item.Id },
                { _localizer["Name"], item => item.Name },
                { _localizer["Description"], item => item.Description },
                { _localizer["Tax"], item => item.Tax }
            }, sheetName: _localizer["Brands"]);

            return data;
        }
    }
}
