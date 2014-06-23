using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Drool.App_Code
{
    public class Records : ICollection
    {
        public string CollectionName;
        private ArrayList recArray = new ArrayList();

        public Record this[int index]
        {
            get { return (Record)recArray[index]; }
        }

        public void CopyTo(Array a, int index)
        {
            recArray.CopyTo(a, index);
        }
        public int Count
        {
            get { return recArray.Count; }
        }
        public object SyncRoot
        {
            get { return this; }
        }
        public bool IsSynchronized
        {
            get { return false; }
        }
        public IEnumerator GetEnumerator()
        {
            return recArray.GetEnumerator();
        }

        public void Add(Record newRecord)
        {
            recArray.Add(newRecord);
        }
    }
}