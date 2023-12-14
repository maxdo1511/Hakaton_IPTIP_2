package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotEmpty;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.validation.constraints.NotNull;
import javax.validation.constraints.Pattern;
import java.math.BigInteger;

@Entity
@Table(name="events")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class EventEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @NotNull
    @NotEmpty
    private String title;
    private String description;
    @Pattern(regexp = "https?:\\/\\/[A-ZА-Яa-zа-яёЁ\\-\\.\\d]{1,}\\.[A-ZА-Яa-zа-яёЁ\\-\\d]{2,}\\/?")
    private String link;
    @NotNull
    private int views;
    @NotNull
    private long nextdate;
    private long lastdate;
    @NotNull
    @NotEmpty
    @Pattern(regexp = "^[a-zа-я\\d ]+$")
    private String tags;
    @NotNull
    private double rating;
    @NotNull
    private double dynamic;

}
