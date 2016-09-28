using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VideoItemsType
    {
        
        private List<VideoItemsTypeVideoItem> _videoItem;
        
        public VideoItemsType()
        {
            this._videoItem = new List<VideoItemsTypeVideoItem>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VideoItem")]
        public List<VideoItemsTypeVideoItem> VideoItem
        {
            get
            {
                return this._videoItem;
            }
            set
            {
                this._videoItem = value;
            }
        }
    }
}