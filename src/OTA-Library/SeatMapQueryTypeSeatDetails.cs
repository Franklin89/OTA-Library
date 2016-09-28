using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SeatMapQueryTypeSeatDetails
    {
        
        private List<SeatMapQueryTypeSeatDetailsCabinClass> _cabinClass;
        
        private List<SeatMapQueryTypeSeatDetailsResBookDesignation> _resBookDesignations;
        
        private FareBasisCodeType _fareBasisCode;
        
        private bool _seatUpgradeInd;
        
        public SeatMapQueryTypeSeatDetails()
        {
            this._fareBasisCode = new FareBasisCodeType();
            this._resBookDesignations = new List<SeatMapQueryTypeSeatDetailsResBookDesignation>();
            this._cabinClass = new List<SeatMapQueryTypeSeatDetailsCabinClass>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("CabinClass")]
        public List<SeatMapQueryTypeSeatDetailsCabinClass> CabinClass
        {
            get
            {
                return this._cabinClass;
            }
            set
            {
                this._cabinClass = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("ResBookDesignation", IsNullable=false)]
        public List<SeatMapQueryTypeSeatDetailsResBookDesignation> ResBookDesignations
        {
            get
            {
                return this._resBookDesignations;
            }
            set
            {
                this._resBookDesignations = value;
            }
        }
        
        public FareBasisCodeType FareBasisCode
        {
            get
            {
                return this._fareBasisCode;
            }
            set
            {
                this._fareBasisCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool SeatUpgradeInd
        {
            get
            {
                return this._seatUpgradeInd;
            }
            set
            {
                this._seatUpgradeInd = value;
            }
        }
    }
}