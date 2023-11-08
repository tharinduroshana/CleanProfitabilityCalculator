using Domain.Entities;

namespace Application;

public interface IProfitabilityCalculationService
{
    ProfitabilityCalculationResponse CalculateProfitability(ProfitabilityCalculation profitabilityCalculation);
    double CalculateTotalDistanceBasedCosts(double pricePerKilometre, double noOfKilometres);
    double CalculateTotalTimeBasedCosts(double pricePerHour, double noOfHours);
    double CalculateTotalCosts(double totalDistanceBasedCosts, double totalTimeBasedCosts);
}