namespace TesteZZ
{
  public class Acc : IInstruction
  {
    public void Execute(Context context, int value)
    {
      context.Pointer += 1;
      context.Accumulator += value;
    }
  }
}
