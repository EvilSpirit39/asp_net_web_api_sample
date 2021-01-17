namespace asp_net_web_api_sample.Models {
  public class TodoItem {
    public long Id {get; set;}
    public string Name {get; set;}

    public bool IsComplete {get; set;}

    public string Secret {get; set;}
  }
}