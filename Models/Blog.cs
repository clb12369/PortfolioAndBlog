using System;
using System.Collections.Generic;
using System.Linq;

interface IBlog {
    void create(IEnumerable<Post> post);
    Post get(int BlogId);
    Post update(int BlogId, Post post);
    void delete(int BlogId);
}

public class Blog : IBlog {
    int BlogId { get; set; } = 1;
    string title { get; set; } = "My Misadventures";
    public List<Post> posts = new List<Post>();

    // default constructor that adds 10 posts to the IEnumerable<Post> posts
    public Blog(){
        posts.Add(new Post {
            PostId = 1,
            title = "",
            content = ""

        });
        posts.Add(new Post {
            PostId = 2,
            title = "",
            content = ""});

        posts.Add(new Post {
            PostId = 3,
            title = "",
            content = ""
        });

        posts.Add(new Post {
            PostId = 3,
            title = "",
            content = ""
        });

        posts.Add(new Post {
            PostId = 4,
            title = "",
            content = ""
        }) ;

        posts.Add(new Post {
            PostId = 5,
            title = "",
            content = ""
        });
        posts.Add(new Post {
            PostId = 6,
            title = "",
            content = ""
        });
        posts.Add(new Post {
            PostId = 7,
            title = "",
            content = ""
        });
        posts.Add(new Post {
            PostId = 8,
            title = "",
            content = ""
        });
        posts.Add(new Post {
            PostId = 9,
            title = "",
            content = ""
        });
        posts.Add(new Post {
            PostId = 10,
            title = "",
            content = ""
        });
    }


}