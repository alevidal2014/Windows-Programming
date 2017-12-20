using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    [Serializable]
    public class Document
    {
        
        public BindingList<Shape> DocShapes { get; set; }    // List of shapes in the document
        public String SavedName { get; set; }          // Name used to save the document

        //Constructor (empty list)
        public Document()
        {
            this.DocShapes = new BindingList<Shape>();
            this.SavedName = "Untitled";
        }

        //Add a shape to the list
        public void AddShape(Shape s)
        {
            this.DocShapes.Add(s);            
        }

        //Remove a shape from the list
        public void RemoveShape(Shape s)
        {
            this.DocShapes.Remove(s);
        }

        //Return the size of the list
        public int CountShape()
        {
            return this.DocShapes.Count();
        }
    }
}
