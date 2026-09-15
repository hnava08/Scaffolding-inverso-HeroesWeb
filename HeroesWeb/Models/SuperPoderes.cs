using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.EntityFrameworkCore;

namespace HeroesWeb.Models;

public partial class SuperPoderes
{
    [Key]
    public int Id { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100)]
    [Display(Name = "Nombre")]
    public string Nombre { get; set; } = null!;

    [StringLength(250)]
    [Display(Name = "Descripción")]
    public string? Descripcion { get; set; }

    [Display(Name = "Héroe")]
    public int HeroeId { get; set; }

    [ForeignKey("HeroeId")]
    [InverseProperty("SuperPoderes")]
    [ValidateNever]
    [Display(Name = "Héroe")]
    public virtual Heroes Heroe { get; set; } = null!;
}
