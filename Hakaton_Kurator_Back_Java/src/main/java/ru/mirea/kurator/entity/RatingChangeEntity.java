package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.validation.constraints.NotNull;

@Entity
@Table(name="ratingchange")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class RatingChangeEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @NotNull
    private Long userid;
    @NotNull
    private long date;
    @NotNull
    private double factor;

}
