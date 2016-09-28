using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAvailRQCoreTypeVendorPrefs
    {
        
        private List<VehicleAvailRQCoreTypeVendorPrefsVendorPref> _vendorPref;
        
        private string _participationLevelCode;
        
        private string _locationCategory;
        
        public VehicleAvailRQCoreTypeVendorPrefs()
        {
            this._vendorPref = new List<VehicleAvailRQCoreTypeVendorPrefsVendorPref>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("VendorPref")]
        public List<VehicleAvailRQCoreTypeVendorPrefsVendorPref> VendorPref
        {
            get
            {
                return this._vendorPref;
            }
            set
            {
                this._vendorPref = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ParticipationLevelCode
        {
            get
            {
                return this._participationLevelCode;
            }
            set
            {
                this._participationLevelCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string LocationCategory
        {
            get
            {
                return this._locationCategory;
            }
            set
            {
                this._locationCategory = value;
            }
        }
    }
}