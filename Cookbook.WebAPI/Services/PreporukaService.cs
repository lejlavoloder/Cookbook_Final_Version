using AutoMapper;
using Cookbook.WebAPI.Database;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Storage;
using System.Security.Cryptography.X509Certificates;

namespace Cookbook.WebAPI.Services
{

    public class PreporukaService : IPreporukaService
    {
        private readonly CookbookContext _context;
        private readonly IMapper _mapper;
        public int BrojPreporuka = 5;
        public PreporukaService(CookbookContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public List<Model.Recept> GetPreporuka(int KorisnikId)
        {
            List<Favoriti> MojiFavoriti = _context.Favoriti.Where(m => m.KorisnikId == KorisnikId)
                .Include(x => x.Recept.Slozenost)
                .Include(x => x.Recept.GrupaJela)
                .ToList();
            if (MojiFavoriti.Count() > 0)
            {
                List<GrupaJela> grupejela = new List<GrupaJela>();
                List<Slozenost> slozenost = new List<Slozenost>();
                foreach (var favoriti in MojiFavoriti)
                {
                    var receptslozenost = favoriti.Recept.Slozenost;
                    var receptgrupajela = favoriti.Recept.GrupaJela;

                    bool add = true;
                    bool add1 = true;
                    for (int i = 0; i < grupejela.Count; i++)
                    {
                        if (receptgrupajela.GrupaJelaId == grupejela[i].GrupaJelaId)
                        {
                            add = false;
                        }
                    }
                    for (int i = 0; i < slozenost.Count; i++)
                    {
                        if (receptslozenost.SlozenostId == slozenost[i].SlozenostId)
                        {
                            add1 = false;
                        }
                    }
                    if (add)
                    {
                        grupejela.Add(receptgrupajela);
                    }
                    if (add1)
                    {
                        slozenost.Add(receptslozenost);
                    }
                }
                    List<Recept> ListaPreporucenihRecepata = new List<Recept>();
                    List<Recept> ReceptGrupaJela = new List<Recept>();
                    List<Recept> ReceptGrupaSlozenost = new List<Recept>(); 
                    foreach (var GrupaJela in grupejela)
                    {
                    ReceptGrupaJela = _context.Recept.Where(n => n.GrupaJelaId == GrupaJela.GrupaJelaId).ToList();
                    }
                    foreach (var sloz in slozenost)
                    {
                    ReceptGrupaSlozenost = _context.Recept.Where(b => b.SlozenostId == sloz.SlozenostId).ToList();
                    }
                    foreach (var recepti in ReceptGrupaJela)
                    {
                        bool add2 = true;
                        for (int i = 0; i < ListaPreporucenihRecepata.Count(); i++)
                        {
                            if (recepti.ReceptId == ListaPreporucenihRecepata[i].ReceptId)
                            {
                                add2 = false;
                            }
                        }
                        foreach (var favorit in MojiFavoriti)
                        {
                            if (recepti.ReceptId == favorit.ReceptId)
                            {
                                add2 = false;
                            }
                        }
                        if (add2)
                        {
                            ListaPreporucenihRecepata.Add(recepti);
                        }
                    }
                foreach (var recepti in ReceptGrupaSlozenost)
                {
                    bool add2 = true;
                    for (int i = 0; i < ListaPreporucenihRecepata.Count(); i++)
                    {
                        if (recepti.ReceptId == ListaPreporucenihRecepata[i].ReceptId)
                        {
                            add2 = false;
                        }
                    }
                    foreach (var favorit in MojiFavoriti)
                    {
                        if (recepti.ReceptId == favorit.ReceptId)
                        {
                            add2 = false;
                        }
                    }
                    if (add2)
                    {
                        ListaPreporucenihRecepata.Add(recepti);
                    }
                }
                ListaPreporucenihRecepata = ListaPreporucenihRecepata.OrderBy(c => Guid.NewGuid()).Take(BrojPreporuka).ToList();
                    if (ListaPreporucenihRecepata.Count == 0)
                    {
                        ListaPreporucenihRecepata=_context.Recept.Take(BrojPreporuka).OrderBy(x => Guid.NewGuid()).ToList();
                    }
                    var list1 = _mapper.Map<List<Model.Recept>>(ListaPreporucenihRecepata);
                    foreach(var recept in list1)
                    {
                        recept.Ocjena = _context.Ocjena.Where(b => b.ReceptId == recept.ReceptId)
                            .Average(b => (decimal?)b.ocjena) ?? new decimal(0);
                    }
                    return list1;
                }
            var ListaSvihRecepata = _context.Recept.Take(BrojPreporuka).OrderBy(x => Guid.NewGuid()).ToList();
            var list2 = _mapper.Map<List<Model.Recept>>(ListaSvihRecepata);
            foreach(var list3 in list2)
            {
                list3.Ocjena = _context.Ocjena.Where(b => b.ReceptId == list3.ReceptId)
                    .Average(b => (decimal?)b.ocjena) ?? new decimal(0);
            }
            return list2;
            }
        }
    }


