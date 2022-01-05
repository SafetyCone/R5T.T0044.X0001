using System;

using R5T.T0041;
using R5T.T0124;


namespace R5T.T0044.X0001
{
    public static class Instances
    {
        public static IPathOperator PathOperator { get; } = T0041.PathOperator.Instance;
        public static ISearchPattern SearchPattern { get; } = T0124.SearchPattern.Instance;
    }
}
