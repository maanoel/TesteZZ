using System.Collections.Generic;
using TesteZZ;
using Xunit;

namespace TestProject1
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      BootInstruction bootInstruction1 = new BootInstruction(0, "nop");
      BootInstruction bootInstruction2 = new BootInstruction(1, "acc");
      BootInstruction bootInstruction3 = new BootInstruction(4, "jmp");
      BootInstruction bootInstruction4 = new BootInstruction(3, "acc");
      BootInstruction bootInstruction5 = new BootInstruction(-3, "jmp");
      BootInstruction bootInstruction6 = new BootInstruction(-99, "acc");
      BootInstruction bootInstruction7 = new BootInstruction(1, "acc");
      BootInstruction bootInstruction8 = new BootInstruction(-4, "jmp");
      BootInstruction bootInstruction9 = new BootInstruction(6, "acc");

      IList<BootInstruction> bootsList = new List<BootInstruction>{
        bootInstruction1,
        bootInstruction2,
        bootInstruction3,
        bootInstruction4,
        bootInstruction5,
        bootInstruction6,
        bootInstruction7,
        bootInstruction8,
        bootInstruction9
      };

      IDictionary<string, IInstruction> dictionaryInstructions = new Dictionary<string, IInstruction>();
      dictionaryInstructions.Add("acc", new Acc());
      dictionaryInstructions.Add("jmp", new Jmp());
      dictionaryInstructions.Add("nop", new Nop());

      InstructionsCalculator calculator = new InstructionsCalculator(bootsList, dictionaryInstructions);

      var lineBreak = calculator.Execute();

      Assert.Equal(5, lineBreak);
    }
  }
}