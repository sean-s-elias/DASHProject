using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TridentGoalSeek;

namespace Application
{
    public interface IGoalSeekService
    {
        void CalculateGoalSeek(int multiplier);//IGoalSeekAlgorithm
    }
}