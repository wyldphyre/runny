namespace Runny.Models
{
    public class Executor
    {
        public string Command { get; set; }
        public string Arguments { get; set; }
        public int? PauseFor { get; set; }
    }
}