using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleAgeRequirementsTypeAge
    {
        
        private List<VehicleAgeRequirementsTypeAgeAgeSurcharge> _ageSurcharge;
        
        private List<VehicleAgeRequirementsTypeAgeAgeInfo> _ageInfos;
        
        private List<VehicleAgeRequirementsTypeAgeVehicle> _vehicles;
        
        private string _minimumAge;
        
        private string _maximumAge;
        
        public VehicleAgeRequirementsTypeAge()
        {
            this._vehicles = new List<VehicleAgeRequirementsTypeAgeVehicle>();
            this._ageInfos = new List<VehicleAgeRequirementsTypeAgeAgeInfo>();
            this._ageSurcharge = new List<VehicleAgeRequirementsTypeAgeAgeSurcharge>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("AgeSurcharge")]
        public List<VehicleAgeRequirementsTypeAgeAgeSurcharge> AgeSurcharge
        {
            get
            {
                return this._ageSurcharge;
            }
            set
            {
                this._ageSurcharge = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("AgeInfo", IsNullable=false)]
        public List<VehicleAgeRequirementsTypeAgeAgeInfo> AgeInfos
        {
            get
            {
                return this._ageInfos;
            }
            set
            {
                this._ageInfos = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Vehicle", IsNullable=false)]
        public List<VehicleAgeRequirementsTypeAgeVehicle> Vehicles
        {
            get
            {
                return this._vehicles;
            }
            set
            {
                this._vehicles = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MinimumAge
        {
            get
            {
                return this._minimumAge;
            }
            set
            {
                this._minimumAge = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string MaximumAge
        {
            get
            {
                return this._maximumAge;
            }
            set
            {
                this._maximumAge = value;
            }
        }
    }
}