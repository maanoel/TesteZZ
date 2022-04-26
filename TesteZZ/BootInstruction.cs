namespace TesteZZ
{
  public class BootInstruction
  {
    private int value;
    private string key;

    public BootInstruction(int valor, string key)
    {
      this.value = valor;
      this.key = key;
    }

    public int Value
    {
      get { return value; }
      set { this.value = value; }
    }

    public string Key
    {
      get { return key; }
      set { key = value; }
    }
  }
}