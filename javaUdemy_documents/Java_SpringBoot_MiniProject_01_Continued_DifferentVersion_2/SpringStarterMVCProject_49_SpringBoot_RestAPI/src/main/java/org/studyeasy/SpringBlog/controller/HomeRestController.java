package org.studyeasy.SpringBlog.controller;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;
import org.studyeasy.SpringBlog.models.Post;
import org.studyeasy.SpringBlog.services.PostService;

@RestController
@RequestMapping("/api/v1")
public class HomeRestController {
    @Autowired
    private PostService postService;

    @GetMapping("/")
    public List<Post> home() {
        return postService.findAll();
    }

    // @GetMapping("/")
    // public List<String> home() {
    //     return List.of("Post 1", "Post 2", "Post 3");
    // }
}
