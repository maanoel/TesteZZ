using System.Collections.Generic;

namespace TesteZZ
{
  public class InstructionsCalculator
  {
    public IList<BootInstruction> BootInstructionList { get; }
    public IDictionary<string, IInstruction> InstructionDictionary { get; }

    public InstructionsCalculator(IList<BootInstruction> bootInstructionList,
    IDictionary<string, IInstruction> instructionDictionary)
    {
      BootInstructionList = bootInstructionList;
      InstructionDictionary = instructionDictionary;
    }

    public int Execute()
    {
      var instructionsExecuted = new HashSet<BootInstruction>();
      var context = new Context();

      while (context.Pointer < BootInstructionList.Count)
      {
        var instruction = BootInstructionList[context.Pointer];

        if (instructionsExecuted.Contains(instruction))
          break;

        instructionsExecuted.Add(instruction);

        InstructionDictionary[instruction.Key].Execute(context, instruction.Value);
      }

      return context.Accumulator;
    }
  }
}