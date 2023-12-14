package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotEmpty;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.validation.constraints.NotNull;

@Entity
@Table(name="groups")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class GroupEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private Long userid;
    private Long slaveid;
    @NotNull
    @NotEmpty
    private String groupname;

}
