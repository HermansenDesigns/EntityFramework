using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vidzy
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new VidzyDbContext();
            dbContext.Videos.Add(new Video() {Name = "Pendulum", ReleaseDate = DateTime.Now});
            dbContext.SaveChanges();

            foreach (var video in dbContext.Videos)
            {
                Console.WriteLine($"{video.Name} - {video.ReleaseDate}");
            }
        }
    }
}
