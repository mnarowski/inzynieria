using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PhotoGalleryLibrary.GUI
{
    public class TranparenLabel: Label
    {
        public TranparenLabel()        
        {            
            this.SetStyle(ControlStyles.Opaque, true);            
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, false);        
        }   
     
        protected override CreateParams CreateParams        
        {            
            get            
            {                
                CreateParams parms = base.CreateParams;                
                parms.ExStyle |= 0x20;  
                return parms;            
            }        
        }    
    }
}
