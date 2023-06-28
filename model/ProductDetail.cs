using System;
using System.Collections.Generic;

namespace efcore_postgres_generic_repo.model;

public partial class ProductDetail
{
    public int Id { get; set; }

    public string ProductName { get; set; } = null!;

    public string ProductDescription { get; set; } = null!;

    public int ProductPrice { get; set; }

    public int ProductStock { get; set; }
}
