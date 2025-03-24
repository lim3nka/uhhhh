using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knjiznicaa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            public int Id { get; set; }
            public string Naslov { get; set; }
            public string Autor { get; set; }
            public string ISBN { get; set; }
            public int Godina { get; set; }
           public bool Dostupna { get; set; }

        public Knjiga(int id, string naslov, string autor, string isbn, int godinaIzdavanja)
        {

            Id = id;
            Naslov = naslov;
            Autor = autor;
            ISBN = isbn;
            Godina = godinaIzdavanja;
            Dostupna = true;

        }
    }
}
}
