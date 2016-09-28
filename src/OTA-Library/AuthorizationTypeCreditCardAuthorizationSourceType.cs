namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.opentravel.org/OTA/2003/05")]
    public enum AuthorizationTypeCreditCardAuthorizationSourceType
    {
        
        /// <remarks/>
        NormalTransaction,
        
        /// <remarks/>
        MailOrPhoneOrder,
        
        /// <remarks/>
        UnattendedTerminal,
        
        /// <remarks/>
        MerchantIsSuspicious,
        
        /// <remarks/>
        eCommerceSecuredTransaction,
        
        /// <remarks/>
        eCommerceUnsecuredTransaction,
        
        /// <remarks/>
        InFlightAirPhone,
        
        /// <remarks/>
        CID_NotLegible,
        
        /// <remarks/>
        CID_NotOnCard,
    }
}