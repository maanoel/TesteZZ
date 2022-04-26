namespace TesteZZ
{
  public class Nop : IInstruction
  {
    public void Execute(Context context, int value)
    {
      context.Pointer += 1;
    }
  }
}
