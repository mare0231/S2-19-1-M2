using S2.AspNET.Repetition.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace S2.AspNET.Repetition.DAL
{
    public class MemeCreationRepository : BaseRepository
    {
        public MemeCreationRepository(string conString) : base(conString)
        {
        }

        public int Insert(MemeCreation memeCreation)
        {
            return ExecuteNonQuery($"INSERT INTO MemeCreations VALUES ('{memeCreation.MemeImg}', CURRENT_TIMESTAMP, '{memeCreation.MemeText}', '{memeCreation.Position}', '{memeCreation.Color}', '{memeCreation.Size}')");
        }
        public MemeCreation GetRandomMeme(out MemeImage memeImage)
        {
            DataTable memeCreationTable = ExecuteQuery($"SELECT TOP 1 MemeCreations.Id, Url, MemeText, Position, Color, Size FROM MemeCreations JOIN MemeImages ON MemeImages.Id = MemeCreations.MemeImg ORDER BY NEWID()");
            if (memeCreationTable.Rows.Count > 0)
            {
                DataRow row = memeCreationTable.Rows[0];
                int id = (int)row["Id"];
                string url = (string)row["Url"];
                string memeText = (string)row["MemeText"];
                string position = (string)row["Position"];
                string color = (string)row["Color"];
                string size = (string)row["Size"];
                memeImage = new MemeImage()
                {
                    Url = url
                };
                MemeCreation memeCreation = new MemeCreation()
                {
                    Id = id,
                    MemeText = memeText,
                    Position = position,
                    Color = color,
                    Size = size
                };
                return memeCreation;
            }
            else
            {
                throw new ArgumentException($"No memes were found");
            }
        }
    }
}
