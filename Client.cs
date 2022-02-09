using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedisExampleKeyValue
{
    class Client
    {
        public Guid key { get; set; }
        public string Nome { get; set; }
        public string Document { get; set; }

        public Client()
        {
            key = Guid.NewGuid();
        }

    }
}
