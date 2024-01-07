namespace Day01;

public record Food(
    DateOnly ExpirationDate,
    bool ApprovedForConsumption,
    Guid? InspectorId)
{
    public bool IsEdible(DateOnly edibleDate)
        => IsFresh(edibleDate) &&
           CanBeConsumed() &&
           HasInspectorId();

    private bool CanBeConsumed() => ApprovedForConsumption;

    private bool HasInspectorId() => InspectorId != null;
        
    private bool IsFresh(DateOnly dateToCompare) => ExpirationDate.IsGreaterThan(dateToCompare);
}