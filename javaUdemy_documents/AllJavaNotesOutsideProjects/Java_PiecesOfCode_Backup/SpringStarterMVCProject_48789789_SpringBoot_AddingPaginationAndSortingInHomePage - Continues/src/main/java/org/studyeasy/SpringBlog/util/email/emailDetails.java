package org.studyeasy.SpringBlog.util.email;

import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

@Data
@NoArgsConstructor
@AllArgsConstructor
public class emailDetails {
    
    private String recipient;
    private String msgBody;
    private String subject;

}
