using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAPIDummyJSON.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public Category Category { get; set; }
        public List<string> PhotoUrls { get; set; }
        public List<Tag> Tags { get; set; }


        /* {
            "id": 0,
            "category": {
                        "id": 0,
                        "name": "string"
                        },
            "name": "doggie",
            "photoUrls": [
                        "string"
                        ],
            "tags": [
                        {
                        "id": 0,
                        "name": "string"
                        }
                    ],
            "status": "available"
        }*/
    }
}
