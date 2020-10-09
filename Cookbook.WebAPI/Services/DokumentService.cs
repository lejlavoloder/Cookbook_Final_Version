using AutoMapper;
using Cookbook.Model.Requests;
using Cookbook.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cookbook.WebAPI.Services
{
    public class DokumentService:IDokumentService
    {
        public DokumentService(CookbookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        private readonly CookbookContext _context;
        private readonly IMapper _mapper;

        public List<Model.Dokument> Get(DokumentSearchRequest search)
        {
            var q = _context.Set<Database.Dokument>().AsQueryable();

            if (!string.IsNullOrEmpty(search?.Naziv))
            {
                q = q.Where(x => x.NazivDokumenta.ToLower().StartsWith(search.Naziv)
                || x.NazivDokumenta.ToUpper().StartsWith(search.Naziv));
            }

            q = q.OrderBy(x => x.NazivDokumenta);
            var list = q.ToList();

            return _mapper.Map<List<Model.Dokument>>(list);


        }

        public Model.Dokument GetById(int id)
        {
            var entity = _context.Dokumenti.Find(id);

            return _mapper.Map<Model.Dokument>(entity);
        }

        public Model.Dokument Insert(DokumentUpsertRequest request)
        {
            var entity = _mapper.Map<Database.Dokument>(request);
            _context.Dokumenti.Add(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Dokument>(entity);
        }

        public Model.Dokument Update(int id, DokumentUpsertRequest request)
        {
            var entity = _context.Dokumenti.Find(id);
            _context.Dokumenti.Attach(entity);
            _context.Dokumenti.Update(entity);
            entity.NazivDokumenta = request.NazivDokumenta;
            entity.FileName = request.FileName;
            entity.KorisnikId = request.KorisnikId;
            if (request.Sadrzaj != null && request.Sadrzaj.Length != 0)
                entity.Sadrzaj = request.Sadrzaj;
            _context.SaveChanges();
            return _mapper.Map<Model.Dokument>(entity);
        }


        public Model.Dokument Delete(int id)
        {
            var entity = _context.Dokumenti.Find(id);

            _context.Dokumenti.Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Dokument>(entity);
        }

    }
}

