package org.studyeasy.SpringRestdemo.payload.auth;

import io.swagger.v3.oas.annotations.media.Schema;
import io.swagger.v3.oas.annotations.media.Schema.RequiredMode;
import jakarta.validation.constraints.NotBlank;
import jakarta.validation.constraints.Size;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
public class AuthoritiesDTO {
    
    @NotBlank
    @Size(min = 6, max = 20)
    @Schema(description = "Authorities", example = "USER", requiredMode = RequiredMode.REQUIRED)
    private String authorities;

}
