package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.validation.constraints.NotNull;

@Entity
@Table(name = "ratings")
@Data
public class RatingEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    @NotNull
    private Long userid;
    @NotNull
    private double education;
    @NotNull
    private double social;
    @NotNull
    private double documents;
    @NotNull
    private double factor;

}
