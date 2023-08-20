
using System.Diagnostics.CodeAnalysis;

namespace Learn_Class_2
{
    class InitExample
    {
        public required int _valami1;       // a REQUIRED field-re is tehető és property-re is
        public int _valami2;

        public int Prop0
        {
            get;
        }

        public int Prop1
        {
            get;
            init;       // ha itt az init akkor object-inicializálás közben is engedi beállítani, nem csak konstruktorból
        }

        public virtual required int Prop2       // a REQUIRED azt jelenti definiáláskor mindenképpen meg kell adni object-inicializálás közben (vagy konstruktorban)
        {
            get;
            init;       
        }


        public string FirstName { get; set; } = "Jane";         // kezdőértéket ad egy auto-property-nek

        [SetsRequiredMembers]
        public InitExample(int prop2)
        {
            Prop0 = 0;                      // ha csak get-tere van, akkor konstruktorból még be lehet állítani
            Prop2 = prop2;                  // a [SetsRequiredMembers attributum miatt]
        }
    }
}
