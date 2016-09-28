using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleVendorAvailabilityTypeVehAvails
    {
        
        private List<VehicleVendorAvailabilityTypeVehAvailsVehAvail> _vehAvail;
        
        private string _rateCategory;
        
        private RateQualifierTypeRatePeriod _ratePeriod;
        
        public VehicleVendorAvailabilityTypeVehAvails()
        {
            this._vehAvail = new List<VehicleVendorAvailabilityTypeVehAvailsVehAvail>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VehAvail")]
        public List<VehicleVendorAvailabilityTypeVehAvailsVehAvail> VehAvail
        {
            get
            {
                return this._vehAvail;
            }
            set
            {
                this._vehAvail = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string RateCategory
        {
            get
            {
                return this._rateCategory;
            }
            set
            {
                this._rateCategory = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RateQualifierTypeRatePeriod RatePeriod
        {
            get
            {
                return this._ratePeriod;
            }
            set
            {
                this._ratePeriod = value;
            }
        }
    }
}