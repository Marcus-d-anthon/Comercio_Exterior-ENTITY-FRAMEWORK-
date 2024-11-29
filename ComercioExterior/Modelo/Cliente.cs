using System;
using System.Collections.Generic;

namespace ComercioExterior.Modelo;

public partial class Cliente
{
    public int Id { get; set; }

    public string? Cedula { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Estado { get; set; }

    public virtual ICollection<Transaccion> Transaccions { get; set; } = new List<Transaccion>();
}
