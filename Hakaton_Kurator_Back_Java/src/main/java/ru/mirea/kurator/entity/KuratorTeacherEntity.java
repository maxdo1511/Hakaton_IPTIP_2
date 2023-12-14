package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import lombok.Data;

import javax.validation.constraints.NotNull;

@Entity
@Table(name = "kurator_teachers")
@Data
public class KuratorTeacherEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @NotNull
    private Long userid;
    @NotNull
    private Long slaveid;

}
