using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework8
{
    [Serializable]
    public class Document
    {
        
        public BindingList<Text> DocTexts { get; set; }    // List of texts in the document
        public String SavedName { get; set; }          // Name used to save the document

        //Constructor (empty list)
        public Document()
        {
            this.DocTexts = new BindingList<Text>();
            this.SavedName = "Untitled";
        }

        //Add a shape to the list
        public void AddText(Text t)
        {
            this.DocTexts.Add(t);            
        }

        //Remove a shape from the list
        public void RemoveText(Text t)
        {
            this.DocTexts.Remove(t);
        }

        //Return the size of the list
        public int CountShape()
        {
            return this.DocTexts.Count();
        }
    }
}
