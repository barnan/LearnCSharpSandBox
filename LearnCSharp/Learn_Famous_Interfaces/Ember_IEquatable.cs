using System;
using System.Collections.Generic;

namespace Learn_Famous_Interfaces
{
    // IEquatable<T> is used by Dictionay<Tkey, Tvalue>, LinkedList<T>, List<>      in Contains(), IndexOf(), LastIndexOf(), Remove()
    //
    //
    // a GetHashCode() -ot  a Ditionary<TKey, TValue> vagy Dictionary-base ből származó objektumok hívják
    // HashCode számítás:
    //  - HashCode rendeltetése -> egy gyors számgenerálás kollekciókban való azonosításhoz
    //  - hashcode zámítás eredménye változhat, .net implementációnként, platformtól függően, az application domain -en kívül a konkrét számot nem szabad felhasználni
    //  - egyenlő objektum -> egyenlő hashcode
    //  - visszafelé nem igaz a reláció, egyenlő hashcode-ból nem következik az objektum egyenlőség
    //  - egyenletesen illik lefednie az egész számsíkot
    //  - nem lehet számolás igényes
    //  - nem dobhat kivételt
    //  - static mezőt nem használni benne
    //  - Csak immutable type-nál ajánlott ezt újraimplementálni, mutable típusoknál csak akkor, ha:
    //      - mutable mezőkből számolható a hashcode
    //      - időben nem változnak az immutable mezők, amíg collection-ben van

    internal class Ember_IEquatable : IEquatable<Ember_IEquatable>
    {
        public int Age { get; set; }

        public string Name { get; set; }

        // típusos, ide hív pl Dictionary-ből, List-ből az x.Equals(x), de csak akkor ha rajta van az IEquatable<>
        // síma típusos egyenlőségvizsgálatnál megtalálja az interface nélkül is (paraméter egyezés alapján)
        public bool Equals(Ember_IEquatable other)
        {
            // return Age == other.Age && Name == other.Name;
            return Age == other.Age;
        }

        // típustalan, ide hív tovább az Object.Equals(obj1, obj2)
        // de ha nincs az IEquatable<> rajta, akkor ahelyett (x.Equals(x)) is ide hív, vagy ha List<object> ben vizsgálunk egyenlőséget
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        // Dictionary-ből ide hív az egyenlőség vizsgálat elősször, ha eszerint egyenlő, akkor megy tovább az x.Equaly(x) -ra
        public override int GetHashCode()
        {
            return Name.GetHashCode(); //+ Age;
        }

        public static bool operator ==(Ember_IEquatable ember1, Ember_IEquatable ember2)
        {
            return ember1.Age == ember2.Age;
        }

        public static bool operator !=(Ember_IEquatable ember1, Ember_IEquatable ember2)
        {
            return ember1.Age != ember2.Age;
        }
    }

    internal class EmberEqualityComparer_01 : IEqualityComparer<Ember_IEquatable>
    {
        public bool Equals(Ember_IEquatable x, Ember_IEquatable y)
        {
            throw new NotImplementedException();
        }

        public int GetHashCode(Ember_IEquatable obj)
        {
            throw new NotImplementedException();
        }
    }

    internal class EmberEqualityComparer_02 : EqualityComparer<Ember_IEquatable>
    {
        public override bool Equals(Ember_IEquatable x, Ember_IEquatable y)
        {
            throw new NotImplementedException();
        }

        public override int GetHashCode(Ember_IEquatable obj)
        {
            throw new NotImplementedException();
        }
    }
}