using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

public interface IBlogRepo {
    void Add(Post p);
    Post Read(int id);
    IEnumerable<Post> readLastFive();
    void Delete(int id);
    void Create(Post p);
    Post Update(Post p, int id);
}

public class BlogRepo : IBlogRepo {
    public int BlogId { get; set; } = 1;
    public string Title { get; set; } = "My Misadventures";
    public List<Post> posts = new List<Post>();

    // public Blog(int BlogId, string Title){
    //     this.BlogId = BlogId;
    //     this.Title = Title;
    // }



    // default constructor that adds 10 posts to the IEnumerable<Post> posts
    public BlogRepo(){

        // this.BlogId = BlogId;
        // this.Title = Title;

        posts.Add(new Post {
            PostId = 1,
            Title = "My First Post",
            Content = "Here is my first blog post!"
        });
        posts.Add(new Post {
            PostId = 2,
            Title = "My Second Post",
            Content = "This is my second post"
            });
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

    public void Add(Post p){
        posts.Add(p);
    }

    public Post Read(int id){
        return posts.First(n => n.PostId == id);
    }

    public IEnumerable<Post> readLastFive(){
        // posts.Reverse();
        // List<Post> lastFivePosts = new List<Post>();
        var lastFivePosts = posts.OrderByDescending(x => x.PostId).Take(5);
        // for (int i = 0; i < 5; i++){
        //     lastFivePosts.Add(posts[i]);
        // }
        return lastFivePosts;
    }


    public void Create([FromBody]Post p){
        posts.Add(p);
    }

    public Post Update([FromForm] Post p, int id){
        var postToUpdate = posts.First(n => n.PostId == id);
        if (postToUpdate != null){
            posts.Remove(postToUpdate);
            posts.Add(p);
            return p;
        }
        return null;
    }

    public void Delete(int id){
        var p = posts.First(n => n.PostId == id);
        if(p != null){
            posts.Remove(p);
        }
    }

}