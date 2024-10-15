using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Team
{
    public class Team
    {
        private List<Person> players;

        public Team()
        {
            players = new List<Person>();
        }

        public IReadOnlyCollection<Person> Players { get; set; }

        public void Add(Person person)
        {
            if (person == null)
            {
                throw new ArgumentNullException();
            }

            this.players.Add(person);
        }
    }
}