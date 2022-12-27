using System;
using System.Collections.Generic;

namespace OTRate.Models;

public partial class OtRateDef
{
    public int Id { get; set; }

    public string? OtSlabName { get; set; }

    public string? OtSlabType { get; set; }

    public string? PayGroup { get; set; }

    public string? HrsComponent { get; set; }

    public string? OtValueComponent { get; set; }

    public string? BaseComponent { get; set; }

    public string? OtRate { get; set; }

    public string? ConsiderForOt { get; set; }

    public string? MonthlyRate { get; set; }

    public string? StartDate { get; set; }

    public string? EndDate { get; set; }
}
