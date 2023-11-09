using System;
using System.Collections.Generic;

namespace efcoreexample.Models;

public partial class Product
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public int Stock { get; set; }
}
