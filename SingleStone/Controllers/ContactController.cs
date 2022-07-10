using Microsoft.AspNetCore.Mvc;

namespace SingleStone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {

        [HttpGet(Name = "GET")]
        public IEnumerable<Contact> Get()
        {
            long i = 0;
            return Enumerable.Range(1, 3).Select(index => new Contact
                {
                Id = ++i,
                    name = new Name("Steven", "W", "Flanders"),
                    address = new Address("5 Abbot bridge drive", "Andover", "Massachusettes", "018180"),
                    phone = new PhoneNumber("607-475-2685")
                }
            )
            .ToArray();
        }

        [HttpGet("Id")]
        public Contact? GetById(long ID)
        {
            return Get().FirstOrDefault();
        }

        [HttpPost]
        public Contact Post(Contact contact)
        {
            // Create a new contact
            return contact;
        }

        [HttpPut]
        public Contact Put(Contact contact)
        {
            // Update a contact
            return contact;
        }

        [HttpDelete]
        public Contact? Delete(long ID)
        {
            // Delete a contact
            throw new Exception($"Contact ID not Found: {ID}");
        }

    }
}