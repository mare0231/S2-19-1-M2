using System;
using System.Collections.Generic;
using System.Text;

namespace S2.AspNET.Repetition.Entities
{
    public class MemeCreation
    {
        public MemeCreation()
        {

        }
        public MemeCreation(int id, int memeImg, DateTime timeStamp, string memeText, string position, string color, string size)
        {
            Id = id;
            MemeImg = memeImg;
            TimeStamp = timeStamp;
            MemeText = memeText;
            Position = position;
            Color = color;
            Size = size;
        }

        public int Id { get; set; }
        public int MemeImg { get; set; }
        public DateTime TimeStamp { get; set; }
        public string MemeText { get; set; }
        public string Position { get; set; }
        public string Color { get; set; }
        public string Size { get; set; }
    }
}
