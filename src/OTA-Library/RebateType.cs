using System.Collections.Generic;

namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class RebateType
    {
        
        private List<PaymentCardType> _paymentInformation;
        
        private TPA_ExtensionsType _tPA_Extensions;
        
        private bool _participationInd;
        
        private string _programName;
        
        private RebateTypeTripPurpose _tripPurpose;
        
        private bool _tripPurposeRequiredInd;
        
        public RebateType()
        {
            this._tPA_Extensions = new TPA_ExtensionsType();
            this._paymentInformation = new List<PaymentCardType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("PaymentInformation")]
        public List<PaymentCardType> PaymentInformation
        {
            get
            {
                return this._paymentInformation;
            }
            set
            {
                this._paymentInformation = value;
            }
        }
        
        public TPA_ExtensionsType TPA_Extensions
        {
            get
            {
                return this._tPA_Extensions;
            }
            set
            {
                this._tPA_Extensions = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool ParticipationInd
        {
            get
            {
                return this._participationInd;
            }
            set
            {
                this._participationInd = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramName
        {
            get
            {
                return this._programName;
            }
            set
            {
                this._programName = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RebateTypeTripPurpose TripPurpose
        {
            get
            {
                return this._tripPurpose;
            }
            set
            {
                this._tripPurpose = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public bool TripPurposeRequiredInd
        {
            get
            {
                return this._tripPurposeRequiredInd;
            }
            set
            {
                this._tripPurposeRequiredInd = value;
            }
        }
    }
}