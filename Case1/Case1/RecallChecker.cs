namespace Case1;

public struct RecallChecker
{
    public bool Recalled { get; } = false;
    public string Reason { get; } = string.Empty;
    
    public RecallChecker(string make, string model, DateTime productionDate, RecallVehicle[] recallVehicles)
    {
        foreach (var recallModel in recallVehicles)
        {
            if (recallModel.Make != make || recallModel.Model != model || recallModel.Date < productionDate) continue;
            Recalled = true;
            Reason = recallModel.Reason;
            return;
        }
    }
}