﻿using VA.Blazor.CleanArchitecture.Application.Interfaces.Repositories;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Services;
using VA.Blazor.CleanArchitecture.Domain.Entities.Catalog;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using VA.Blazor.CleanArchitecture.Application.Extensions;
using VA.Blazor.CleanArchitecture.Application.Specifications;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;

namespace VA.Blazor.CleanArchitecture.Application.Features.Products.Queries.Export
{
    public class ExportProductsQuery : IRequest<string>
    {
        public string SearchString { get; set; }

        public ExportProductsQuery(string searchString = "")
        {
            SearchString = searchString;
        }
    }

    internal class ExportProductsQueryHandler : IRequestHandler<ExportProductsQuery, string>
    {
        private readonly IExcelService _excelService;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IStringLocalizer<ExportProductsQueryHandler> _localizer;

        public ExportProductsQueryHandler(IExcelService excelService
            , IUnitOfWork unitOfWork
            , IStringLocalizer<ExportProductsQueryHandler> localizer)
        {
            _excelService = excelService;
            _unitOfWork = unitOfWork;
            _localizer = localizer;
        }

        public async Task<string> Handle(ExportProductsQuery request, CancellationToken cancellationToken)
        {
            var productFilterSpec = new ProductFilterSpecification(request.SearchString);
            var products = await _unitOfWork.Repository<Product>().Entities
                .Specify(productFilterSpec)
                .ToListAsync( cancellationToken);
            var data = await _excelService.ExportAsync(products, mappers: new Dictionary<string, Func<Product, object>>
            {
                { _localizer["Id"], item => item.Id },
                { _localizer["Name"], item => item.Name },
                { _localizer["Barcode"], item => item.Barcode },
                { _localizer["Description"], item => item.Description },
                { _localizer["Rate"], item => item.Rate }
            }, sheetName: _localizer["Products"]);

            return data;
        }
    }
}