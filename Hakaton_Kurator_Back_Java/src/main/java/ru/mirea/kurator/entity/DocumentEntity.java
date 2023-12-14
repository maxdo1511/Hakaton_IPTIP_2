package ru.mirea.kurator.entity;

import jakarta.persistence.*;
import jakarta.validation.constraints.NotEmpty;
import lombok.AllArgsConstructor;
import lombok.Data;
import lombok.NoArgsConstructor;
import ru.mirea.kurator.enums.DocumentStatus;
import ru.mirea.kurator.enums.UserRole;
import ru.mirea.kurator.validation.EnumValidator;

import javax.validation.constraints.NotNull;

@Entity
@Table(name="documents")
@Data
@AllArgsConstructor
@NoArgsConstructor
public class DocumentEntity {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @NotNull
    @NotEmpty
    private String group;
    @NotNull
    @NotEmpty
    private String title;
    @NotNull
    @NotEmpty
    private String description;
    @NotNull
    private long lastupdate;
    @NotNull
    @EnumValidator(enumClass = DocumentStatus.class)
    private String status;

}
