namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class VehicleLocationAdditionalFeesType
    {
        
        private VehicleLocationAdditionalFeesTypeTaxes _taxes;
        
        private VehicleLocationAdditionalFeesTypeFees _fees;
        
        private VehicleLocationAdditionalFeesTypeSurcharges _surcharges;
        
        private VehicleLocationAdditionalFeesTypeMiscellaneousCharges _miscellaneousCharges;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        public VehicleLocationAdditionalFeesType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._miscellaneousCharges = new VehicleLocationAdditionalFeesTypeMiscellaneousCharges();
            this._surcharges = new VehicleLocationAdditionalFeesTypeSurcharges();
            this._fees = new VehicleLocationAdditionalFeesTypeFees();
            this._taxes = new VehicleLocationAdditionalFeesTypeTaxes();
        }
        
        public VehicleLocationAdditionalFeesTypeTaxes Taxes
        {
            get
            {
                return this._taxes;
            }
            set
            {
                this._taxes = value;
            }
        }
        
        public VehicleLocationAdditionalFeesTypeFees Fees
        {
            get
            {
                return this._fees;
            }
            set
            {
                this._fees = value;
            }
        }
        
        public VehicleLocationAdditionalFeesTypeSurcharges Surcharges
        {
            get
            {
                return this._surcharges;
            }
            set
            {
                this._surcharges = value;
            }
        }
        
        public VehicleLocationAdditionalFeesTypeMiscellaneousCharges MiscellaneousCharges
        {
            get
            {
                return this._miscellaneousCharges;
            }
            set
            {
                this._miscellaneousCharges = value;
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
    }
}