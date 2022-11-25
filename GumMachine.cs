

using State.Interfaces;

namespace State;

public class GumMachine {

    public int GumBalls { get; set; }
    public IState MachineState { get; set; }


    
}