using System.Collections.Generic;
namespace DEV_13
{
    //Class implements pattern Strategy.
    public interface IStrategy
    {
        List<List<int>> Algorithm(InitialCondition initialCondition);
    }
}
