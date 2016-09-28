using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AreaInfoTypeOtherHotels
    {
        
        private List<AreaInfoTypeOtherHotelsOtherHotel> _otherHotel;
        
        private System.DateTime _lastUpdated;
        
        public AreaInfoTypeOtherHotels()
        {
            this._otherHotel = new List<AreaInfoTypeOtherHotelsOtherHotel>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("OtherHotel")]
        public List<AreaInfoTypeOtherHotelsOtherHotel> OtherHotel
        {
            get
            {
                return this._otherHotel;
            }
            set
            {
                this._otherHotel = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public System.DateTime LastUpdated
        {
            get
            {
                return this._lastUpdated;
            }
            set
            {
                this._lastUpdated = value;
            }
        }
    }
}