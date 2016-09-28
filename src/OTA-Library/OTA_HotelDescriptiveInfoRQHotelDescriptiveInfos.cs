using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelDescriptiveInfoRQHotelDescriptiveInfos
    {
        
        private List<OTA_HotelDescriptiveInfoRQHotelDescriptiveInfosHotelDescriptiveInfo> _hotelDescriptiveInfo;
        
        private string _langRequested;
        
        public OTA_HotelDescriptiveInfoRQHotelDescriptiveInfos()
        {
            this._hotelDescriptiveInfo = new List<OTA_HotelDescriptiveInfoRQHotelDescriptiveInfosHotelDescriptiveInfo>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("HotelDescriptiveInfo")]
        public List<OTA_HotelDescriptiveInfoRQHotelDescriptiveInfosHotelDescriptiveInfo> HotelDescriptiveInfo
        {
            get
            {
                return this._hotelDescriptiveInfo;
            }
            set
            {
                this._hotelDescriptiveInfo = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string LangRequested
        {
            get
            {
                return this._langRequested;
            }
            set
            {
                this._langRequested = value;
            }
        }
    }
}