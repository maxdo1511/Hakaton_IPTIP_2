package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import lombok.Data;

@Entity
@Table(name = "material_comments")
@Data
public class MaterialCommentEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private long materialid;
    private long userid;
    private String comment;
    private long date;

}
