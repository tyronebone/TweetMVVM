using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TweetMVVM.Models;

namespace TweetMVVM.ViewModels
{
    public class PostsViewModel
    {
        public System.Collections.ObjectModel.ObservableCollection<Post> Posts { get; set; }

        public PostsViewModel ()
        {
            Posts = new ObservableCollection<Post>();

            Posts.Add(new Post { Message = "Bengay", Username = "Bertrum" });
            Posts.Add(new Post { Message = "E", Username = "Bean" });
            Posts.Add(new Post { Message = "AAAAA", Username = "Thot" });
            Posts.Add(new Post { Message = "You<Thanos", Username = "Thanos" });
            Posts.Add(new Post { Message = "I", Username = "T" });


        }
    }
}
