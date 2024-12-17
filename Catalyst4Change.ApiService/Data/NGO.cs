using System.Collections.Generic;

namespace Catalyst4Change.ApiService.Data
{
    public class NGO
    {
        public int Id { get; set; } // Assuming you need an Id for the entity
        public string NGOName { get; set; }
        public string RegistrationNumber { get; set; }
        public string NGOAddress { get; set; }
        public List<string> WorkingSectors { get; set; }
    }
}
