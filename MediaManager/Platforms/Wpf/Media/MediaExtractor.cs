﻿using System;
using System.Threading.Tasks;
using MediaManager.Media;

namespace MediaManager.Platforms.Wpf.Media
{
    public class MediaExtractor : MediaExtractorBase, IMediaExtractor
    {
        public override Task<IMediaItem> ExtractMetadata(IMediaItem mediaItem)
        {
            return Task.FromResult(mediaItem);
        }

        public override Task<object> GetVideoFrame(IMediaItem mediaItem, TimeSpan timeFromStart)
        {
            return null;
        }

        public override Task<object> RetrieveMediaItemArt(IMediaItem mediaItem)
        {
            return null;
        }
    }
}
