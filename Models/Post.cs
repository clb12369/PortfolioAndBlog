using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

public class Post
{
    public int PostId { get; set; }
    public string title { get; set; }
    public string content { get; set; }
    
    // public Post(int PostId, string title, string content){
    //     this.PostId = PostId;
    //     this.title = title;
    //     this.content = content;
    // }
}

