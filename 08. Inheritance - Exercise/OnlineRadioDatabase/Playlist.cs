namespace OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Playlist : List<Track>
    {
        // Method.
        public override string ToString()
        {
            var totalSeconds = this.Sum(song => int.Parse(song.Length));
            TimeSpan time = TimeSpan.FromSeconds(totalSeconds);

            return
                $"Songs added: {this.Count}\n" +
                $"Playlist length: {time.Hours}h {time.Minutes}m {time.Seconds}s";
        }
    }
}



