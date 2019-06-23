using System;

namespace StackOverFaux
{
    class Post
    {
        public string _title;
        public string _description;
        private int _votes;
        public DateTime DateCreated { get; private set; }

        public Post()
        {
            DateCreated = DateTime.Now;
        }

        public Post(string title)
            :this()
        {
            _title = title;
        }

        public Post(string title, string description)
            :this(title)
        {
            _description = description;
        }

        public int GetVotes()
        {
            return _votes;
        }

        public void UpVote()
        {
            _votes +=1;
        }

        public void DownVote()
        {
            _votes -=1;
        }
    }
}
