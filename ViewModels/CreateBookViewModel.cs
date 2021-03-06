﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BookStore.ViewModels
{
    public class CreateBookViewModel
    {
        [Required(ErrorMessage = "*")]
        [Display(Name = "Nome do livro")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "*")]
        public string ISBN { get; set; }

        [Required(ErrorMessage = "*")]
        [Display(Name = "Data de lançamento")]
        [DataType(DataType.Date)]
        public DateTime DataLancamento { get; set; }

        [Required(ErrorMessage = "*")]
        public int CategoriaId { get; set; }

        public SelectList CategoriaOptions { get; set; }
    }
}