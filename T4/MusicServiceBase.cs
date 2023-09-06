namespace T4
{
    public abstract class MusicServiceBase
    {
        public override void Add(string name, string singerName)
        {
            var music = new Music();
            {

                music.Name = name;
                music.SingerName = singerName;
            }
        }
    }
}