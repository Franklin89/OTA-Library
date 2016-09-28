using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RoomStayTypeRoomRates
    {
        
        private List<RoomStayTypeRoomRatesRoomRate> _roomRate;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _moreRatesExistInd;
        
        public RoomStayTypeRoomRates()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._roomRate = new List<RoomStayTypeRoomRatesRoomRate>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("RoomRate")]
        public List<RoomStayTypeRoomRatesRoomRate> RoomRate
        {
            get
            {
                return this._roomRate;
            }
            set
            {
                this._roomRate = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool MoreRatesExistInd
        {
            get
            {
                return this._moreRatesExistInd;
            }
            set
            {
                this._moreRatesExistInd = value;
            }
        }
    }
}