namespace MLSoftware.OTA
{
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "4.2.0.31")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opentravel.org/OTA/2003/05")]
    public partial class DOW_RestrictionsType
    {
        
        private DOW_RestrictionsTypeAvailableDaysOfWeek _availableDaysOfWeek;
        
        private DOW_RestrictionsTypeArrivalDaysOfWeek _arrivalDaysOfWeek;
        
        private DOW_RestrictionsTypeDepartureDaysOfWeek _departureDaysOfWeek;
        
        private DOW_RestrictionsTypeRequiredDaysOfWeek _requiredDaysOfWeek;
        
        public DOW_RestrictionsType()
        {
            this._requiredDaysOfWeek = new DOW_RestrictionsTypeRequiredDaysOfWeek();
            this._departureDaysOfWeek = new DOW_RestrictionsTypeDepartureDaysOfWeek();
            this._arrivalDaysOfWeek = new DOW_RestrictionsTypeArrivalDaysOfWeek();
            this._availableDaysOfWeek = new DOW_RestrictionsTypeAvailableDaysOfWeek();
        }
        
        public DOW_RestrictionsTypeAvailableDaysOfWeek AvailableDaysOfWeek
        {
            get
            {
                return this._availableDaysOfWeek;
            }
            set
            {
                this._availableDaysOfWeek = value;
            }
        }
        
        public DOW_RestrictionsTypeArrivalDaysOfWeek ArrivalDaysOfWeek
        {
            get
            {
                return this._arrivalDaysOfWeek;
            }
            set
            {
                this._arrivalDaysOfWeek = value;
            }
        }
        
        public DOW_RestrictionsTypeDepartureDaysOfWeek DepartureDaysOfWeek
        {
            get
            {
                return this._departureDaysOfWeek;
            }
            set
            {
                this._departureDaysOfWeek = value;
            }
        }
        
        public DOW_RestrictionsTypeRequiredDaysOfWeek RequiredDaysOfWeek
        {
            get
            {
                return this._requiredDaysOfWeek;
            }
            set
            {
                this._requiredDaysOfWeek = value;
            }
        }
    }
}