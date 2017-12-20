using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;

namespace Homework8
{
    [Serializable]
    class CustomImage : INotifyPropertyChanged
    {
        public Bitmap myPicture { get; set; }
        public String SavedName { get; set; }


        public Bitmap MyPicture
        {
            get { return myPicture; }
            set
            {
                this.myPicture = value;
                this.OnPropertyChanged("MyPicture");
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public CustomImage()
        {
            myPicture = new Bitmap(684, 407, PixelFormat.Format24bppRgb);
            SavedName = "Image1.g1";
        }

        public CustomImage(int w, int h, string s)
        {
            myPicture = new Bitmap(w, h, PixelFormat.Format24bppRgb);
            SavedName = s;
        }


        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

    }

    
}
