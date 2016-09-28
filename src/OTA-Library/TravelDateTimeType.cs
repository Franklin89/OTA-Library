namespace MLSoftware.OTA
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RailOriginDestinationSummaryType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RailOriginDestinationInformationType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OriginDestinationInformationType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class TravelDateTimeType
    {
        
        private TimeInstantType _item;
        
        private ItemChoiceType _itemElementName;
        
        [System.Xml.Serialization.XmlElementAttribute("ArrivalDateTime", typeof(TimeInstantType))]
        [System.Xml.Serialization.XmlElementAttribute("DepartureDateTime", typeof(TimeInstantType))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemElementName")]
        public TimeInstantType Item
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
        
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemChoiceType ItemElementName
        {
            get
            {
                return this._itemElementName;
            }
            set
            {
                this._itemElementName = value;
            }
        }
    }
}