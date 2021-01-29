using System;

namespace Praktikum12
{
    public class LinkedList<Element>
    {
        private LinkedListElement<Element> first, last;
        private int counter;

        public LinkedList()
        {
            first = null;
            last = null;

            counter = 0;
        }

        class ListIterator : Iterator<Element>
        {
            private LinkedListElement<Element> currentObject;

            public ListIterator(LinkedListElement<Element> currentObject)
            {
                this.currentObject = currentObject;
            }

            public bool hasNext()
            {
                if (currentObject != null)
                {
                    return true;
                }
                return false;

            }

            public Element next()
            {
                LinkedListElement<Element> current = currentObject;
                currentObject = currentObject.After;

                return current.Data;
            }
        }
        
        public class LinkedListElement<Element>
        {
            private Element data;
            private LinkedListElement<Element> before, after;

            public LinkedListElement(Element data)
            {
                this.data = data;

                before = null;
                after = null;
            }

            public Element Data
            {
                get => data;
                set => data = value;
            }

            public LinkedListElement<Element> Before
            {
                get => before;
                set => before = value;
            }

            public LinkedListElement<Element> After
            {
                get => after;
                set => after = value;
            }
        }

        public void Add(Element newElement)
        {
            LinkedListElement<Element> newListElement = new LinkedListElement<Element>(newElement);
            
            if (isEmpty())
            {
                first = newListElement;
                last = newListElement;
                counter++;
            }
            else
            {
                newListElement.Before = last;
                last.After = newListElement;
                last = newListElement;
                
                counter++;
            }
        }

        public void Remove(int pos)
        {
            if (pos < counter)
            {
                //check if last Element
                if (pos == (counter - 1))
                {
                    if (counter > 1)
                    {
                        last = last.Before;
                        last.After = null;
                    }
                    else //is first and last Element 
                    {
                        first = null;
                        last = null;
                    }
                    
                } else if (pos == 0) // check if first Element
                {
                    first = first.After;
                    first.Before = null;

                } else //delete in middle
                {
                    int objCounter = 0;
                    LinkedListElement<Element> currentObject = first;

                    while (pos != objCounter)
                    {
                        currentObject = currentObject.After;

                        objCounter++;
                    }

                    currentObject.After.Before = currentObject.Before;
                    currentObject.Before.After = currentObject.After;
                }
                counter--;
            }
        }

        public Iterator<Element> GetIterator()
        {
            return new ListIterator(first);
        }

        private bool isEmpty()
        {
            return counter == 0;
        }
    }
}