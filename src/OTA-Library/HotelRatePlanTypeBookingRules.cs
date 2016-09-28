namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelRatePlanTypeBookingRules : BookingRulesType
    {
        
        private HotelRatePlanTypeBookingRulesInventoryInfo _inventoryInfo;
        
        public HotelRatePlanTypeBookingRules()
        {
            this._inventoryInfo = new HotelRatePlanTypeBookingRulesInventoryInfo();
        }
        
        public HotelRatePlanTypeBookingRulesInventoryInfo InventoryInfo
        {
            get
            {
                return this._inventoryInfo;
            }
            set
            {
                this._inventoryInfo = value;
            }
        }
    }
}