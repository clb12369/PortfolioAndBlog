using System;
using System.Collections.Generic;
using System.Linq;

public interface IBlog {
    // void create(IEnumerable<Post> post);
    Post read(int BlogId);
    IEnumerable<Post> readAll();
    // Post readLastFive(IEnumerable<Post> posts);
    // IEnumerable<Post> readLastFive();
    // Post update(int BlogId, Post post);
    // void delete(int BlogId);
}

public class Blog : IBlog {
    int BlogId { get; set; } = 1;
    string Title { get; set; } = "My Misadventures";
    public List<Post> posts = new List<Post>();

    // public Blog(int BlogId, string Title){
    //     this.BlogId = BlogId;
    //     this.Title = Title;
    // }



    // default constructor that adds 10 posts to the IEnumerable<Post> posts
    public Blog(){

        this.BlogId = BlogId;
        this.Title = Title;

        posts.Add(new Post {
            PostId = 1,
            Title = "My First Post",
            Content = "Here is my first blog post!"
        });
        posts.Add(new Post {
            PostId = 2,
            Title = "My Second Post",
            Content = "This is my second post"});
        posts.Add(new Post {
            PostId = 3,
            Title = "My Third Post",
            Content = "This is my third post"
        });
        posts.Add(new Post {
            PostId = 4,
            Title = "My Fourth Post",
            Content = "This is my fourth post"
        });
        posts.Add(new Post {
            PostId = 5,
            Title = "My Fifth Post",
            Content = "This is my fifth post"
        }) ;
        posts.Add(new Post {
            PostId = 6,
            Title = "My Sixth Post",
            Content = "This is my sixth post"
        });
        posts.Add(new Post {
            PostId = 7,
            Title = "My Seventh Post",
            Content = "This is my seventh post"
        });
        posts.Add(new Post {
            PostId = 8,
            Title = "My Eighth Post",
            Content = "This is my eighth post"
        });
        posts.Add(new Post {
            PostId = 9,
            Title = "My Ninth Post",
            Content = "This is my ninth post"
        });
        posts.Add(new Post {
            PostId = 10,
            Title = "My Tenth Post",
            Content = "This is my tenth post"
        });
    }

    public Post read(int id){
        return posts.First(p => p.PostId == id);
    }

    public IEnumerable<Post> readAll(){
        return posts;
    }

    public IEnumerable<Post> readLastFive(){
        posts.Reverse();
        List<Post> lastFivePosts = new List<Post>();
        for (int i = 0; i < 5; i++){
            lastFivePosts.Add(posts[i]);
        }
        return lastFivePosts;
    }


}