using System;
using EquipmentFormatter.External;

namespace EquipmentFormatter.Models
{
  public class Rule
  {
    private readonly Func<Variation, bool> isSatisfiedBy;
    private readonly Func<string, string>  applyOn;

    public Rule(Func<Variation, bool> isSatisfiedBy, Func<string, string> applyOn)
    {
      this.isSatisfiedBy = isSatisfiedBy;
      this.applyOn       = applyOn;
    }

    public bool IsSatisfiedBy(Variation variation) =>
      isSatisfiedBy(variation);

    public string ApplyOn(string label) =>
      applyOn(label);
  }
}