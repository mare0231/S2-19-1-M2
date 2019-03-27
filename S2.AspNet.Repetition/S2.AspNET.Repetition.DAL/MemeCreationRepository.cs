﻿using S2.AspNET.Repetition.Entities;
using System;
using System.Collections.Generic;
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
    }
}
