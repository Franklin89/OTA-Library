using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class StationDetailsType
    {
        
        private StationType _details;
        
        private OperationSchedulesType _operationSchedules;
        
        private AddressType _address;
        
        private List<StationDetailsTypeTelephone> _telephone;
        
        public StationDetailsType()
        {
            this._telephone = new List<StationDetailsTypeTelephone>();
            this._address = new AddressType();
            this._operationSchedules = new OperationSchedulesType();
            this._details = new StationType();
        }
        
        public StationType Details
        {
            get
            {
                return this._details;
            }
            set
            {
                this._details = value;
            }
        }
        
        public OperationSchedulesType OperationSchedules
        {
            get
            {
                return this._operationSchedules;
            }
            set
            {
                this._operationSchedules = value;
            }
        }
        
        public AddressType Address
        {
            get
            {
                return this._address;
            }
            set
            {
                this._address = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Telephone")]
        public List<StationDetailsTypeTelephone> Telephone
        {
            get
            {
                return this._telephone;
            }
            set
            {
                this._telephone = value;
            }
        }
    }
}