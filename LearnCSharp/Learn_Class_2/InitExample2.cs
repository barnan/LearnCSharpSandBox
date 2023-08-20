using System.Diagnostics.CodeAnalysis;
namespace Learn_Class_2
{
    internal class InitExample2 : InitExample
    {
        [SetsRequiredMembers]
        public InitExample2(int prop2) 
            : base(prop2)
        {
        }
                                                        // a required tag láthatósága legalább a tartalmazó típus láthatósága 
        public override required int Prop2              // gyerek elemben nem lehet elfedni a required tagot
        {
            get;
            init;
        }
    }
}
