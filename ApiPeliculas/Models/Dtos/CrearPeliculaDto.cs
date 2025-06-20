﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ApiPeliculas.Models.Dtos
{
    public class CrearPeliculaDto
    {
        public string Name { get; set; }
        public string Descripcion { get; set; }
        public int Duracion { get; set; }
        public string RutaImagen { get; set; }
        public enum CrearTipoClasificacion { siete, trece, dieciseis, dieciocho }
        public CrearTipoClasificacion Clasificacion { get; set; }
        public int categoriaId { get; set; }
    }
}
