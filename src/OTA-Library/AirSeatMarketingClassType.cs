using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirSeatMarketingClassType
    {
        
        private List<AirSeatMarketingClassTypeCabinInfo> _cabinInfo;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private string _airEquipType;
        
        private string _rPH;
        
        private string _purchasedSeatRPH;
        
        public AirSeatMarketingClassType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._cabinInfo = new List<AirSeatMarketingClassTypeCabinInfo>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CabinInfo")]
        public List<AirSeatMarketingClassTypeCabinInfo> CabinInfo
        {
            get
            {
                return this._cabinInfo;
            }
            set
            {
                this._cabinInfo = value;
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
        public string AirEquipType
        {
            get
            {
                return this._airEquipType;
            }
            set
            {
                this._airEquipType = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RPH
        {
            get
            {
                return this._rPH;
            }
            set
            {
                this._rPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PurchasedSeatRPH
        {
            get
            {
                return this._purchasedSeatRPH;
            }
            set
            {
                this._purchasedSeatRPH = value;
            }
        }
    }
}