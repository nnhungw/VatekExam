﻿using DocumentService.Commons.Communication;

namespace DocumentService.ApiModels.ApiErrorMessages
{
    public static class ApiInternalErrorMessages
    {
        public static ApiErrorMessage DuplicatedCategoryName => new ApiErrorMessage
        {
            Value = "Duplicated category name"
        };

        public static ApiErrorMessage DuplicatedDocumentName => new ApiErrorMessage
        {
            Value = "Duplicated document name"
        };

        public static ApiErrorMessage FileCorrupted => new ApiErrorMessage
        {
            Value = "File corrupted"
        };

        #region Notfound errors
        public static ApiErrorMessage CategoryNotFound => new ApiErrorMessage
        {
            Value = "Category not found"
        };

        public static ApiErrorMessage DocumentNotFound => new ApiErrorMessage
        {
            Value = "Document not found"
        };

        public static ApiErrorMessage PhysicalFileNotFound => new ApiErrorMessage
        {
            Value = "Physical file not found"
        };
        #endregion

        #region Invalid errors
        public static ApiErrorMessage InvalidFileExtension => new ApiErrorMessage
        {
            Value = "Invalid file extension"
        };
        #endregion
    }
}
