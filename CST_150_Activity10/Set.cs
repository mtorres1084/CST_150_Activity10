using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CST_150_Activity10
{
    class Set
    {
      private List<int> elements;
      public Set()
      {
        elements = new List<int>();
      }
      public bool addElement(int val)
      {
        if (containsElement(val)) return false;
        else
        {
            elements.Add(val);
            return true;
        }
      }
      private bool containsElement(int val)
      {
            //for (int i = 0; i < elements.Count; i++)
            //{
            //  if (val == elements[i])
            //return true;
            //else
            //  return false                               
            //}
            // elements is null
            return elements.Contains(val);
        }
        public override string ToString()
      {
          string str = " ";
          foreach (int i in elements)
          {
              str += i + " ";
          }
          return str;
      }
      public void clearSet()
      {
        elements.Clear();
      }
      public Set union(Set rhs)
      {
            // needs to return to a new set
            Set union = new Set();
            //add the current elements to the new object
            for(int i = 0; i < this.elements.Count; i++)
            {
                union.addElement(this.elements[i]);
            }
          for (int i = 0; i < rhs.elements.Count; i++)
          {
                //this.addElement(rhs.elements[i]);
                // add the elements to the current object
                union.addElement(rhs.elements[i]);
          }
            //return rhs;
            // return new object
            return union;
      }
    }
}

