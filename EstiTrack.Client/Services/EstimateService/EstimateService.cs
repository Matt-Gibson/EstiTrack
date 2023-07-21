namespace EstiTrack.Client.Services.EstimateService;
using EstiTrack.Shared.Models;

public static class EstimateService
{
     private static readonly List<Estimate> estimates = new()
    {
        new Estimate()
        {
            Id = 1,
            Customer = new(),
            JobType = "Gutter",
            IsRush = true
        },
        new Estimate()
        {
            Id = 2,
            Customer = new(),
            JobType = "Window",
            IsRush = false
        },
        new Estimate()
        {
            Id = 3,
            Customer = new(),
            JobType = "Roof",
            IsRush = true
        }
    };

    public static Estimate[] GetEstimates()
    {
        return estimates.ToArray();
    }

    public static void AddEstimate(Estimate estimate)
    {
        estimates.Add(estimate);
    }
}