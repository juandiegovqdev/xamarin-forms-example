using System;
using SQLite;

namespace XamarindotNETExample.Model
{
    public class Post
    {
        [PrimaryKey, AutoIncrement]
        public string Id { get; set; }

        [MaxLength(250)]
        public string Experience { get; set; }
    }
}
