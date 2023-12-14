package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotEmpty;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;

import javax.validation.constraints.NotNull;

@Entity
@Table(name="event_comments")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class EventCommentEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @NotNull
    private Long eventid;
    @NotNull
    private Long userid;
    @NotNull
    @NotEmpty
    private String comment;
    @NotNull
    private long date;

}
