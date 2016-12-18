namespace GenericClass
{
    using System;
    using System.Text;

    public class GenericList<T> where T : IComparable
    {
        private const int InitialCapacity = 8;

        private T[] elements;

        public GenericList()
        {
            this.Count = 0;
            this.Capacity = InitialCapacity;
            this.elements = new T[InitialCapacity];
        }

        public int Capacity { get; set; }

        public int Count { get; set; }

        public void Add(T element)
        {
            if (this.Count < this.Capacity)
            {
                this.elements[this.Count] = element;
                this.Count++;
            }
            else if (this.Count == this.Capacity)
            {
                var tempElements = this.elements;

                this.Capacity *= 2;
                this.elements = new T[this.Capacity];
                tempElements.CopyTo(this.elements, 0);
            }
            else if (this.Count > this.Capacity)
            {
                throw new IndexOutOfRangeException("You have excided the capacity of the array");
            }
        }

        public void AddAtIndex(T element, int index)
        {
            if (index > this.Count || index < 0)
            {
                throw new IndexOutOfRangeException("This element is out of the array");
            }
            else
            {
                var temp = new GenericList<T>();

                for (int i = index; i < this.Count; i++)
                {
                    temp.Add(this.elements[i]);
                }

                this.elements[index] = element;

                for (int i = 0, j = index + 1; i <= temp.Count; i++, j++)
                {
                    this.elements[j] = temp.elements[i];
                }

                this.Count++;
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (index > this.Count || index < 0)
            {
                throw new IndexOutOfRangeException("This element is out of the array");
            }
            else
            {
                for (int i = index; i < this.Count; i++)
                {
                    this.elements[i] = this.elements[i + 1];
                }

                this.Count--;
            }
        }

        public T Min() // Task 7
        {
            if (this.Count < 0)
            {
                throw new ArgumentException("There are no elements in this list");
            }

            T min = this.elements[0];

            foreach (T item in this.elements)
            {
                if (min.CompareTo(item) > 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public T Max() // Task 7
        {
            if (this.Count < 0)
            {
                throw new ArgumentException("There are no elements in this list");
            }

            T max = this.elements[0];

            foreach (T item in this.elements)
            {
                if (max.CompareTo(item) < 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public override string ToString()
        {
            var listElements = new StringBuilder();

            for (int i = 0; i < this.Count; i++)
            {
                listElements.AppendFormat("{0}, ", this.elements[i]);
            }

            return listElements.ToString();
        }
    }
}
