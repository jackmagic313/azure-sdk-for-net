// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.AI.DocumentTranslation
{
    /// <summary> The DocumentStatusDetail. </summary>
    public partial class DocumentStatusResult
    {
        /// <summary> Initializes a new instance of DocumentStatusResult. </summary>
        /// <param name="sourceDocumentUri"> Location of the source document. </param>
        /// <param name="createdOn"> Operation created date time. </param>
        /// <param name="lastModified"> Date time in which the operation&apos;s status has been updated. </param>
        /// <param name="status"> List of possible statuses for job or document. </param>
        /// <param name="translateTo"> To language. </param>
        /// <param name="progress"> Progress of the translation if available. </param>
        /// <param name="documentId"> Document Id. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="sourceDocumentUri"/>, <paramref name="translateTo"/>, or <paramref name="documentId"/> is null. </exception>
        internal DocumentStatusResult(Uri sourceDocumentUri, DateTimeOffset createdOn, DateTimeOffset lastModified, TranslationStatus status, string translateTo, float progress, string documentId)
        {
            if (sourceDocumentUri == null)
            {
                throw new ArgumentNullException(nameof(sourceDocumentUri));
            }
            if (translateTo == null)
            {
                throw new ArgumentNullException(nameof(translateTo));
            }
            if (documentId == null)
            {
                throw new ArgumentNullException(nameof(documentId));
            }

            SourceDocumentUri = sourceDocumentUri;
            CreatedOn = createdOn;
            LastModified = lastModified;
            Status = status;
            TranslateTo = translateTo;
            Progress = progress;
            DocumentId = documentId;
        }

        /// <summary> Initializes a new instance of DocumentStatusResult. </summary>
        /// <param name="translatedDocumentUri"> Location of the document or folder. </param>
        /// <param name="sourceDocumentUri"> Location of the source document. </param>
        /// <param name="createdOn"> Operation created date time. </param>
        /// <param name="lastModified"> Date time in which the operation&apos;s status has been updated. </param>
        /// <param name="status"> List of possible statuses for job or document. </param>
        /// <param name="translateTo"> To language. </param>
        /// <param name="error"> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </param>
        /// <param name="progress"> Progress of the translation if available. </param>
        /// <param name="documentId"> Document Id. </param>
        /// <param name="charactersCharged"> Character charged by the API. </param>
        internal DocumentStatusResult(Uri translatedDocumentUri, Uri sourceDocumentUri, DateTimeOffset createdOn, DateTimeOffset lastModified, TranslationStatus status, string translateTo, DocumentTranslationError error, float progress, string documentId, long charactersCharged)
        {
            TranslatedDocumentUri = translatedDocumentUri;
            SourceDocumentUri = sourceDocumentUri;
            CreatedOn = createdOn;
            LastModified = lastModified;
            Status = status;
            TranslateTo = translateTo;
            Error = error;
            Progress = progress;
            DocumentId = documentId;
            CharactersCharged = charactersCharged;
        }
        /// <summary> List of possible statuses for job or document. </summary>
        public TranslationStatus Status { get; }
        /// <summary> This contains an outer error with error code, message, details, target and an inner error with more descriptive details. </summary>
        public DocumentTranslationError Error { get; }
    }
}
