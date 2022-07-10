namespace SingleStone
{
    public class Contact
    {
        public Contact()
        {
            this.name = null;
            this.address = null;
            this.phone = null;
        }
        public Contact(Name name, Address addr, PhoneNumber phone)
        {
            this.name = name;
            this.address = addr;
            this.phone = phone;
        }
        public Contact(long Id, Name name, Address addr, PhoneNumber phone)
        {
            this.Id = Id;
            this.name = name;
            this.address = addr;
            this.phone = phone;
        }
        public long? Id { get; set; }
        public Name? name { get; set; }
        public Address? address { get; set; }
        public PhoneNumber? phone { get; set; }

    }
}