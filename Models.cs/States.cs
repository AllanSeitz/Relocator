using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Relocator.Models
{
  public class States
  {
    public int Id { get; set; }
    public string StateName { get; set; }
    public string AverageSalary { get; set; }
    public string AveragePopulation { get; set; }
    public string AdjustedIncome { get; set; }

    public string AverageAge { get; set; }
    public string AverageTemp { get; set; }
    public string TaxRate { get; set; }
    public string GrowthRate { get; set; }
    public string Elevation { get; set; }
    public string ImgUrl { get; set; }
    public string CostOfLiving { get; set; }
  }
}