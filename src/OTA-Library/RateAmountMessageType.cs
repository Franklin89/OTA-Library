using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RateAmountMessageType
    {
        
        private StatusApplicationControlType _statusApplicationControl;
        
        private List<RateAmountMessageTypeRate> _rates;
        
        private string _locatorID;
        
        public RateAmountMessageType()
        {
            this._rates = new List<RateAmountMessageTypeRate>();
            this._statusApplicationControl = new StatusApplicationControlType();
        }
        
        public StatusApplicationControlType StatusApplicationControl
        {
            get
            {
                return this._statusApplicationControl;
            }
            set
            {
                this._statusApplicationControl = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Rate", IsNullable=false)]
        public List<RateAmountMessageTypeRate> Rates
        {
            get
            {
                return this._rates;
            }
            set
            {
                this._rates = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string LocatorID
        {
            get
            {
                return this._locatorID;
            }
            set
            {
                this._locatorID = value;
            }
        }
    }
}