using AutoMapper;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Repositories;
using VA.Blazor.CleanArchitecture.Application.Interfaces.Services;
using VA.Blazor.CleanArchitecture.Application.Requests;
using VA.Blazor.CleanArchitecture.Domain.Entities;
using VA.Blazor.CleanArchitecture.Shared.Wrapper;
using MediatR;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;

namespace VA.Blazor.CleanArchitecture.Application.Features.Documents.Commands.AddEdit
{
    public partial class AddEditDocumentCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public bool IsPublic { get; set; } = false;
        [Required]
        public string URL { get; set; }
        public UploadRequest UploadRequest { get; set; }
    }

    internal class AddEditDocumentCommandHandler : IRequestHandler<AddEditDocumentCommand, Result<int>>
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IUploadService _uploadService;
        private readonly IStringLocalizer<AddEditDocumentCommandHandler> _localizer;

        public AddEditDocumentCommandHandler(IUnitOfWork unitOfWork, IMapper mapper, IUploadService uploadService, IStringLocalizer<AddEditDocumentCommandHandler> localizer)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _uploadService = uploadService;
            _localizer = localizer;
        }

        public async Task<Result<int>> Handle(AddEditDocumentCommand command, CancellationToken cancellationToken)
        {
            var uploadRequest = command.UploadRequest;
            if (uploadRequest != null)
            {
                uploadRequest.FileName = $"D-{Guid.NewGuid()}{uploadRequest.Extension}";
            }

            if (command.Id == 0)
            {
                var doc = _mapper.Map<DocumentFile>(command);
                if (uploadRequest != null)
                {
                    doc.URL = _uploadService.UploadAsync(uploadRequest);
                }
                await _unitOfWork.Repository<DocumentFile>().AddAsync(doc);
                await _unitOfWork.Commit(cancellationToken);
                return await Result<int>.SuccessAsync(doc.Id, _localizer["Document Saved"]);
            }
            else
            {
                var doc = await _unitOfWork.Repository<DocumentFile>().GetByIdAsync(command.Id);
                if (doc != null)
                {
                    doc.Title = command.Title ?? doc.Title;
                    doc.Description = command.Description ?? doc.Description;
                    doc.IsPublic = command.IsPublic;
                    if (uploadRequest != null)
                    {
                        doc.URL = _uploadService.UploadAsync(uploadRequest);
                    }
                    await _unitOfWork.Repository<DocumentFile>().UpdateAsync(doc);
                    await _unitOfWork.Commit(cancellationToken);
                    return await Result<int>.SuccessAsync(doc.Id, _localizer["Document Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Document Not Found!"]);
                }
            }
        }
    }
}