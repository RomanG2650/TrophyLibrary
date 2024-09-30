using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpgave
{
    public class TrophiesRepository
    {   
        private int _nextId = 1;
        private readonly List<Trophy> _trophies = new();

        public TrophiesRepository()
        {
            _trophies.Add(new Trophy() { Id = _nextId++, Competition = "Champions League", Year = 1969 });
            _trophies.Add(new Trophy() { Id = _nextId++, Competition = "Europa League", Year = 1968 });
            _trophies.Add(new Trophy() { Id = _nextId++, Competition = "Conference League", Year = 1967 });
            _trophies.Add(new Trophy() { Id = _nextId++, Competition = "La Liga", Year = 1966 });
            _trophies.Add(new Trophy() { Id = _nextId++, Competition = "Premier League", Year = 1965 });
            
        }

        public List<Trophy> GetAll() //Få alle trophies
        {
            return new List<Trophy>(_trophies);
        }

        public Trophy? GetById(int id) //Filtere i trophies by ID
        {
            return _trophies.Find(trophy => trophy.Id == id);
        }

        public Trophy AddTrophy(Trophy trophy) //Tilføj trophies og tilføj unik ID ved tilføjelse til listen
        {
            trophy.Id = _nextId++;
            _trophies.Add(trophy);
            return trophy;
        }

        public Trophy? Remove(int id)
        {
           Trophy? trophy = GetById(id);
           if (trophy == null)
           {
                return null;
           }
           _trophies.Remove(trophy);
           return trophy;
        }

        public Trophy? Update(int id, Trophy trophy)
        {
            trophy.Validate();
            Trophy? existingTrophy = GetById(id);
            if (existingTrophy == null)
            {
                return null;
            }
            existingTrophy.Competition = trophy.Competition;
            existingTrophy.Year = trophy.Year;
            return existingTrophy;
        }
    }
}
