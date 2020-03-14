using System.Collections;
using System;
namespace Assignment4
{
    class Iterator
    {
        private IList list;
        private IEnumerator iterator;
        
        public Iterator(IList list){
            this.list = list;
            iterator =  list.GetEnumerator();
            iterator.MoveNext();
        }
        
        public object? getElement(){
            
            return iterator.Current;
        }
        public bool next(){
            return iterator.MoveNext();
        }
        public void reset(){
            iterator.Reset();
        }
        
    }
    
}