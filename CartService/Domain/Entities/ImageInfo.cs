﻿using CartService.Domain.Common;
using System;
using System.Collections.Generic;

namespace CartService.Domain.Entities
{
    public class ImageInfo : ValueObject
    {
        public string Url { get; }
        public string AltText { get; }

        public ImageInfo(string url, string altText)
        {
            Url = url;
            AltText = altText;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Url;
            yield return AltText;
        }
    }
}