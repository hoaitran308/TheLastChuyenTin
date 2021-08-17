using System;
using System.Collections.Generic;
using System.IO;
using TheLastChuyenTin.Models;

namespace TheLastChuyenTin.Repository
{
    public class MusicRepository
    {
        private List<Music> _musics;
        private Random random;

        public MusicRepository()
        {
            _musics = new List<Music>();
            random = new Random(); 
        }

        public void AddMusic(Music musics)
        {
            _musics.Add(musics);
        }

        public Music GetMusicById(string id)
        {
            return _musics.Find(m => m.Id == id);
        }

        public Music GetRandomMusic()
        {
            do
            {
                Music music = _musics[random.Next(0, _musics.Count)];
                if (!music.IsShown)
                {
                    music.IsShown = true;
                    return music;
                }
            }
            while (Check());
            return null;
        }

        public bool Check()
        {
            return _musics.Exists(m => m.IsShown == false);
        }

        public void Init()
        {
            string[] lines = File.ReadAllLines(@"wwwroot\info.txt");
            foreach (var line in lines)
            {
                if (string.IsNullOrEmpty(line.Trim()))
                {
                    break;
                }
                string[] word = line.Split('|');
                AddMusic(new Music()
                {
                    Id = word[0],
                    Name = word[1],
                    Singer = word[2],
                    Link = word[3]
                });
            }
        }
    }
}
