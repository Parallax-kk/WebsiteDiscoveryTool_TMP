using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace WebsiteDiscoveryTool
{
    public class ImageData
    {
        [JsonIgnore]
        public Image Image { get; set; } = null;
        public string ByteImage { get; set; } = "";
        public string Path { get; set; } = "";
        public Guid Guid { get; set; } = new Guid();
    }

    public class PageData
    {
        public Guid GUID { get; set; } = new Guid();
        public Guid Parent  { get; set; } = Guid.Empty;
        public string PageName { get; set; } = "";
        public string URL { get; set; } = "";
        public string SearchWord { get; set; } = "";
        public int Index { get; set; } = 0;
        public int MaxIndex { get; set; } = 0;
        public int Level { get; set; } = 0;
        public List<ImageData> ImageData { get; set; } = new List<ImageData>();
        public string Memo { get; set; } = "";
    }
}