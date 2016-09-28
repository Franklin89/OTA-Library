using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class ViewershipsTypeViewershipBookingChannelCodes
    {
        
        private List<ViewershipsTypeViewershipBookingChannelCodesBookingChannelCode> _bookingChannelCode;
        
        private bool _channelCodesInclusive;
        
        public ViewershipsTypeViewershipBookingChannelCodes()
        {
            this._bookingChannelCode = new List<ViewershipsTypeViewershipBookingChannelCodesBookingChannelCode>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("BookingChannelCode")]
        public List<ViewershipsTypeViewershipBookingChannelCodesBookingChannelCode> BookingChannelCode
        {
            get
            {
                return this._bookingChannelCode;
            }
            set
            {
                this._bookingChannelCode = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ChannelCodesInclusive
        {
            get
            {
                return this._channelCodesInclusive;
            }
            set
            {
                this._channelCodesInclusive = value;
            }
        }
    }
}