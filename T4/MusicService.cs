using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T4
{
     public abstract class MusicService
    {
        protected List<Music> musicList=new List<Music>();
        protected int musicCount=1;
        
        public   virtual Music SwitchNext(Music music)
        {
            if (musicCount>musicList.Count-1)
            {
                musicCount++;
                Console.WriteLine(MessageConstants.Nextsong);
            }
            return musicList[musicCount];
            
        }
        public virtual Music SwitchPrevious()
        {
            if(musicCount>0)
            {
                musicCount--;
                Console.WriteLine(MessageConstants.Prevsong);
            }
            return musicList[musicCount-1];
        }
        public  virtual Music DisplayCurrentSong() 
        {
            if (musicCount>0 && musicCount<musicList.Count)
            {
                Music music = musicList[musicCount];
                Console.WriteLine($"Hozirgi qoshiq{music.Name}-{music.SingerName}");
            }
            return musicList[musicCount];
        }
        public override void Add(string name,string singerName)
        {
            var music=new Music();
            {
               
                music.Name = name;
                music.SingerName = singerName;
            }
            
        }
    }
}
