package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import lombok.Data;

@Entity
@Table(name = "materials")
@Data
public class MaterialEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private double ratings;
    private double factor;
    private String links;
    private int views;
    private long date;
    private String title;

}
