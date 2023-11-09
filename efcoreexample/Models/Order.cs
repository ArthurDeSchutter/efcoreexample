using System;
using System.Collections.Generic;

namespace efcoreexample.Models;

public partial class Order
{
    public int Id { get; set; }

    public int CustomerId { get; set; }

    public DateTime Created { get; set; }

    public int? ItemId { get; set; }
}
