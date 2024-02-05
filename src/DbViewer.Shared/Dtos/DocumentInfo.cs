﻿using Dawn;

namespace DbViewer.Shared.Dtos
{
    public class DocumentInfo
    {
        public DocumentInfo(DatabaseInfo databaseInfo, string documentId, string revisionId, string dataAsJson, bool isNewDocument = false)
        {
            DatabaseInfo = Guard.Argument(databaseInfo, nameof(databaseInfo))
                  .NotNull()
                  .Value;

            DocumentId = Guard.Argument(documentId, nameof(documentId))
                  .NotNull()
                  .Value;

            RevisionId = Guard.Argument(revisionId, nameof(revisionId))
                  .NotNull()
                  .Value;

            DataAsJson = Guard.Argument(dataAsJson, nameof(dataAsJson))
                  .NotNull()
                  .Value;

            IsNewDocument = isNewDocument;
        }

        public DatabaseInfo DatabaseInfo { get; set; }

        public string DocumentId { get; set; }

        public string RevisionId { get; set; }

        public string DataAsJson { get; set; }
        
        public bool IsNewDocument { get; set; }
    }
}
