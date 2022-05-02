namespace PingPong.Models
{
  public class Input
  {
    public int UserInput { get; set; }
    public string UserOutput { get; set; }

    public Input(int userInput, string userOutput)
    {
      UserInput = userInput;
      UserOutput = userOutput;
    }

  }
}