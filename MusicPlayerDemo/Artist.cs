using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerDemo
{
    public class Artist
    {
        private string _name;
        public string Name 
        {
            get { return _name; }
            set { this._name=value; } 
        }
        private string _genre;
        public string Genre
        {
            get { return _genre; }
            set { this._genre = value; }
        }
        private string _album;
        public string Album
        {
            get { return _album; }
            set { this._album = value; }
        }
        private string _recordLabel;
        public string RecordLabel
        {
            get { return _recordLabel; }
            set { this._recordLabel = value; }
        }
        private int _grammyAward;
        public int GrammyAward
        {
            get { return _grammyAward; }
            set { this._grammyAward = value; }
        }

        public Artist(string name, string genre, string album, string recordLabel, int grammyAward)
        {
            _name = name;
            _genre = genre;
            _album = album;
            _recordLabel = recordLabel;
            _grammyAward = grammyAward;
        }
    }
}
