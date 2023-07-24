namespace EstiTrack.Client.Services.EstimateService;

using System.ComponentModel;

using EstiTrack.Shared.Models;

public static class EstimateService
{
     private static readonly List<Estimate> estimates = new()
    {
        new Estimate()
        {
            FirstName = "Steve",
            LastName = "Caudill",
            PhoneNumber = "555-555-4782",
            Id = 1,
            DateCreated = new DateOnly(2022,01,02),
            DateUpdated = new DateOnly(2023,05,06),
            JobType = "Gutter",
            IsRush = true
        },
        new Estimate()
        {
            FirstName = "Justin",
            LastName = "Cox",
            PhoneNumber = "222-544-4588",
            Id = 2,
            DateCreated = new DateOnly(2021,10,12),
            DateUpdated = new DateOnly(2022,07,04),
            JobType = "Window",
            IsRush = false
        },
        new Estimate()
        {
            FirstName = "Bob-da",
            LastName = "Butcher",
            PhoneNumber = "859-867-5309",
            Id = 3,
            DateCreated = new DateOnly(2000,10,09),
            DateUpdated = new DateOnly(2021,08,11),
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

    public static void DeleteEstimate(int id)
    {
        Estimate estimate = GetEstimateByID(id);
        estimates.Remove(estimate);
    }
}