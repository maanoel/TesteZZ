namespace TesteZZ
{
  public class Jmp : IInstruction
  {
    public void Execute(Context context, int value)
    {
      context.Pointer += value;
    }
  }
}
