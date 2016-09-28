namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public enum PricingType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per stay")]
        Perstay,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per person")]
        Perperson,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per night")]
        Pernight,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per person per night")]
        Perpersonpernight,
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("Per use")]
        Peruse,
    }
}