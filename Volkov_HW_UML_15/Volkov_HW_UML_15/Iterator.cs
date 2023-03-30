using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volkov_HW_UML_15
{
    internal abstract class Iterator : IEnumerator
    {
        object IEnumerator.Current => Current();

        public abstract int Key();

        public abstract object Current();

        public abstract bool MoveNext();

        public abstract void Reset();
    }

    internal abstract class IteratorAggregate : IEnumerable
    {
        public abstract IEnumerator GetEnumerator();
    }

    internal class RomaniaOrderIterator : Iterator
    {
        RomaniaCollection collection;

        int position = -1;

        bool reverse = false;

        public RomaniaOrderIterator(RomaniaCollection collection, bool reverse = false)
        {
            this.collection = collection;
            this.reverse = reverse;
            if (reverse)
            {
                this.position = collection.GetItems().Count;
            }
        }

        public override object Current()
        {
            return this.collection.GetItems()[position];
        }

        public override int Key()
        {
            return this.position;
        }

        public override bool MoveNext()
        {
            int update = this.position + (this.reverse ? -1 : 1);
            if(update >= 0 && update < this.collection.GetItems().Count)
            {
                position = update;
                return true;
            }
            else
            {
                return false;
            }
        }

        public override void Reset()
        {
            this.position = this.reverse ? this.collection.GetItems().Count - 1 : 0;
        }
    }

    internal class RomaniaCollection : IteratorAggregate
    {
        List<string> list;
        bool dir;


        public RomaniaCollection()
        {
            list = new List<string>();
            dir = false;
        }

        public void ReverseDirection()
        {
            dir = !dir;
        }

        public List<string> GetItems()
        {
            return list;
        }

        public void AddAttractions(string attractions)
        {
            list.Add(attractions);
        }

        public override IEnumerator GetEnumerator()
        {
            return new RomaniaOrderIterator(this, dir);
        }
    }
}
