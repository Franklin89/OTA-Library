using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelResModifyTypeHotelResModify : HotelReservationType
    {
        
        private List<HotelResModifyTypeHotelResModifyVerification> _verification;
        
        public HotelResModifyTypeHotelResModify()
        {
            this._verification = new List<HotelResModifyTypeHotelResModifyVerification>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("Verification")]
        public List<HotelResModifyTypeHotelResModifyVerification> Verification
        {
            get
            {
                return this._verification;
            }
            set
            {
                this._verification = value;
            }
        }
    }
}