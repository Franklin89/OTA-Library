namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class CodeListExtension
    {
        
        private CodeListSummaryExtension _item;
        
        private bool _chargeInd;
        
        private bool _proximityInd;
        
        private bool _quantityInd;
        
        private bool _scheduleInd;
        
        public CodeListExtension()
        {
            this._item = new CodeListSummaryExtension();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Detail", typeof(CodeListDetailExtension))]
        [System.Xml.Serialization.XmlElementAttribute("Summary", typeof(CodeListSummaryExtension))]
        public CodeListSummaryExtension Item
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
        public bool ChargeInd
        {
            get
            {
                return this._chargeInd;
            }
            set
            {
                this._chargeInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ProximityInd
        {
            get
            {
                return this._proximityInd;
            }
            set
            {
                this._proximityInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool QuantityInd
        {
            get
            {
                return this._quantityInd;
            }
            set
            {
                this._quantityInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ScheduleInd
        {
            get
            {
                return this._scheduleInd;
            }
            set
            {
                this._scheduleInd = value;
            }
        }
    }
}