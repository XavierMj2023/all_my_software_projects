package org.studyeasy.SpringStarter.services;

import java.time.LocalDateTime;
import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;
import org.studyeasy.SpringStarter.models.Post;
import org.studyeasy.SpringStarter.repositories.PostRepository;

@Service
public class PostService {
    @Autowired
    private PostRepository postRepository;

    //Method which will get us a specific record based on the primary key.
    //Optional is a return Object of Post Type ; If we do not get this, we get null.
    public Optional<Post> getById(Long id){
        return postRepository.findById(id);
    }
    //Listing All the data
    public List<Post> getAll(){
        return postRepository.findAll();
    }
    //Delete
    public void delete(Post post){
         postRepository.delete(post);
    }
    //Saving the data
    //It will be null, if we are adding new record.
    public Post save(Post post){
        if(post.getId() == null){
            post.setCreatedAt(LocalDateTime.now());
        }
        return postRepository.save(post); 
    }
}
