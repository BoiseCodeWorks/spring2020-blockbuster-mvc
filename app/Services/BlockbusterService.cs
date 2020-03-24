using System;
using System.Collections.Generic;
using bb_mvc.Models;

namespace bb_mvc.Services
{
    //NOTE Serivce should never call Console.WriteLine
    class BlockbusterService
    {
        private Store _store { get; set; } = new Store();

        //NOTE this is where I will store everything the controller needs to print
        public List<string> Messages { get; set; } = new List<string>();
        public void AddVideoMenuToMessages()
        {
            //NOTE You could use "Where" as a fitler before printing (you will need Linq)
            //add to messages all videos
            for (int i = 0; i < _store.Videos.Count; i++)
            {
                var video = _store.Videos[i];
                if (video.IsAvailable)
                {
                    Messages.Add($"{i + 1}. {video.Title} ({video.Rating})");
                }
            }
        }

        public void Rent(string indexString)
        {
            if (int.TryParse(indexString, out int index) && index - 1 > -1 && index - 1 < _store.Videos.Count)
            {
                Video videoToRent = _store.Videos[index - 1];
                if (videoToRent.IsAvailable)
                {
                    videoToRent.IsAvailable = false;
                    Messages.Add("Successfully Checked out " + videoToRent.Title);
                    return;
                }
            }

            Messages.Add("Invalid Movie Number");

        }
    }
}