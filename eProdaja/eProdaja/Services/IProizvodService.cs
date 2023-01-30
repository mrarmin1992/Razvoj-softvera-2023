using System;
using eProdaja.Controllers;

namespace eProdaja.Services
{
	public interface IProizvodService
	{
        public IEnumerable<Proizvod> Get();
        public Proizvod GetById(int id);
        public Proizvod Insert(Proizvod proizvod);
        public Proizvod Update(int id, Proizvod proizvod);
    }
}

