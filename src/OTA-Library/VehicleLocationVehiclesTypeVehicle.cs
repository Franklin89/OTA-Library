using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationVehiclesTypeVehicle : VehicleType
    {
        
        private List<FormattedTextType> _text;
        
        private bool _isConfirmableInd;
        
        private DistanceUnitNameType _distanceUnit;
        
        private string _distancePerFuelUnit;
        
        public VehicleLocationVehiclesTypeVehicle()
        {
            this._text = new List<FormattedTextType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Text")]
        public List<FormattedTextType> Text
        {
            get
            {
                return this._text;
            }
            set
            {
                this._text = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool IsConfirmableInd
        {
            get
            {
                return this._isConfirmableInd;
            }
            set
            {
                this._isConfirmableInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DistanceUnitNameType DistanceUnit
        {
            get
            {
                return this._distanceUnit;
            }
            set
            {
                this._distanceUnit = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="integer")]
        public string DistancePerFuelUnit
        {
            get
            {
                return this._distancePerFuelUnit;
            }
            set
            {
                this._distancePerFuelUnit = value;
            }
        }
    }
}