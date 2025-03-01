﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using static Azure.Storage.DataMovement.DataMovementConstants;

namespace Azure.Storage.DataMovement.Blobs
{
    internal class DataMovementBlobConstants
    {
        internal class ResourceId
        {
            internal const string BlockBlob = "BlockBlob";
            internal const string PageBlob = "PageBlob";
            internal const string AppendBlob = "AppendBlob";
        }

        internal class SourceCheckpointData
        {
            internal const int SchemaVersion = 2;

            internal const int VersionIndex = 0;
            internal const int DataSize = VersionIndex + OneByte;
        }

        internal class DestinationCheckpointData
        {
            internal const int SchemaVersion = 2;

            internal const int VersionIndex = 0;
            internal const int PreserveBlobTypeIndex = VersionIndex + IntSizeInBytes;
            internal const int BlobTypeIndex = PreserveBlobTypeIndex + OneByte;
            internal const int PreserveContentTypeIndex = BlobTypeIndex + OneByte;
            internal const int ContentTypeOffsetIndex = PreserveContentTypeIndex + OneByte;
            internal const int ContentTypeLengthIndex = ContentTypeOffsetIndex + IntSizeInBytes;

            internal const int PreserveContentEncodingIndex = ContentTypeLengthIndex + IntSizeInBytes;
            internal const int ContentEncodingOffsetIndex = PreserveContentEncodingIndex + OneByte;
            internal const int ContentEncodingLengthIndex = ContentEncodingOffsetIndex + IntSizeInBytes;

            internal const int PreserveContentLanguageIndex = ContentEncodingLengthIndex + IntSizeInBytes;
            internal const int ContentLanguageOffsetIndex = PreserveContentLanguageIndex + OneByte;
            internal const int ContentLanguageLengthIndex = ContentLanguageOffsetIndex + IntSizeInBytes;

            internal const int PreserveContentDispositionIndex = ContentLanguageLengthIndex + IntSizeInBytes;
            internal const int ContentDispositionOffsetIndex = PreserveContentDispositionIndex + OneByte;
            internal const int ContentDispositionLengthIndex = ContentDispositionOffsetIndex + IntSizeInBytes;

            internal const int PreserveCacheControlIndex = ContentDispositionLengthIndex + IntSizeInBytes;
            internal const int CacheControlOffsetIndex = PreserveCacheControlIndex + OneByte;
            internal const int CacheControlLengthIndex = CacheControlOffsetIndex + IntSizeInBytes;

            internal const int AccessTierValueIndex = CacheControlLengthIndex + IntSizeInBytes;

            internal const int PreserveMetadataIndex = AccessTierValueIndex + OneByte;
            internal const int MetadataOffsetIndex = PreserveMetadataIndex + OneByte;
            internal const int MetadataLengthIndex = MetadataOffsetIndex + IntSizeInBytes;

            internal const int PreserveTagsIndex = MetadataLengthIndex + IntSizeInBytes;
            internal const int TagsOffsetIndex = PreserveTagsIndex + OneByte;
            internal const int TagsLengthIndex = TagsOffsetIndex + IntSizeInBytes;
            internal const int VariableLengthStartIndex = TagsLengthIndex + IntSizeInBytes;
        }
    }
}
