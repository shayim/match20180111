using System;

namespace Match.Domain.Common.PartyBase
{
    public class PartyContact
    {
        public Guid PartyId { get; private set; }
        public Guid ContactId { get; private set; }
        public bool IsActive { get; set; } = true;

        public Party Party { get; private set; }
        public Person Contact { get; private set; }

        protected PartyContact()
        {
        }

        public PartyContact(Party party, Person contact)
        {
            if (party.Id == contact.Id)
            {
                throw new ArgumentException("party contact ids could not be same");
            }

            if (contact.PartyType == (int)PartyType.Company)
            {
                throw new ArgumentException("party contact should be one person");
            }

            Party = party;
            Contact = contact;
            PartyId = party.Id;
            ContactId = contact.Id;
        }
    }
}