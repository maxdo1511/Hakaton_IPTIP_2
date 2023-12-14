package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotEmpty;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.validation.constraints.NotNull;

@Entity
@Table(name="forum_section")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class ForumSectionEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private int Long;
    @NotNull
    private Long forumid;
    @NotNull
    @NotEmpty
    private String title;
    @NotNull
    @NotEmpty
    private String description;

}
