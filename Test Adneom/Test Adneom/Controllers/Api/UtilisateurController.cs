using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test_Adneom.Models;

namespace Test_Adneom.Controllers.Api
{
    public class UtilisateurController : ApiController
    {
        private ApplicationDbContext _context;
        public UtilisateurController()
        {
            _context = new ApplicationDbContext();
        }

        // GET/api/Utilisateurs/1
        public Utilisateur GetUtilisateur(int id)
        {
            var utilisateur = _context.Utilisateurs.SingleOrDefault(m => m.Id == id);

            if (utilisateur == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            return utilisateur;
        }

        // POST/api/Utilisateurs
        [HttpPost]
        public Utilisateur CreateUtilisateur(Utilisateur utilisateur)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Utilisateurs.Add(utilisateur);
            _context.SaveChanges();

            return utilisateur;
        }

        // PUT/api/Utilisateurs/1
        [HttpPut]
        public string UpdateUtilisateur(int id, Utilisateur utilisateur)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var userInDb = _context.Utilisateurs.SingleOrDefault(m => m.Id == id);

            if (userInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            userInDb.Id = id;
            userInDb.Boisson = utilisateur.Boisson;
            userInDb.WithMug = utilisateur.WithMug;
            userInDb.QuantiteSucre = utilisateur.QuantiteSucre;

            _context.SaveChanges();

            return $"User {id} was succefully updated";
        }

    }
}
