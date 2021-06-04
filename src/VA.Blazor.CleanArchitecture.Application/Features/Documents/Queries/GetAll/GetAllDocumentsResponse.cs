﻿using System;

namespace VA.Blazor.CleanArchitecture.Application.Features.Documents.Queries.GetAll
{
    public class GetAllDocumentsResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string URL { get; set; }
    }
}