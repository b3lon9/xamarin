using System;
using System.Collections.Generic;
using System.Text;

namespace Notes.Models
{
    // model이며, data가 저장되는 곳
    // Note모델을 저장하는 곳
    internal class Note
    {
        public string Filename { get; set; }
        public string Text { get; set; }  
        public DateTime Date { get; set; }
    }
}
