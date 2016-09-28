using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class SpecialReqDetailsType
    {
        
        private List<SpecialReqDetailsTypeSeatRequest> _seatRequests;
        
        private List<SpecialReqDetailsTypeSpecialServiceRequest> _specialServiceRequests;
        
        private List<SpecialReqDetailsTypeOtherServiceInformation> _otherServiceInformations;
        
        private List<SpecialReqDetailsTypeRemark> _remarks;
        
        private List<SpecialReqDetailsTypeSpecialRemark> _specialRemarks;
        
        public SpecialReqDetailsType()
        {
            this._specialRemarks = new List<SpecialReqDetailsTypeSpecialRemark>();
            this._remarks = new List<SpecialReqDetailsTypeRemark>();
            this._otherServiceInformations = new List<SpecialReqDetailsTypeOtherServiceInformation>();
            this._specialServiceRequests = new List<SpecialReqDetailsTypeSpecialServiceRequest>();
            this._seatRequests = new List<SpecialReqDetailsTypeSeatRequest>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SeatRequest", IsNullable=false)]
        public List<SpecialReqDetailsTypeSeatRequest> SeatRequests
        {
            get
            {
                return this._seatRequests;
            }
            set
            {
                this._seatRequests = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialServiceRequest", IsNullable=false)]
        public List<SpecialReqDetailsTypeSpecialServiceRequest> SpecialServiceRequests
        {
            get
            {
                return this._specialServiceRequests;
            }
            set
            {
                this._specialServiceRequests = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("OtherServiceInformation", IsNullable=false)]
        public List<SpecialReqDetailsTypeOtherServiceInformation> OtherServiceInformations
        {
            get
            {
                return this._otherServiceInformations;
            }
            set
            {
                this._otherServiceInformations = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("Remark", IsNullable=false)]
        public List<SpecialReqDetailsTypeRemark> Remarks
        {
            get
            {
                return this._remarks;
            }
            set
            {
                this._remarks = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("SpecialRemark", IsNullable=false)]
        public List<SpecialReqDetailsTypeSpecialRemark> SpecialRemarks
        {
            get
            {
                return this._specialRemarks;
            }
            set
            {
                this._specialRemarks = value;
            }
        }
    }
}