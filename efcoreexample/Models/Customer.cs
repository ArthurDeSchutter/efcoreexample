using System;
using System.Collections.Generic;

namespace efcoreexample.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Adress { get; set; }
}
