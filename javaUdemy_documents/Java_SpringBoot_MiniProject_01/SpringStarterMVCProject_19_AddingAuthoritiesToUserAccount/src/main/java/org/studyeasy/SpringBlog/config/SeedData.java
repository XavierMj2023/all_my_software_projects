package org.studyeasy.SpringBlog.config;

import java.util.List;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;
import org.studyeasy.SpringBlog.models.Account;
import org.studyeasy.SpringBlog.models.Authority;
import org.studyeasy.SpringBlog.models.Post;
import org.studyeasy.SpringBlog.services.AccountService;
import org.studyeasy.SpringBlog.services.AuthorityService;
import org.studyeasy.SpringBlog.services.PostService;
import org.studyeasy.SpringBlog.utils.constant.Privilages;

@Component
public class SeedData implements CommandLineRunner {

    @Autowired
    private PostService postService;

    @Autowired
    private AccountService accountService;

    @Autowired
    private AuthorityService authorityService;

    @Override
    public void run(String... args) throws Exception {

        for (Privilages auth : Privilages.values()) {
            Authority authority = new Authority();
            authority.setId(auth.getId());
            authority.setName(auth.getPrivillage());
            authorityService.save(authority);
        }

        // Account
        Account account01 = new Account();
        Account account02 = new Account();

        account01.setEmail("account01@studyeasy.org");
        account01.setPassword("password");
        account01.setFirstname("user01");
        account01.setLastname("lastname01");

        account02.setEmail("account02@studyeasy.org");
        account02.setPassword("password");
        account02.setFirstname("user02");
        account02.setLastname("lastname02");

        accountService.save(account01);
        accountService.save(account02);

        // Post
        List<Post> posts = postService.getAll();
        if (posts.size() == 0) {
            Post post01 = new Post();
            post01.setTitle("Post01");
            post01.setBody("Post 01 Body ..........................");

            // added
            post01.setAccount(account01);
            postService.save(post01);

            Post post02 = new Post();
            post02.setTitle("Post02");
            post02.setBody("Post 02 Body ..........................");

            // added
            post02.setAccount(account02);
            postService.save(post02);
        }
    }

}
