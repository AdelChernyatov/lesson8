using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class Song
    {
        private string name;
        private string author;
        private Song prev;
        public Song(string name, string author, Song prev)
        {
            this.name = name;
            this.author = author;
            this.prev = prev;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAuthor(string author)
        {
            this.author = author;
        }
        public void SetPrev(Song prev)
        {
            this.prev = prev;
        }
        public string Title()
        {
            return name + " " + author;
        }
        public override bool Equals(object e)
        {
            return (e != null) && (name.Equals(((Song)e).name)) && (author.Equals(((Song)e).author));
        }

    }
}
