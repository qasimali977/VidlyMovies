﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyMovies.Models;

namespace VidlyMovies.ViewModels
{
    public class RandomMoviesViewModels
    {
        public Movies Movies { get; set; }
        public List<Customers> Customers { get; set; }
    }
}