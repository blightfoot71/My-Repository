using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Post
{
    public class Post
    {
        private int _votecounter;
        private DateTime _creatationtime;

        public Post()
        {
            _creatationtime = DateTime.Now;
        }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime CreationTime
        {
            get { return _creatationtime; }
            //private set {; }
        }

        public void UpVote()
        {
            _votecounter++;
        }

        public void DownVote()
        {
            _votecounter--;
        }

        public int ViewVotes()
        {
            return _votecounter;
        }
    }
}
