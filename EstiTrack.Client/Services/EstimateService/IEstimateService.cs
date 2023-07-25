namespace EstiTrack.Client.Services.EstimateService;
using EstiTrack.Shared.Models;

    public interface IEstimateService
    {
        List<Estimate> Estimates {get; set;}

        Task GetEstimates();
        Task<Estimate?> GetEstimateById(int id);
    }
