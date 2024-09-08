package org.studyeasy.SpringBlog.security;

import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.security.config.Customizer;
import org.springframework.security.config.annotation.method.configuration.EnableMethodSecurity;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.crypto.bcrypt.BCryptPasswordEncoder;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.security.web.SecurityFilterChain;
import org.studyeasy.SpringBlog.util.constants.Privillages;

@Configuration
@EnableWebSecurity
@EnableMethodSecurity(prePostEnabled = true, securedEnabled = true)
public class WebSecurityConfig {

        private static final String[] WHITELIST = {
                        "/",
                        "/login",
                        "/register",
                        "/db-console/**",
                        "/css/**",

                        /* Importing css and other resources */
                        "/fonts/**",
                        "/images/**",
                        "/js/**"
        };

        @Bean
        public static PasswordEncoder passwordEncoder() {
                return new BCryptPasswordEncoder();
        }

        @Bean
        public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception {
                http
                                .authorizeHttpRequests(authorizeRequests -> authorizeRequests
                                                .requestMatchers(WHITELIST).permitAll() // Use requestMatchers() instead
                                                                                        // of antMatchers()
                                                .requestMatchers("/profile/**").authenticated()
                                                .requestMatchers("/admin/**").hasRole("ADMIN")
                                                .requestMatchers("/editor/**").hasAnyRole("ADMIN", "EDITOR")
                                                .requestMatchers("/test")
                                                .hasAuthority(Privillages.ACCESS_ADMIN_PANEL.getPrivillage()))
                                .formLogin(formLogin -> formLogin
                                                .loginPage("/login")
                                                .loginProcessingUrl("/login")
                                                .usernameParameter("email")
                                                .passwordParameter("password")
                                                .defaultSuccessUrl("/", true)
                                                .failureUrl("/login?error")
                                                .permitAll())
                                .logout(logout -> logout
                                                .logoutUrl("/logout")
                                                .logoutSuccessUrl("/"))
                                .httpBasic(Customizer.withDefaults())
                                .csrf(csrf -> csrf.disable()) // Disable CSRF protection
                                .headers(headers -> headers.frameOptions(options -> options.disable())); // Disable
                                                                                                         // X-Frame-Options
                                                                                                         // header

                return http.build();
        }
}
