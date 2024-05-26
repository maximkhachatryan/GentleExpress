﻿namespace GentleExpress.Repositories.Abstraction.Entities;

public class District
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;

    public int CityId { get; set; }
    public City City { get; set; } = null!;
}
