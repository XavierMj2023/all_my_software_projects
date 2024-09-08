package org.studyeasy.SpringBlog.utils.constant;

public enum Roles {
    USER("ROLE_USER"),ADMIN("ROLE_ADMIN"),EDITOR("ROLE_EDITOR");

    private String role;

    private Roles(String role) {
        this.role = role;
    }
    public String getRole() {
        return role;
    }

}
