﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArmazenamentoDeCaminhosDeImagens.Models
{
    public class Contexto : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
        public Contexto(DbContextOptions<Contexto> options) :base(options)
        {

        }
    }
}
