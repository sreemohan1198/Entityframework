using System;
using System.Collections.Generic;

namespace CustomerDB_EntityFramework.Data;

public partial class Category
{
    public int CategoryId { get; set; }

    public string? CategoryName { get; set; }

    public string? Description { get; set; }
}
