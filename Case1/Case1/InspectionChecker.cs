namespace Case1;

public struct InspectionChecker
{
    // Value for how many months before the inspection is due that the user should be warned
    private const int WarningMonths = 2;
    // Value for how many years a new vehicle can be registered before it needs an inspection
    private const int NewVehicleYears = 4;
    // Value for how many years a pre-owned vehicle can be registered before it needs an inspection
    private const int PreownedVehicleYears = 2;
    
    public bool NeedInspection { get; }
    
    public InspectionChecker(DateTime RegistrationDate)
    {
        NeedInspection = DateTime.Now >= RegistrationDate.AddYears(NewVehicleYears).AddMonths(-WarningMonths);
    }
    
    public InspectionChecker(DateTime RegistrationDate, DateTime LatestInspectionDate)
    {
        NeedInspection = DateTime.Now > LatestInspectionDate.AddYears(PreownedVehicleYears).AddMonths(-WarningMonths);
    }
}