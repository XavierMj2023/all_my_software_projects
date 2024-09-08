package org.studyeasy.SpringBlog.controller;

import java.util.List;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
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

    //Adding Logger
    Logger logger = LoggerFactory.getLogger(HomeRestController.class);

    @GetMapping("/")
    public List<Post> home() {
        logger.debug("This is a test log error");
        return postService.findAll();
    }

    // @GetMapping("/")
    // public List<Post> home() {
    //     logger.error("This is a test log error");
    //     return postService.findAll();
    // }

    // @GetMapping("/")
    // public String home() {
    //     logger.error("This is a test log error");
    //     return "sample response";
    // }

    // @GetMapping("/")
    // public List<Post> home() {
    //     return postService.findAll();
    // }


    //------------------xxxx Demo Display xxxxx----------------------------------------------
    // @GetMapping("/")
    // public List<String> home() {
    //     return List.of("Post 1", "Post 2", "Post 3");
    // }
}
