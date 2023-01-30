using System;
using eProdaja.Controllers;

namespace eProdaja.Services
{
	public class ProizvodService : IProizvodService
	{
            private static List<Proizvod> _proizvod;

        static ProizvodService()
        {
            _proizvod = new List<Proizvod>()
            {
                new Proizvod()
                {
                    Id=1,
                    Name="Laptop",
                },
                new Proizvod()
                {
                    Id=2,
                    Name="Mobitel",
                },

            };
        }
        public IEnumerable<Proizvod> Get()
        {
            return _proizvod;
        }

        public Proizvod GetById(int id)
        {
            return _proizvod.FirstOrDefault(x => x.Id == id);
        }

        public Proizvod Insert(Proizvod proizvod)
        {
            _proizvod.Add(proizvod);
            return proizvod;
        }

        public Proizvod Update(int id, Proizvod proizvod)
        {
            var current = _proizvod.FirstOrDefault(x => x.Id == id);
            current.Name = proizvod.Name;
            return current;
        }

    }
}

