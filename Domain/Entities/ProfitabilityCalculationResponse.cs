namespace Domain.Entities;

public record ProfitabilityCalculationResponse(
    Guid Id,
    double PricePerKilometre,
    double PricePerHour,
    double NoOfKilometres,
    double NoOfHours,
    double Income,
    double TotalDistanceBasedCost,
    double TotalTimeBasedCost,
    double Profitability
);