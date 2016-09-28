using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class AirlinePrefTypeTourCodePref
    {
        
        private object _item;
        
        private string _passengerTypeCode;
        
        private List<string> _airlineVendorPrefRPH;
        
        private TransferActionType _transferAction;
        
        public AirlinePrefTypeTourCodePref()
        {
            this._airlineVendorPrefRPH = new List<string>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("StaffTourCodeInfo", typeof(AirlinePrefTypeTourCodePrefStaffTourCodeInfo))]
        [System.Xml.Serialization.XmlElementAttribute("TourCodeInfo", typeof(AirlinePrefTypeTourCodePrefTourCodeInfo))]
        public object Item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string PassengerTypeCode
        {
            get
            {
                return this._passengerTypeCode;
            }
            set
            {
                this._passengerTypeCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<string> AirlineVendorPrefRPH
        {
            get
            {
                return this._airlineVendorPrefRPH;
            }
            set
            {
                this._airlineVendorPrefRPH = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransferActionType TransferAction
        {
            get
            {
                return this._transferAction;
            }
            set
            {
                this._transferAction = value;
            }
        }
    }
}