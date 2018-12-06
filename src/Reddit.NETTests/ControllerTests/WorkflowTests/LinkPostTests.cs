﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Reddit.NET;
using Reddit.NET.Controllers;
using Reddit.NET.Exceptions;
using RedditThings = Reddit.NET.Models.Structures;
using System;
using System.Collections.Generic;

namespace Reddit.NETTests.ControllerTests.WorkflowTests
{
    [TestClass]
    public class LinkPostTests : BaseTests
    {
        private LinkPost Post
        {
            get
            {
                return post ?? TestLinkPost();
            }
            set
            {
                post = value;
            }
        }
        private LinkPost post;

        public LinkPostTests() : base() { }

        private LinkPost TestLinkPost()
        {
            Post = reddit.Subreddit(testData["Subreddit"]).LinkPost("Test Link Post", "http://www.go-fuck-yourself.com").Submit(resubmit: true);
            return post;
        }

        [TestMethod]
        public void Submit()
        {
            Validate(Post);
        }
    }
}
