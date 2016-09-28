using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelReservationsTypeHotelReservation : HotelReservationType
    {
        
        private List<RebateType> _rebatePrograms;
        
        public HotelReservationsTypeHotelReservation()
        {
            this._rebatePrograms = new List<RebateType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("RebateProgram", IsNullable=false)]
        public List<RebateType> RebatePrograms
        {
            get
            {
                return this._rebatePrograms;
            }
            set
            {
                this._rebatePrograms = value;
            }
        }
    }
}