namespace EstiTrack.Client.Services.EstimateService;
using EstiTrack.Shared.Models;

public static class EstimateService
{
     private static readonly List<Estimate> estimates = new()
    {
        new Estimate()
        {
            Id = 1,
            JobType = "Gutter",
            IsRush = true
        },
        new Estimate()
        {
            Id = 2,
            JobType = "Window",
            IsRush = false
        },
        new Estimate()
        {
            Id = 3,
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
        estimate.Id = estimates.Max(estimate => estimate.Id) + 1;
        estimates.Add(estimate);
    }

    public static Estimate GetEstimateByID(int id)
    {
        return estimates.Find(estimate => estimate.Id == id) ?? throw new Exception("Could not find given id.");
    }

    public static void UpdateEstimate(Estimate updatedEstimate)
    {
        Estimate existingEstimate = GetEstimateByID(updatedEstimate.Id);
        existingEstimate.FirstName = updatedEstimate.FirstName;
        existingEstimate.LastName = updatedEstimate.LastName;
        existingEstimate.JobType = updatedEstimate.JobType;
        existingEstimate.PhoneNumber = updatedEstimate.PhoneNumber;
        existingEstimate.IsRush = updatedEstimate.IsRush;
        existingEstimate.DateCreated = updatedEstimate.DateCreated;
        existingEstimate.DateUpdated = updatedEstimate.DateUpdated;
    }
}