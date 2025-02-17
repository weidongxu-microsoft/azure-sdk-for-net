// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.StorageSync.Models
{
    /// <summary> Server Endpoint sync status. </summary>
    public partial class ServerEndpointSyncStatus
    {
        /// <summary> Initializes a new instance of ServerEndpointSyncStatus. </summary>
        internal ServerEndpointSyncStatus()
        {
        }

        /// <summary> Initializes a new instance of ServerEndpointSyncStatus. </summary>
        /// <param name="downloadHealth"> Download Health Status. </param>
        /// <param name="uploadHealth"> Upload Health Status. </param>
        /// <param name="combinedHealth"> Combined Health Status. </param>
        /// <param name="syncActivity"> Sync activity. </param>
        /// <param name="totalPersistentFilesNotSyncingCount"> Total count of persistent files not syncing (combined upload + download). </param>
        /// <param name="lastUpdatedTimestamp"> Last Updated Timestamp. </param>
        /// <param name="uploadStatus"> Upload Status. </param>
        /// <param name="downloadStatus"> Download Status. </param>
        /// <param name="uploadActivity"> Upload sync activity. </param>
        /// <param name="downloadActivity"> Download sync activity. </param>
        /// <param name="offlineDataTransferStatus"> Offline Data Transfer State. </param>
        /// <param name="backgroundDataDownloadActivity"> Background data download activity. </param>
        internal ServerEndpointSyncStatus(ServerEndpointHealthState? downloadHealth, ServerEndpointHealthState? uploadHealth, ServerEndpointHealthState? combinedHealth, ServerEndpointSyncActivityState? syncActivity, long? totalPersistentFilesNotSyncingCount, DateTimeOffset? lastUpdatedTimestamp, ServerEndpointSyncSessionStatus uploadStatus, ServerEndpointSyncSessionStatus downloadStatus, ServerEndpointSyncActivityStatus uploadActivity, ServerEndpointSyncActivityStatus downloadActivity, ServerEndpointOfflineDataTransferState? offlineDataTransferStatus, ServerEndpointBackgroundDataDownloadActivity backgroundDataDownloadActivity)
        {
            DownloadHealth = downloadHealth;
            UploadHealth = uploadHealth;
            CombinedHealth = combinedHealth;
            SyncActivity = syncActivity;
            TotalPersistentFilesNotSyncingCount = totalPersistentFilesNotSyncingCount;
            LastUpdatedTimestamp = lastUpdatedTimestamp;
            UploadStatus = uploadStatus;
            DownloadStatus = downloadStatus;
            UploadActivity = uploadActivity;
            DownloadActivity = downloadActivity;
            OfflineDataTransferStatus = offlineDataTransferStatus;
            BackgroundDataDownloadActivity = backgroundDataDownloadActivity;
        }

        /// <summary> Download Health Status. </summary>
        public ServerEndpointHealthState? DownloadHealth { get; }
        /// <summary> Upload Health Status. </summary>
        public ServerEndpointHealthState? UploadHealth { get; }
        /// <summary> Combined Health Status. </summary>
        public ServerEndpointHealthState? CombinedHealth { get; }
        /// <summary> Sync activity. </summary>
        public ServerEndpointSyncActivityState? SyncActivity { get; }
        /// <summary> Total count of persistent files not syncing (combined upload + download). </summary>
        public long? TotalPersistentFilesNotSyncingCount { get; }
        /// <summary> Last Updated Timestamp. </summary>
        public DateTimeOffset? LastUpdatedTimestamp { get; }
        /// <summary> Upload Status. </summary>
        public ServerEndpointSyncSessionStatus UploadStatus { get; }
        /// <summary> Download Status. </summary>
        public ServerEndpointSyncSessionStatus DownloadStatus { get; }
        /// <summary> Upload sync activity. </summary>
        public ServerEndpointSyncActivityStatus UploadActivity { get; }
        /// <summary> Download sync activity. </summary>
        public ServerEndpointSyncActivityStatus DownloadActivity { get; }
        /// <summary> Offline Data Transfer State. </summary>
        public ServerEndpointOfflineDataTransferState? OfflineDataTransferStatus { get; }
        /// <summary> Background data download activity. </summary>
        public ServerEndpointBackgroundDataDownloadActivity BackgroundDataDownloadActivity { get; }
    }
}
