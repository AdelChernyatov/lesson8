using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw
{
    class Program
    {
        static void GetMails(ref string emails)
        {
            emails = emails.Split('#').Last();
            
        }
        static void Main(string[] args)
        {
            Console.WriteLine("task8.1");
            string[] mails_names = File.ReadAllLines("mail.txt");
            for (int i = 0; i < mails_names.Length; i++)
            {
               Console.WriteLine(mails_names[i]);
               GetMails(ref mails_names[i]);
                
            }
            File.WriteAllLines("mails.txt", mails_names);
            Console.WriteLine(File.ReadAllText("mails.txt"));
            Console.WriteLine("Упражнение 8.2");
            List<Song> songs = new List<Song>();
            songs.Add(new Song("Корабли", "Лизер", null));
            songs.Add(new Song("Пачка сигарет", "Лизер", songs[0]));
            songs.Add(new Song("На луне", "Фараон", songs[1]));
            songs.Add(new Song("На луне", "Фараон", songs[2]));
            foreach (Song line in songs)
            {
                Console.WriteLine(line.Title());
            }
            Console.WriteLine(songs[0].Equals(songs[1]));

        }
    }
}
